using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeClock
{
    public partial class Change_password : Form
    {
        public Change_password()
        {
            InitializeComponent();
        }



        private void btnEnter_Click(object sender, EventArgs e)
        {
            string result = EmployeeManeger.ChangePassword(txtID.Text, txtOldPassword.Text, txtNewPassword.Text, txtCheck.Text);
            MessageBox.Show(result);
        }

        private void txtCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string result = EmployeeManeger.ChangePassword(txtID.Text, txtOldPassword.Text, txtNewPassword.Text, txtCheck.Text);
                MessageBox.Show(result);
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtOldPassword.Focus();
                e.Handled = true;
            }
        }

        private void txtOldPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtNewPassword.Focus();
                e.Handled = true;
            }
        }

        private void txtNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCheck.Focus();
                e.Handled = true;
            }
        }
    }
}
