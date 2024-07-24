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
    public partial class Form2 : Form
    {
        public string Name;
        public Form2(string name)
        {
            InitializeComponent();
            Name = name;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblName.Text = Name;
            DataTable result = StudentManejer.PrintCourses();
            dataGridView1.DataSource = result;
            txtAddChoice.Visible = false;
            btnPay.Visible = false;
            btnOkey.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtAddChoice.Visible = true;
            btnPay.Visible = true;
            btnOkey.Visible = true;
        }
    }
}
