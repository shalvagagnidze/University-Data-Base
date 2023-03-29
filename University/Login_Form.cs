using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace University
{
    
    public partial class WelcomePage : Form
    {
        public static WelcomePage instance;
        private  UniversityEntities2 _db = new UniversityEntities2();
        public static int userNameId;
        public static string userFullName;



        public WelcomePage()
        {
            InitializeComponent();
            instance = this;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
           
            string username, password;
            username = userName.Text;
            password = Password.Text;
            
            User user = _db.Users.FirstOrDefault(x => x.userName == username && x.userPassword ==password);
            userNameId = user.Id;
            userFullName = $"{user.Name} {user.LastName}";

            if (user != null)
            {
                this.Hide();
                switch (user.roleId)
                {
                    case 2:
                        Dashborad_Student studDash = new Dashborad_Student();
                        studDash.Show();
                        break;
                    case 3:
                        Dashboard_Lecturer lectDash = new Dashboard_Lecturer();
                        lectDash.Show();
                        break;
                }

            }
            else
            {
                MessageBox.Show("Invalid User Name or Password", 
                                "Sign In Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                username = "";
                password = "";
            }

    }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Account registerWin = new Account();
            registerWin.Show();
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPass.Checked)
            {
                Password.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '•';
            }
        }
    }
}
