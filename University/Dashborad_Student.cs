using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Drawing;
using System.Xml.Linq;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;

namespace University
{
    public partial class Dashborad_Student : Form
    {
        public static Dashborad_Student instance;
        int studentUserId, subjectId,credits,numGrade =0;
        double avgGrade, gpa = 0, gwa = 0,totalGwa=0,totalCredits=0,userGpa;
        string studentFullName,newUserName,newPass,subjects,gradeSymbol = " ";
        private UniversityEntities2 _db = new UniversityEntities2();
        public Dashborad_Student()
        {
            instance = this;

            studentUserId = WelcomePage.userNameId;
            studentFullName = WelcomePage.userFullName;

            Student student = _db.Students.FirstOrDefault(x => x.userId == studentUserId);
            
            subFaculty subFaculty = _db.subFaculties.FirstOrDefault(x => x.Id == student.subFacultyId);
            
            SubjectList subList = new SubjectList() { subId = subjectId, studentId = studentUserId };
            

            var subject = _db.SubjectLists.Where(x => x.studentId == student.Id).Select(x => new { x.Subject.Name}).ToList();

            Grade grade = new Grade() { studentId = studentUserId, subId = subjectId, Grade1 = gradeSymbol, numericalGrade = numGrade };

            double averageGrade = (double)_db.Grades.Where(x => x.studentId == student.Id)
                                              .Average(x => x.numericalGrade);

            var creditsAndGrades= _db.Grades.Select(x => new { x.numericalGrade, x.Subject.Credits }).ToList();
            

            foreach (var item in creditsAndGrades)
            {
                if (item.numericalGrade > 91)
                {
                    gpa = 4;
                    gwa = (double)(gpa * item.Credits);
                    
                }
                else if (item.numericalGrade > 80 && item.numericalGrade < 91)
                {
                    gpa = 3;
                    gwa = (double)(gpa * item.Credits);
                }
                else if (item.numericalGrade > 70 && item.numericalGrade < 81)
                {
                    gpa = 2;
                    gwa = (double)(gpa * item.Credits);
                }
                else if (item.numericalGrade > 60 && item.numericalGrade < 71)
                {
                    gpa = 1;
                    gwa = (double)(gpa * item.Credits);
                }
                else
                {
                    gpa = 0.5;
                    gwa = (double)(gpa * item.Credits);
                }

                totalGwa += gwa;
                totalCredits += (double)item.Credits;

            }

            userGpa = totalGwa / totalCredits;

            student.avrgGrade = averageGrade;

            student.GPA = userGpa;
            
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



            for (int i = 0; i < subCheck.Items.Count; i++)
            {
                for(int j = 0; j< subject.Count; j++)
                {
                    if ("{ Name = "+subCheck.Items[i].ToString()+" }" == subject[j].ToString())
                    {
                        
                        subCheck.SetItemCheckState(i, CheckState.Indeterminate);
                    }
                }
            }


        }
        
        
        private void subjectCheck (int index,string title)
        {
            subCheck.Items.Insert(index, title);
            
        }

        private void userNameChange_CheckedChanged(object sender, EventArgs e)
        {
            if (userNameChange.Checked)
            {
                currentData.Text = currentData.Text + "User Name";
                currentData.Visible = true;
                confirmData.Text = confirmData.Text + "User Name";
                confirmData.Visible = true;
                newData.Text = newData.Text + "User Name";
                newData.Visible = true;
                currentBox.Visible = true;
                confirmBox.Visible = true;
                newBox.Visible = true;
                saveButton.Enabled = true;

               
            }
        }

