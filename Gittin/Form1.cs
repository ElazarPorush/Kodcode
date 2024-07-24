using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gittin
{
    public partial class Form1 : Form
    {
        private GitinManeger gitinManeger;
        public Form1()
        {
            InitializeComponent();
            gitinManeger = new GitinManeger(MainProject.Main());
        }

        private void btnConforme_Click(object sender, EventArgs e)
        {
            List<string> names = new List<string>() { cmbxDayInWeek.Text, cmbxDayInMonth.Text, cmbxMonth.Text, cmbxYear.Text };
            string result = gitinManeger.AddQuery(names);
            gitinManeger.Save();
            MessageBox.Show(result,"תוצאות", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblDateTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
