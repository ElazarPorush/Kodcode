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
    public partial class Form2 : Form
    {
        public List<string> Courses;
        public int Position;
        public Form2(List<string> courses, int position, string courseName)
        {
            InitializeComponent();
            Courses = courses;
            Position = position;
            lblCourse.Text = courseName;

        }
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4(lblCourse.Text);
            form4.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblCourse.Text = Courses[Position];
            DataTable result = CourseManejer.PrintSubjects(lblCourse.Text);
            dataGridView1.DataSource = result;
            txtDeleteSubject.Visible = false;
            btnDeleteSubjectOk.Visible = false;
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            txtDeleteSubject.Visible = true;
            btnDeleteSubjectOk.Visible = true;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (Position == 0)
            {
                Position = Courses.Count - 1;    
            }
            else
            {
                Position--;
            }
            lblCourse.Text = Courses[Position];
            DataTable result = CourseManejer.PrintSubjects(lblCourse.Text);
            dataGridView1.DataSource = result;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (Position == Courses.Count - 1)
            {
                Position = 0;
            }
            else
            {
                Position++;
            }
            lblCourse.Text = Courses[Position];
            DataTable result = CourseManejer.PrintSubjects(lblCourse.Text);
            dataGridView1.DataSource = result;
        }

        private void btnDeleteSubjectOk_Click(object sender, EventArgs e)
        {
            CourseManejer.DeleteSubject(txtDeleteSubject.Text);
            txtDeleteSubject.Text = null;
            txtDeleteSubject.Visible = false;
            this.btnDeleteSubjectOk.Visible = false;
            DataTable result = CourseManejer.PrintSubjects(lblCourse.Text);
            dataGridView1.DataSource = result;
        }
    }
}
