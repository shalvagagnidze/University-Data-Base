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
    public partial class PersonalInfo : Form
    {
        
        public PersonalInfo()
        {
            InitializeComponent();
        }
        private UniversityEntities2 _db = new UniversityEntities2();
       
        string level,semesterNum, subFaculty;
        
        int semester, grant,subFacultyId;
        private void signUp1_txt_Click(object sender, EventArgs e)
        {

            subFaculty subfaculty = _db.subFaculties.FirstOrDefault(x => x.Id == subFacultyId);

            User user = _db.Users.FirstOrDefault(x => x.Id == Account.UserId);

            Student student = new Student()
            {
                Semester = semester,
                subFaculty = subfaculty,
                studentGrant = grant,
                User = user,
                studentLevel = level
            };

            _db.Students.Add(student);

            var result = _db.SaveChanges();


            if (result > 0)
            {


                MessageBox.Show("Your Account Has Been Successfully Created!",
                                "Registration Success", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                this.Hide();

                WelcomePage startPage = new WelcomePage();
                startPage.Show();
            }
            else
            {
                MessageBox.Show("Registation Failed!", 
                                "Registration Failed", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
            }
            
                
        }

        private void PersonalInfo_Load(object sender, EventArgs e)
        {
            bachelorCheckList.Visible = false;
            MasterCheckList.Visible = false;
            phdCheckList.Visible = false;
            flightSub.Visible = false;
            engineeringSub.Visible = false;
            businessSub.Visible = false;
        }

        private void MasterCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (MasterCheck.Checked)
            {
                BachelorCheck.Checked = false;
                phdCheck.Checked = false;
                bachelorCheckList.Visible = false;
                phdCheckList.Visible = false;
                MasterCheckList.Visible = true;
                level = "Master";
            }
        }

        private void phdCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (phdCheck.Checked)
            {
                MasterCheck.Checked = false;
                BachelorCheck.Checked = false;
                bachelorCheckList.Visible = false;
                MasterCheckList.Visible = false;
                phdCheckList.Visible = true;
                level = "PhD";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                grant = 50;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox4.Checked = false;
                checkBox6.Checked = false;
                grant = 70;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                grant = 100;
            }
        }

        private void MasterCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= (MasterCheckList.Items.Count - 1); i++)
            {
                if (MasterCheckList.GetItemChecked(i))
                {
                    semesterNum = MasterCheckList.Items[i].ToString();
                }
            }
            SemesterNum("I", 1);
            SemesterNum("II", 2);
            SemesterNum("III", 3);
            SemesterNum("IV", 4);
            
        }

        private void engineeringCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (engineeringCheck.Checked)
            {
                flightCheck.Checked = false;
                businessCheck.Checked = false;
                
                engineeringSub.Visible = true;
            }
        }

        private void businessCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (businessCheck.Checked)
            {
                engineeringCheck.Checked = false;
                flightCheck.Checked = false;
                
                businessSub.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (flightCheck.Checked)
            {
                engineeringCheck.Checked = false;
                businessCheck.Checked = false;
                
                flightSub.Visible = true;
            }
        }

        private void phdCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= (phdCheckList.Items.Count - 1); i++)
            {
                if (phdCheckList.GetItemChecked(i))
                {
                    semesterNum = phdCheckList.Items[i].ToString();
                }
            }
            SemesterNum("I", 1);
            SemesterNum("II", 2);
            SemesterNum("III", 3);
            SemesterNum("IV", 4);
            SemesterNum("V", 5);
            SemesterNum("VI", 6);
            
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flightSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= (flightSub.Items.Count - 1); i++)
            {
                if (flightSub.GetItemChecked(i))
                {
                    subFaculty = flightSub.Items[i].ToString();
                }
            }
            FacultyChecker(subFaculty, subFacultyId);
        }

        private void businessSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= (businessSub.Items.Count - 1); i++)
            {
                if (businessSub.GetItemChecked(i))
                {
                    subFaculty = businessSub.Items[i].ToString();
                }
            }
            FacultyChecker(subFaculty, subFacultyId);
        }

        private void engineeringSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= (engineeringSub.Items.Count - 1); i++)
            {
                if (engineeringSub.GetItemChecked(i))
                {
                    subFaculty = engineeringSub.Items[i].ToString();
                }
            }
            FacultyChecker(subFaculty, subFacultyId);
        }

        private void FacultyChecker(string subName, int subId)
        {
            if(subName == "Flight Exploitation of Air Transport ")
            {
                subFacultyId = 1;
            }

            if (subName == "Aircraft Flight Exploitation (CPL-A) ")
            {
                subFacultyId = 2;
            }

            if (subName == "Aircraft Flight Exploitation (CPL-H)")
            {
                subFacultyId = 3;
            }
          
            if (subName == "Air Transport Exploitation and Technologies")
            {
                subFacultyId = 4;
            }

            if (subName == "Aviation Information Systems")
            {
                subFacultyId = 7;
            }

            if (subName == "Design and Manufacture of Aerial Vehicles")
            {
                subFacultyId = 8;
            }

            if (subName == "Air Traffic Control Systems")
            {
                subFacultyId = 9;
            }

            if (subName == "Air Transport Management")
            {
                subFacultyId = 10;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            for (int i = 0; i <= (bachelorCheckList.Items.Count - 1); i++)
            {
                if (bachelorCheckList.GetItemChecked(i))
                {
                    semesterNum = bachelorCheckList.Items[i].ToString();
                }
            }
            SemesterNum("I", 1);
            SemesterNum("II", 2);
            SemesterNum("III", 3);
            SemesterNum("IV", 4);
            SemesterNum("V", 5);
            SemesterNum("VI", 6);
            SemesterNum("VII", 7);
            SemesterNum("VIII", 8);

        }

        private void SemesterNum(string semesterString, int numSemester)
        {
            if (semesterNum == semesterString)
            {
                semester = numSemester;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (BachelorCheck.Checked)
            {
                MasterCheck.Checked = false;
                phdCheck.Checked = false;
                bachelorCheckList.Visible = true;
                phdCheckList.Visible = false;
                MasterCheckList.Visible = false;
                level = "Bachelor";
            }
        }
    }
}

