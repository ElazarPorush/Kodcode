using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheHost
{
    public partial class Form2 : Form
    {
        public List<Form2> Forms;
        public int Position;
        public Form2(List<Form2> forms,int position, string categoryName)
        {
            InitializeComponent();
            Forms = forms;
            Position = position;
            lblCategory.Text = categoryName;

        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            
            DataTable result =  HostManeger.PrintMeals(lblCategory.Text);
            dataGridView1.DataSource = result;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (Position == 0)
            {
                Forms[Position].Visible = false;
                Forms[Forms.Count - 1].Show();
            }
            else
            {
                
                Forms[Position].Visible = false;
                Forms[Position - 1].Show();
            }
          
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

            if (Position == Forms.Count - 1)
            {
                Forms[Position].Visible = false;
                Forms[0].Show();
            }
            else
            {
                Forms[Position].Visible = false;
                Forms[Position + 1].Show();
            }
            
        }
    }
}