        private void passChange_CheckedChanged(object sender, EventArgs e)
        {
            if (passChange.Checked)
            {
                currentData.Text = currentData.Text + "Password";
                currentData.Visible = true;
                confirmData.Text = confirmData.Text + "Password";
                confirmData.Visible = true;
                newData.Text = newData.Text + "Password";
                newData.Visible = true;
                currentBox.Visible = true;
                confirmBox.Visible = true;
                newBox.Visible = true;
                showPass.Visible = true;
                saveButton.Enabled = true;
                currentBox.PasswordChar = '•';
                confirmBox.PasswordChar = '•';
                newBox.PasswordChar = '•';
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if(currentBox.Text == confirmBox.Text)
            {
                newBox.Enabled = true;
            }
            else
            {
                MessageBox.Show("Data Doesn't Match!","Error!",MessageBoxButtons.OK
                                ,MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Student student = _db.Students.FirstOrDefault(x => x.userId == studentUserId);

            var subject = _db.SubjectLists.Where(x => x.studentId == student.Id)
                                                .Select(x => new { x.Subject.Name })
                                                .ToList();

            for (int i = 0; i < subCheck.Items.Count; i++)
            {
                for (int j = 0; j < subject.Count; j++)
                {
                    if ("{ Name = " + subCheck.Items[i].ToString() + " }" == subject[j].ToString())
                    {

                        subCheck.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                currentBox.PasswordChar = '\0';
                confirmBox.PasswordChar = '\0';
                newBox.PasswordChar = '\0';
            }
            else
            {
                currentBox.PasswordChar = '•';
                confirmBox.PasswordChar = '•';
                newBox.PasswordChar = '•';
            }
        }

        private void settingsPanel_Click(object sender, EventArgs e)
        {
            this.panel4.Location = this.personalInfoPanel.Location;
            personalInfoPanel.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            if (userNameChange.Checked)
            {
                User user = _db.Users.FirstOrDefault(x => x.userName == currentBox.Text);

                if (user != null)
                {
                    if (user.userName == confirmBox.Text)
                    {
                       
                        newUserName = newBox.Text;
                        user.userName = newUserName;
                        
                        _db.SaveChanges();
                        MessageBox.Show("User Name Changed Successfully!", "User Name Confirmation"
                                         , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User Names Do NOT Match! Try Again", "Confirmation Error"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User Name Doesn't Exists! Try Again", "User Name Error"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            if (passChange.Checked)
            {
                User userPass = _db.Users.FirstOrDefault(x => x.userPassword == currentBox.Text);


                if(userPass != null)
                {
                    if (userPass.userPassword.Equals(confirmBox.Text))
                    {
                        
                        newPass = newBox.Text;
                        userPass.userPassword = newPass;
                        _db.SaveChanges();
                        MessageBox.Show("Password Changed Successfully!", "Password Confirmation"
                                         , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Password is incorrect! Try Again", "Password Error"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
        }

        private void Dashborad_Student_Load(object sender, EventArgs e)
        {
            //    // TODO: This line of code loads data into the 'universityDataSet.User' table.
            //    You can move, or remove it, as needed.
            //    this.userTableAdapter.Fill(this.universityDataSet.User);
            personalInfoPanel.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.White;
            personalInfoPanel.Show();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();


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
            panel4.Hide();
            panel3.Hide();
           
        }

       

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void studentClasses_Click(object sender, EventArgs e)
        {


            this.panel3.Location = this.personalInfoPanel.Location;
            personalInfoPanel.Hide();
            panel2.Hide();
            panel4.Hide();
            panel3.Show();


            studentUserId = WelcomePage.userNameId;

            Student student = _db.Students.FirstOrDefault(x => x.userId == studentUserId);

            Subject subjects = _db.Subjects.FirstOrDefault(x => x.facId == student.subFacultyId);

            classesDataGrid.DataSource = _db.Grades.Where(x => x.studentId == student.Id)
                                                     .Select(x => new {Subject = x.Subject.Name,
                                                             Grade = x.Grade1,Numerical = x.numericalGrade})
                                                     .ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Student student = _db.Students.FirstOrDefault(x => x.userId == studentUserId);

            var subExists = _db.SubjectLists.Where(x => x.studentId == student.Id);

            var gradeExists = _db.Grades.Where(x => x.studentId == student.Id);

            if(subExists.Any())
            {
                _db.SubjectLists.RemoveRange(subExists);
                
               _db.SaveChanges();
            }

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

            var grades = _db.Subjects.Where(o => checkedSubjects.Contains(o.Name))
                                              .ToList()
                                              .Select(o => new Grade
                                              {
                                                  studentId = student.Id,
                                                  subId = o.Id,
                                                  Grade1 = gradeSymbol,
                                                  numericalGrade = numGrade
                                              });
                                              
            _db.Grades.AddRange(grades);

            var gradeNotExists = _db.Grades.Where(o => !checkedSubjects.Contains(o.Subject.Name));

            if (gradeNotExists.Any())
            {
                _db.Grades.RemoveRange(gradeNotExists);
            }
           
            var results = _db.SaveChanges();

            if(results > 0)
            {
                MessageBox.Show("You Choose Your Classes Successfully!", "Course Successful Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You Must Choose At Least One Class!", "Course Selection Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
