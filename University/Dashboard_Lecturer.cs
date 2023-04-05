using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class Dashboard_Lecturer : Form
    {
        int lecturerUserId,homeWorkScore,midScore,finalExScore,overallScore;


        private void lectDetailedGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
             homeWorkScore = int.Parse(lectDetailedGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
             midScore = int.Parse(lectDetailedGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
             finalExScore = int.Parse(lectDetailedGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
           
             overallScore = homeWorkScore + midScore + finalExScore;

        }

        string lecturerFullName, gradeSymbol = " ";
        private UniversityEntities2 _db = new UniversityEntities2();
        public Dashboard_Lecturer()
        {
            lecturerUserId = WelcomePage.userNameId;
            lecturerFullName = WelcomePage.userFullName;

            Lecturer lecturer = _db.Lecturers.FirstOrDefault(x => x.userId == lecturerUserId);

            Subject subject = _db.Subjects.FirstOrDefault(x => x.LectId == lecturer.Id);

            

            InitializeComponent();
            lectName.Text = lecturerFullName;

            lectSubjects.DataSource = _db.Subjects.Where(x => x.LectId == subject.LectId).Select(x => new { SubjcetName = x.Name}).ToList();
        }

        private void lectSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Lecturer lecturer = _db.Lecturers.FirstOrDefault(x => x.userId == lecturerUserId);

            Subject subject = _db.Subjects.FirstOrDefault(x => x.LectId == lecturer.Id);

            Grade grade = new Grade() { Grade1 = gradeSymbol, numericalGrade = overallScore };

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell selectedCell = lectSubjects.Rows[e.RowIndex].Cells[e.ColumnIndex];

                string cellValue = selectedCell.Value.ToString();

                



                if(cellValue == subject.Name)
                {
                     _db.Grades.Where(x => x.Subject.Name == cellValue)
                               .ToList()
                               .ForEach(x => { x.Grade1 = gradeSymbol; x.numericalGrade = overallScore; });
                                           
                                             
                    lectDetailedGrid.DataSource = _db.Grades.Where(x => x.Subject.Name == subject.Name)
                                                            .Select(x => new {Student = x.Student.User.Name+" "+ x.Student.User.LastName
                                                                             ,HomeWork = homeWorkScore
                                                                             ,Midterm = midScore
                                                                             ,Final_Exam = finalExScore
                                                                             ,Numerical = x.numericalGrade
                                                                             ,Grade = x.Grade1})
                                                                             .ToList();
                }
            }
        }
    }
}
