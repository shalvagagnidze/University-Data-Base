using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace University
{
    public partial class Dashborad_Student : Form
    {
        public static Dashborad_Student instance;
        int studentUserId, subjectId;
        private UniversityEntities2 _db = new UniversityEntities2();
        public Dashborad_Student()
        {
            instance = this;

            studentUserId = WelcomePage.userNameId;

            Student student = _db.Students.FirstOrDefault(x => x.userId == studentUserId);
            
            subFaculty subFaculty = _db.subFaculties.FirstOrDefault(x => x.Id == student.subFacultyId);
            
            SubjectList subList = new SubjectList() { subId = subjectId, studentId = studentUserId };

            InitializeComponent();
            facultyText.Text = subFaculty.Name;
            ectsNum.Text = student.Credit.ToString();
            avrgGrade.Text = student.avrgGrade.ToString();
            gpaNum.Text = student.GPA.ToString();
            
            if(student.Semester == 1)
            {
                switch (subFaculty.Id)
                {
                    case 1:
                        subjectCheck(0, "Linear Algebra and Analytical Geometry");
                        subjectCheck(1, "Engineering Graphics");
                        subjectCheck(2, "Psychology");
                        subjectCheck(3, "Mathematical Analysis for Engineers");
                        break;
                    case 2:
                        subjectCheck(0, "Physics 1");
                        subjectCheck(1, "Computer skills");
                        subjectCheck(2, "Engineering Graphics");
                        subjectCheck(3, "Theoretical Mechanics");
                        break;
                    case 3:
                        subjectCheck(0, "Academic writing");
                        subjectCheck(1, "High school pedagogy");
                        subjectCheck(2, "International air law");
                        subjectCheck(3, "Research methods in business");
                        break;
                }
            } else if(student.Semester == 2)
            {
                switch (subFaculty.Id)
                {
                    case 1:
                        subjectCheck(0, "Mechanics: Molecular Physics ");
                        subjectCheck(1, "Computer Graphics");
                        subjectCheck(2, "General Chemistry");
                        subjectCheck(3, "Meteorology");
                        break;
                    case 2:
                        subjectCheck(0, "Aircraft engines");
                        subjectCheck(1, "Aircraft reliability report");
                        subjectCheck(2, "Aircraft functional systems");
                        subjectCheck(3, "Design and installation of assembly connections");
                        break;
                    case 3:
                        subjectCheck(0, "Performance management");
                        subjectCheck(1, "Aircraft technical management");
                        subjectCheck(2, "Financial analysis in aviation");
                        subjectCheck(3, "Airline business and global airlines");
                        break;
                }
            }
            
        }
        
        
        private void subjectCheck (int index,string title)
        {
            subCheck.Items.Insert(index, title);
            
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

        string tests;
        private void button1_Click(object sender, EventArgs e)
        {
            Student student = _db.Students.FirstOrDefault(x => x.userId == studentUserId);

            var checkedSubjects = subCheck.CheckedItems.Cast<string>().ToList();

           

            var newSubjectsList = _db.Subjects.Where(o => checkedSubjects.Contains(o.Name))
                                              .ToList()
                                              .Select(o => new SubjectList { subId = o.Id, studentId = student.Id });
                                            
            
            _db.SubjectLists.AddRange(newSubjectsList);
            
            _db.SaveChanges();


            
        }
    }
}
