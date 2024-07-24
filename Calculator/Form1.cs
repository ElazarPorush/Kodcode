using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        private TextBox selectedTextBox;
        //private Button selectedButten;
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            // 1. Convert 'string' to 'int'
            float num1 = float.Parse(txtNumber1.Text);
            float num2 = float.Parse(txtNumber2.Text);
            // 2.Validate inputs

            // 3. Perform calculation
            if (cmbOperator.Text == "+")
            {
                lblResult.Text = (num1 + num2).ToString();
            }
            else if (cmbOperator.Text == "-")
            {
                lblResult.Text = (num1 - num2).ToString();
            }
            else if (cmbOperator.Text == "x")
            {
                lblResult.Text = (num1 * num2).ToString();
            }
            else if (cmbOperator.Text == "/")
            {
                if (num2 == 0)
                    //lblResult.Text = "Eror";
                    return;

                lblResult.Text = (num1 / num2).ToString();
            }
        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnNum_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += ((Button)sender).Text;
       }
        private void btnNum1_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "9";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "0";
        }

        private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTextBox = txtNumber2;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            cmbOperator.Text = "+";
            selectedTextBox = txtNumber2;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            cmbOperator.Text = "-";
            selectedTextBox = txtNumber2;
        }

        private void btnslesh_Click(object sender, EventArgs e)
        {
            cmbOperator.Text = "/";
            selectedTextBox = txtNumber2;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            cmbOperator.Text = "x";
            selectedTextBox = txtNumber2;
        }

        private void txtNumber1_Enter(object sender, EventArgs e)
        {
            selectedTextBox = sender as TextBox;
        }

        private void txtNumber2_Enter(object sender, EventArgs e)
        {
            selectedTextBox = sender as TextBox;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += ".";
        }

    }
}
