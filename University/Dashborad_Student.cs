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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using University.UniversityDataSetTableAdapters;

namespace University
{
    public partial class Dashborad_Student : Form
    {
        public static Dashborad_Student instance;
        int studentUserId;
        private UniversityEntities2 _db = new UniversityEntities2();
        public Dashborad_Student()
        {
            instance = this;
            studentUserId = WelcomePage.userNameId;

            //ectsNum.Text = "";
            //avrgGrade.Text = "";
            //gpaNum.Text = "";

            Student student = _db.Students.FirstOrDefault(x => x.userId == studentUserId);
            


            subFaculty subFaculty = _db.subFaculties.FirstOrDefault(x => x.Id == student.subFacultyId);

            //Student facultyUserId = _db.Students.Where(x => x.userId == studentUserId).Select(x => x.subFacultyId);
            //string facultyUserId = _db.Users.Where(x => x.Email== studentUserId).Select(x => x.Id).FirstOrDefault();
            //int test = Int32.Parse(facultyUserId);
            //string facultyUserName = _db.subFaculties.Where(x => x.Id == test).Select(x => x.Name).ToString();



            InitializeComponent();
            facultyText.Text = subFaculty.Name.ToString();
            ectsNum.Text = student.Credit.ToString();
            avrgGrade.Text = student.avrgGrade.ToString();
            gpaNum.Text = student.GPA.ToString();
        }
        
        

        private void Dashborad_Student_Load(object sender, EventArgs e)
        {
            personalInfoPanel.Visible = true;
        }

        private void personalInfo_Click(object sender, EventArgs e)
        {
            personalInfoPanel.Visible = true;
            panel2.Visible = false;
            personalInfoPanel.BringToFront();

        }

        private void academicRegistration_Click(object sender, EventArgs e)
        {
           // personalInfoPanel.Visible = false;
            personalInfoPanel.SendToBack();
            panel2.Visible = true;
            panel2.BringToFront();
        }

        private void facultyText_Click(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
