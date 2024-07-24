using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> categories = HostManeger.GetCategories();
            foreach (var category in categories)
            {
                lstbxCategories.Items.Add(category);
            }

        }

        private void lstbxCategories_DoubleClick(object sender, EventArgs e)
        {
            if (lstbxCategories.SelectedItem != null)
            {
                txtCategoy.Text = lstbxCategories.SelectedItem.ToString();
            }
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            List<Form2> forms = new List<Form2>();
            List<string> categories = HostManeger.GetCategories();
            for (int i = 0; i < categories.Count; i++)
            {           
                forms.Add(new Form2(forms, i, categories[i]));
            }
            int index = 0;
            if (txtCategoy.Text != null)
            {
                for (int i = 0; i < categories.Count; i++)
                {
                    if (categories[i] == txtCategoy.Text)
                    {
                        index = i;
                        break;
                    }
                }
            }
            forms[index].Show();
        }

        private void txtCategoy_KeyUp(object sender, KeyEventArgs e)
        {
            lstbxCategories.Items.Clear();
            List<string> categories = HostManeger.SearchCategories(txtCategoy.Text);
            foreach (var category in categories)
            {
                lstbxCategories.Items.Add(category);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstbxCategories.Items.Clear();
            List<string> categories = HostManeger.AddCategories(txtCategoy.Text);
            foreach (var category in categories)
            {
                lstbxCategories.Items.Add(category);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstbxCategories.Items.Clear();
            List<string> categories = HostManeger.DeleteCategory(txtCategoy.Text);
            foreach (var category in categories)
            {
                lstbxCategories.Items.Add(category);
            }
            txtCategoy.Text = null;
        }

        private void lstbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoy_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
