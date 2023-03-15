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



        public WelcomePage()
        {
            InitializeComponent();
            instance = this;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
           // con.Open();
            
            string username, password;
            username = userName.Text;
            password = Password.Text;
            
            User user = _db.Users.FirstOrDefault(x => x.userName == username && x.userPassword ==password);
            userNameId = user.Id;

            if (user != null)
            {
                this.Hide();
                switch (user.roleId)
                {
                    case 2:
                        Dashborad_Student studDash = new Dashborad_Student();

                        //string facultyUserId = _db.Users.Where(x => x.Email == username).Select(x => x.Id).ToString();
                        //Dashborad_Student.instance.studentUserId

                        studDash.Show();
                        break;
                    case 3:
                        Dashboard_Lecturer lectDash = new Dashboard_Lecturer();
                        //lectDash.Show();
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



            // string login = "Select * from Login Where UserName = '" + username + "' and Password = '" + password + "'";
            // cmd = new SqlCommand(login, con);
            // SqlDataReader dr = cmd.ExecuteReader();


            //if (dr.Read() == true)
            //{
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid User Name or Password", "Sign In Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    username = "";
            //    password = "";
            //}
            //con.Close();
            //Dashborad_Student form = new Dashborad_Student();
            //form.Show();

            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DKS9GVJ\SQL_2022;Initial Catalog=University;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            //cmd.CommandText = "select * from Student where id=5";
            //cmd.Parameters.AddWithValue("id", userName.Text);
            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //if (reader.Read())

            //{
            //    //Console.WriteLine(reader["Id"]);
            //     Dashborad_Student.instance.labelfacultyText.Text = reader["GPA"].ToString();
            //    //while (reader.Read())
            //    //{
            //    //    Console.WriteLine("{0} {1} {2}", reader["Id"], reader["studentLevel"], reader["studentGrant"]);
            //    //}
      //  }
        ////con.Open();
        //SqlCommand cmd = new SqlCommand("select subFaucltyId,Credit,avrgGrade,GPA from Student where id=5");
        ////cmd.Parameters.AddWithValue("id", userName.Text);
        ////SqlDataAdapter sda = new SqlDataAdapter();
        //SqlDataReader reader = cmd.ExecuteReader();
        //if (reader.Read())
        //{
        //    Dashborad_Student.instance.labelfacultyText.Text = reader["subFaucltyId"].ToString();
        //    //form.instance.labelfacultyText.Text= reader["subFaucltyId"].ToString();
        //    // label1.Text = reader["subFaucltyId"].ToString();
        //}
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
