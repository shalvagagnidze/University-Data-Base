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
        int lecturerUserId;
        private UniversityEntities2 _db = new UniversityEntities2();
        public Dashboard_Lecturer()
        {
            lecturerUserId = WelcomePage.userNameId;

            Lecturer lecturer = _db.Lecturers.FirstOrDefault(x => x.userId == lecturerUserId);

           
            InitializeComponent();
            dataGridView1.DataSource = _db.Subjects.Where(x => x.LectId == 4).Select(x => new { SubjcetName = x.Name, gradess = x.Grades }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
