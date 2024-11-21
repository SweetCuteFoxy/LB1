using Microsoft.VisualBasic.ApplicationServices;

namespace LB1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();
                labelUsers.Text = "List of Users:";
                foreach (User u in users)
                {
                    labelInfAboutUsers.Text += ($"{u.Id}. {u.Name} - {u.Age}\n");
                }
            }
        }

        private void labelUsers_Click(object sender, EventArgs e)
        {

        }
    }
}
