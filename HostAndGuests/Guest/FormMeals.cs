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
    public partial class FormMeals : Form
    {
        public List<FormMeals> Forms;
        public int Position;
        public string NameGuest;
        public FormMeals(List<FormMeals> forms, int position, string categoryName, string guestName)
        {
            InitializeComponent();
            Forms = forms;
            Position = position;
            lblCategory.Text = categoryName;
            NameGuest = guestName;
        }


        private void FormMeals_Load(object sender, EventArgs e)
        {
            txtAddChoice.Visible = false;
            btnOkey.Visible = false;
            lblName.Text = NameGuest;
            dataGridView1.DataSource = GuestManeger.PrintGuestsMeals(lblCategory.Text, NameGuest);
            dataGridView2.DataSource = GuestManeger.PrintMyMeals(lblCategory.Text, NameGuest);
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

        private void btnOkey_Click(object sender, EventArgs e)
        {
            GuestManeger.AddMeals(lblCategory.Text, NameGuest, txtAddChoice.Text);
            dataGridView1.DataSource = GuestManeger.PrintGuestsMeals(lblCategory.Text, NameGuest);
            dataGridView2.DataSource = GuestManeger.PrintMyMeals(lblCategory.Text, NameGuest);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtAddChoice.Visible = true;
            btnOkey.Visible = true;
        }
    }
}
