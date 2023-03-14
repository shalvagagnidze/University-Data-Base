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

namespace University
{
    public partial class Account : Form
    {
        public static int UserId = 0;

        public Account()
        {
            InitializeComponent();
            
        }
        private UniversityEntities2 _db = new UniversityEntities2();

        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4067AMO5\SQLEXPRESS;Initial Catalog=University;Integrated Security=True");
        //SqlCommand cmd = new SqlCommand();
        //SqlDataAdapter sda = new SqlDataAdapter();


        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        int roleId;
        private void button1_Click(object sender, EventArgs e)
        {
            string username, password, conPassword, firstName, lastName, email;

            username = username_txt.Text;
            password = Pass_txt.Text;
            conPassword = conPass_txt.Text;
            firstName = FirstName.Text;
            lastName = LastName.Text;
            email = Email.Text;
            var birthDate = dateTimePicker1.Value;

            User exUser = _db.Users.FirstOrDefault(x => x.userName == username);


            if (string.IsNullOrWhiteSpace(username_txt.Text) ||
                string.IsNullOrWhiteSpace(FirstName.Text) ||
                string.IsNullOrWhiteSpace(LastName.Text) ||
                string.IsNullOrWhiteSpace(Email.Text) ||
                string.IsNullOrWhiteSpace(Pass_txt.Text) ||
                string.IsNullOrWhiteSpace(conPass_txt.Text))
            {
                MessageBox.Show("Please, Fill All Required Fields",
                                "Some Fields Are Empty",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (exUser != null)
            {
                MessageBox.Show("User Name Already Taken, Try Again", 
                                "User Name Already Exists",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if(Pass_txt.Text.Any(Char.IsUpper) == false && Pass_txt.Text.Any(Char.IsNumber) == false)
            {
                MessageBox.Show("Password Must Contain: At Least 1 Upper Case Or " +
                                "At Least 1 Numeric Character",
                                "Password Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (Pass_txt.TextLength <8)
            {
                MessageBox.Show("Password Must Contain At Least 8 Characters",
                                "Password Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                SignIn();
            }

            void SignIn()
            {


                if (Pass_txt.Text == conPass_txt.Text)
                {
                    Role role = _db.Roles.FirstOrDefault(o => o.Id == roleId);

                    User user = new User() { Birth = birthDate,
                        Name = firstName,
                        LastName = lastName,
                        Email = email,
                        Role = role,
                        userName = username,
                        userPassword = password };

                    _db.Users.Add(user);
                    _db.SaveChanges();

                    UserId = user.Id;
                    //con.Open();
                    //string register = "insert into [User](Name,LastName,Email,roleId,userName,userPassword) values('" + firstName + "','" + lastName + "','" + email + "','"+roleId+"','"+username+"','"+password+"')";

                    //cmd = new SqlCommand(register, con);
                    //cmd.ExecuteNonQuery();
                    //con.Close();

                    MessageBox.Show("Your Account Has Been Successfully Created!",
                                    "Registration Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    PersonalInfo persInfo = new PersonalInfo();
                    persInfo.Show();
                }
                else
                {
                    MessageBox.Show("Passwords Doesn't Match", "Password Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Pass_txt.Text = "";
                    conPass_txt.Text = "";
                    Pass_txt.Focus();
                }


            }
        }
        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                Pass_txt.PasswordChar = '\0';
                conPass_txt.PasswordChar = '\0';
            }
            else
            {
                Pass_txt.PasswordChar = '•';
                conPass_txt.PasswordChar = '•';
            }
        }

        private void persInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" You Haven't Filled Out All Required Fields Yet",
                            "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            username_txt.Text = "";
            FirstName.Text = "";
            LastName.Text = "";
            Email.Text = "";
            Pass_txt.Text = "";
            conPass_txt.Text = "";
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Show();

        }

        private void studentCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (studentCheck.Checked)
            {
                roleId = 2;
                lecturerCheck.Checked = false;
            }
        }

        private void lecturerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (lecturerCheck.Checked)
            {
                roleId = 3;
                studentCheck.Checked = false;
            }
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void passCheck_Click(object sender, EventArgs e)
        {

        }
        
        private void Pass_txt_TextChanged(object sender, EventArgs e)
        {
            var checkPass1 = Pass_txt.Text.Any(Char.IsUpper);
            var checkPass2 = Pass_txt.Text.Any(Char.IsNumber);
            var passLength = Pass_txt.TextLength;

            if(passLength < 8)
            {
                redPanel.BackColor = Color.Red;
                orangePanel.BackColor = Color.White;
                greenPanel.BackColor = Color.White;
                passCheck.ForeColor = Color.Red;
                passCheck.Text = "Weak Password";
            }
            else if (checkPass1 == false && checkPass2 == false)
            {
                redPanel.BackColor = Color.Red;
                orangePanel.BackColor = Color.White;
                greenPanel.BackColor = Color.White;
                passCheck.ForeColor = Color.Red;
                passCheck.Text = "Weak Password";
            }
            else if (checkPass1 == false || checkPass2 == false && passLength > 7)
            {
                redPanel.BackColor = Color.Orange;
                orangePanel.BackColor = Color.Orange;
                greenPanel.BackColor = Color.White;
                passCheck.ForeColor = Color.Orange;
                passCheck.Text = "Medium Password";
            }        
            else
            {
                redPanel.BackColor = Color.Green;
                orangePanel.BackColor = Color.Green;
                greenPanel.BackColor = Color.Green;
                passCheck.ForeColor = Color.Green;
                passCheck.Text = "Strong Password";
            }
            
        }
    }
}
