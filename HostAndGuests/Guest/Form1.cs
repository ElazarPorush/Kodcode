using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<FormMeals> forms = new List<FormMeals>();
            List<string> categories = GuestManeger.GetCategories();
            for (int i = 0; i < categories.Count; i++)
            {
                forms.Add(new FormMeals(forms, i, categories[i], txtInput.Text));
            }
            forms[0].Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> guests = GuestManeger.GetGuests();
            foreach (var guest in guests)
            {
                lstbxGuests.Items.Add(guest);
            }
        }

        private void lstbxGuests_DoubleClick(object sender, EventArgs e)
        {
            if (lstbxGuests.SelectedItem != null)
            {
                txtInput.Text = lstbxGuests.SelectedItem.ToString();
            }
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            lstbxGuests.Items.Clear();
            List<string> categories = GuestManeger.SearchGuests(txtInput.Text);
            foreach (var category in categories)
            {
                lstbxGuests.Items.Add(category);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstbxGuests.Items.Clear();
            List<string> categories = GuestManeger.AddGuests(txtInput.Text);
            foreach (var category in categories)
            {
                lstbxGuests.Items.Add(category);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstbxGuests.Items.Clear();
            List<string> categories = GuestManeger.DeleteGuest(txtInput.Text);
            foreach (var category in categories)
            {
                lstbxGuests.Items.Add(category);
            }
            txtInput.Text = null;
        }
    }
}
