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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btnListSubjects_Click(object sender, EventArgs e)
        {
            List<Form2> forms = new List<Form2>();
            List<string> courses = CourseManejer.GetCourses();
            for (int i = 0; i < courses.Count; i++)
            {
                forms.Add(new Form2(courses, i, courses[i]));
            }
            int index = 0;
            if (txtCourse.Text != null)
            {
                for (int i = 0; i < courses.Count; i++)
                {
                    if (courses[i] == txtCourse.Text)
                    {
                        index = i;
                        break;
                    }
                }
            }
            forms[index].Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> Courses = CourseManejer.GetCourses();
            foreach (var course in Courses)
            {
                lstbxCorses.Items.Add(course);
            }
        }

        private void lstbxCorses_DoubleClick(object sender, EventArgs e)
        {
            if (lstbxCorses.SelectedItem != null)
            {
                txtCourse.Text = lstbxCorses.SelectedItem.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstbxCorses.Items.Clear();
            txtCourse.Text = "";
            List<string> Courses = CourseManejer.DeleteCourse(txtCourse.Text);
            foreach (var course in Courses)
            {
                lstbxCorses.Items.Add(course);
            }
        }

        private void txtCourse_KeyUp(object sender, KeyEventArgs e)
        {
            lstbxCorses.Items.Clear();
            List<string> courses = CourseManejer.SearchCourses(txtCourse.Text);
            foreach (var course in courses)
            {
                lstbxCorses.Items.Add(course);
            }
        }
    }
}
