using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace University
{
    public partial class Dashborad_Student : Form
    {
        public static Dashborad_Student instance;
        int studentUserId, subjectId;
        double avgGrade;
        string studentFullName;
        private UniversityEntities2 _db = new UniversityEntities2();
        public Dashborad_Student()
        {
            instance = this;

            studentUserId = WelcomePage.userNameId;
            studentFullName = WelcomePage.userFullName;

            Student student = _db.Students.FirstOrDefault(x => x.userId == studentUserId);
            
            subFaculty subFaculty = _db.subFaculties.FirstOrDefault(x => x.Id == student.subFacultyId);
            
            SubjectList subList = new SubjectList() { subId = subjectId, studentId = studentUserId };

            double averageGrade = (double)_db.Grades.Where(x => x.studentId == student.Id)
                                              .Average(x => x.numericalGrade);

            student.avrgGrade = averageGrade;

            
            InitializeComponent();

           
            facultyText.Text = subFaculty.Name;
            ectsNum.Text = student.Credit.ToString();
            avrgGrade.Text = student.avrgGrade.ToString();
            gpaNum.Text = student.GPA.ToString();
            studName.Text = studentFullName.ToString();
           
            
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
            //    // TODO: This line of code loads data into the 'universityDataSet.User' table. You can move, or remove it, as needed.
            //    this.userTableAdapter.Fill(this.universityDataSet.User);
           
            personalInfoPanel.Show();
            panel2.Hide();
            panel3.Hide();


        }
        
        private void personalInfo_Click(object sender, EventArgs e)

        {
            personalInfoPanel.Show();
            panel2.Hide();
            panel3.Hide();
            
        }

        private void academicRegistration_Click(object sender, EventArgs e)
        {
            this.panel2.Location=this.personalInfoPanel.Location;
            personalInfoPanel.Hide();
            panel2.Show();
            panel3.Hide();
           
        }

        private void facultyText_Click(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string tests;

        private void studentClasses_Click(object sender, EventArgs e)
        {


            this.panel3.Location = this.personalInfoPanel.Location;
            personalInfoPanel.Hide();
            panel2.Hide();
            panel3.Show();


            studentUserId = WelcomePage.userNameId;
            Student student = _db.Students.FirstOrDefault(x => x.userId == studentUserId);

            Subject subjects = _db.Subjects.FirstOrDefault(x => x.facId == student.subFacultyId);

            classesDataGrid.DataSource = _db.Grades.Where(x => x.studentId == student.Id)
                                                     .Select(x => new {Subject = x.Subject.Name,Grade = x.Grade1,Numerical = x.numericalGrade})
                                                     .ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = _db.Students.FirstOrDefault(x => x.userId == studentUserId);

            var checkedSubjects = subCheck.CheckedItems.Cast<string>().ToList();

           

            var newSubjectsList = _db.Subjects.Where(o => checkedSubjects.Contains(o.Name))
                                              .ToList()
                                              .Select(o => new SubjectList { subId = o.Id, 
                                                                             studentId = student.Id });

            var subjectCredits = _db.Subjects.Where(o => checkedSubjects.Contains(o.Name))
                                             .ToList().Select(o => o.Credits);

            student.Credit = subjectCredits.Sum();

            ectsNum.Text = student.Credit.ToString();

            _db.SubjectLists.AddRange(newSubjectsList);
            
            var results = _db.SaveChanges();

            if(results > 0)
            {
                MessageBox.Show("You Choose Your Classes Successfully!", "Course Successful Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You Must Choose At Least One Class!", "Course Unsuccessful Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




            
        }
    }
}
