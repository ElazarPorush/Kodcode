using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Public_Domain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Piller piller = new Piller();
            piller.Hight = float.Parse(txtHight.Text);
            piller.Width = float.Parse(txtWidth.Text);
            if (rdbtnRR.Checked == true)
            {
                piller.Area = rdbtnRR.Text;
            }
            else if (rdbtnCR.Checked == true)
            {
                piller.Area = rdbtnCR.Text;
            }
            else if (rdbtnRY.Checked == true)
            {
                piller.Area = rdbtnRY.Text;
            }
            MessageBox.Show(piller.Domain);

        }
    }
}
