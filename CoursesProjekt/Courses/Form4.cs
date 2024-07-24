using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses
{
    public partial class Form4 : Form
    {
        public string CourseName;
        public Form4(string courseName)
        {
            InitializeComponent();
            CourseName = courseName;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
          
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            CourseManejer.AddSubject(CourseName, txtNameSubject.Text, txtHoursSubject.Text, txtNameTeacher.Text, txtPriceTeacher.Text);
            this.Visible = false;
            CourseManejer.PrintSubjects(CourseName);
        }
    }
}
