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
    public partial class Dashborad_Student : Form
    {
        public static Dashborad_Student instance;
        public Label labelfacultyText;
        public Dashborad_Student()
        {
            InitializeComponent();
            instance = this;
            labelfacultyText = facultyText;

        }
        private UniversityEntities2 _db = new UniversityEntities2();

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
