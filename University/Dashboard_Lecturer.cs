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
        int lecturerUserId,homeWorkScore,midScore,finalExScore,overallScore,index;

        //private void lectDetailedGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    homeWorkScore = int.Parse(lectDetailedGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        //    midScore = int.Parse(lectDetailedGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
        //    finalExScore = int.Parse(lectDetailedGrid.Rows[e.RowIndex].Cells[1].Value.ToString());

        //    overallScore = homeWorkScore + midScore + finalExScore;
        //}

        //private bool cellClickedOnce = false;
        //private int clickedRowIndex = -1;
        //private int clickedColumnIndex = -1;


        //private void lectDetailedGrid_CellMouseUp_1(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Left)
        //    {
        //        if (!cellClickedOnce)
        //        {
        //            clickedRowIndex = e.RowIndex;
        //            clickedColumnIndex = e.ColumnIndex;
        //            cellClickedOnce = true;
        //        }
        //        else if (e.RowIndex == clickedRowIndex && e.ColumnIndex == clickedColumnIndex)
        //        {
        //            lectDetailedGrid.BeginEdit(true);
        //            cellClickedOnce = false;
        //        }
        //        else
        //        {
        //            clickedRowIndex = e.RowIndex;
        //            clickedColumnIndex = e.ColumnIndex;
        //        }
        //    }
        //}

      

        private void lectDetailedGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            lectDetailedGrid.CurrentRow.Selected = true;
            nameBox.Text = lectDetailedGrid.Rows[e.RowIndex].Cells["Student"].Value.ToString();
            homeWorkBox.Text = lectDetailedGrid.Rows[e.RowIndex].Cells["HomeWork"].Value.ToString();
            midtermBox.Text = lectDetailedGrid.Rows[e.RowIndex].Cells["Midterm"].Value.ToString();
            finalBox.Text = lectDetailedGrid.Rows[e.RowIndex].Cells["Final_Exam"].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the corresponding record in the DataGridView here
                DataGridViewRow row = lectDetailedGrid.Rows[index];
                row.Cells["HomeWork"].Value = homeWorkBox.Text;
                row.Cells["Midterm"].Value = midtermBox.Text;
                row.Cells["Final_Exam"].Value = finalBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //try
            //{
            //    DataGridViewRow newDataRow = lectDetailedGrid.Rows[index];
            //    newDataRow.Cells[1].Value = homeWorkBox.Text;
            //    newDataRow.Cells[2].Value = midtermBox.Text;
            //    newDataRow.Cells[3].Value = finalBox.Text;

            //    // Update the corresponding record in the database here
            //    // var students = _db.Students.FirstOrDefault(x => x.User.Name + " " + x.User.LastName == nameBox.Text);
            //    // if (students != null)
            //    // {
            //    //     students.HomeWork = int.Parse(homeWorkBox.Text);
            //    //     students.Midterm = int.Parse(midtermBox.Text);
            //    //     _db.SaveChanges();
            //    // }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("An error occurred while updating the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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
