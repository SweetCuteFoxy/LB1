namespace LB1
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            labelUsers = new Label();
            panel1 = new Panel();
            labelInfAboutUsers = new Label();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.AutoSize = true;
            panelTop.Controls.Add(labelUsers);
            panelTop.Location = new Point(-1, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(803, 100);
            panelTop.TabIndex = 0;
            // 
            // labelUsers
            // 
            labelUsers.Dock = DockStyle.Fill;
            labelUsers.Location = new Point(10, 10);
            labelUsers.Name = "labelUsers";
            labelUsers.Padding = new Padding(10);
            labelUsers.Size = new Size(783, 80);
            labelUsers.TabIndex = 0;
            labelUsers.Text = "List of Users:";
            labelUsers.TextAlign = ContentAlignment.TopCenter;
            labelUsers.Click += labelUsers_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(labelInfAboutUsers);
            panel1.Location = new Point(-1, 93);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(803, 360);
            panel1.TabIndex = 1;
            // 
            // labelInfAboutUsers
            // 
            labelInfAboutUsers.AutoSize = true;
            labelInfAboutUsers.Dock = DockStyle.Fill;
            labelInfAboutUsers.Location = new Point(10, 10);
            labelInfAboutUsers.Name = "labelInfAboutUsers";
            labelInfAboutUsers.Padding = new Padding(10);
            labelInfAboutUsers.Size = new Size(20, 35);
            labelInfAboutUsers.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Name = "FormMain";
            Text = "Users";
            panelTop.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Label labelUsers;
        private Panel panel1;
        private Label labelInfAboutUsers;
    }
}
