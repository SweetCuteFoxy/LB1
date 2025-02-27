namespace LB1
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            // ���������� ������
            using (ApplicationContext db = new ApplicationContext())
            {
                // ������� ��� ������� User
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Alice", Age = 26 };

                // ��������� �� � ��
                db.Users.AddRange(user1, user2);
                db.SaveChanges();
            }
            // ��������� ������
            using (ApplicationContext db = new ApplicationContext())
            {
                // �������� ������� �� �� � ������� �� �������
                var users = db.Users.ToList();
                Console.WriteLine("Users list:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}