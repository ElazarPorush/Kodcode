using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            lstbxStudents.Items.Clear();
            List<string> students = StudentManejer.SearchStudents(txtInput.Text);
            foreach (var student in students)
            {
                lstbxStudents.Items.Add(student);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstbxStudents.Items.Clear();
            List<string> students = StudentManejer.AddStudent(txtInput.Text);
            foreach (var student in students)
            {
                lstbxStudents.Items.Add(student);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> students = StudentManejer.GetStudent();
            foreach (var student in students)
            {
                lstbxStudents.Items.Add(student);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(txtInput.Text);
            form2.Show();
        }

        private void lstbxStudents_DoubleClick(object sender, EventArgs e)
        {
            if (lstbxStudents.SelectedItem != null)
            {
                txtInput.Text = lstbxStudents.SelectedItem.ToString();
            }
        }
    }
}
