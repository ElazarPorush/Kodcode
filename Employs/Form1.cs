using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employs
{
    public partial class Form1 : Form
    {
        public int index = 1;
        public int poynter = 0;
        public Employ[] employsArr = new Employ[20];
        public Form1()
        {
            InitializeComponent();
        }
        private string GetStatus()
        {
            if (rdbtnSingle.Checked == true) {
                return rdbtnSingle.Text;
            }
            else if (rdbtnMarried.Checked == true)
            {
                return rdbtnMarried.Text;
            }
            else if (rdbtnDevorse.Checked == true)
            {
                return rdbtnDevorse.Text;
            }
            else if (rdbtnWidowed.Checked == true)
            {
                return rdbtnWidowed.Text;
            }
            else
            {
                return "No status";
            }
        }
        private string GetIsMale()
        {
            if (rdbtnMale.Checked == true) {
                return rdbtnMale.Text;
            }
            else if (rdbtnFemale.Checked == true)
            {
                return rdbtnFemale.Text;
            }
            else
            {
                return "No jender";
            }
        }
        public void Append()
        {
            if (poynter < employsArr.Length)
            {
                employsArr[poynter] = new Employ(int.Parse(txtCode.Text), int.Parse(txtId.Text), txtFirstName.Text, txtLastName.Text, DateTime.Parse(dtmBirthday.Text), GetIsMale(), GetStatus(), int.Parse(txtCelPhone.Text), int.Parse(txtPhone.Text), txtStreet.Text, int.Parse(txtNumber.Text), txtCity.Text);
            }
            else
            {
                Employ[] tmp = new Employ[employsArr.Length + 1];
                for (int i = 0; i < employsArr.Length; i++)
                {
                    tmp[i] = employsArr[i];
                }
                employsArr = tmp;
                employsArr[poynter] = new Employ(int.Parse(txtCode.Text), int.Parse(txtId.Text), txtFirstName.Text, txtLastName.Text, DateTime.Parse(dtmBirthday.Text), GetIsMale(), GetStatus(), int.Parse(txtCelPhone.Text), int.Parse(txtPhone.Text), txtStreet.Text, int.Parse(txtNumber.Text), txtCity.Text);
                //


            }
            txtAge.Text = employsArr[poynter].Age.ToString();
            poynter++;
        }
        private void SetIsMale(string isMale)
        {
            if (rdbtnMale.Text == isMale) {
                rdbtnMale.Checked = true;
            }
            else
            {
                rdbtnFemale.Checked = true;
            }
        }
        private void SetStatus(string status) {
            if (rdbtnSingle.Text == status)
            {
                rdbtnSingle.Checked = true;
            }
            else if (rdbtnMarried.Text == status) { 
                rdbtnMarried.Checked = true;
            }
            else if (rdbtnDevorse.Text == status)
            {
                rdbtnDevorse.Checked = true;
            }
            else
            {
                rdbtnWidowed.Checked = true;
            }
        }
        private void print(int location)
        {
            if (location >= 0)
            {
                Employ tmp = employsArr[location];
                if (tmp != null)
                {
                    txtCode.Text = tmp.Code.ToString();
                    txtId.Text = tmp.Id.ToString();
                    txtFirstName.Text = tmp.FirstName;
                    txtLastName.Text = tmp.LastName;
                    dtmBirthday.Text = tmp.BirthDay.ToString();
                    SetIsMale(tmp.IsMale);
                    SetStatus(tmp.Status);
                    txtCelPhone.Text = tmp.CelPhone.ToString();
                    txtPhone.Text = tmp.Phone.ToString();
                    txtStreet.Text = tmp.Street;
                    txtNumber.Text = tmp.Number.ToString();
                    txtCity.Text = tmp.City;
                }
                else {
                    index--;
                }
            }
            else
            {
                index++;
            }
        }



        private void btnAddEmploy_Click(object sender, EventArgs e)
        {
            Append();
            foreach (var item in employsArr)
            {
                if (item != null)
                {
                    Console.WriteLine(item.FullName);
                }
            }
            index++;
            txtCode.Text = index.ToString();

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            //txtCode.Text = index.ToString();
        }
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(System.Windows.Forms.TextBox))

                {
                    item.Text = null;
                }
                //else if (item.GetType() == typeof(System.Windows.Forms.Panel))
                //{
                //    foreach (Control i in this.Controls)
                //    {
                //        i.Checked = false;
                //    }
                //}

            }
            dtmBirthday.Value = DateTime.Today;
            txtCode.Text = index.ToString();
            Console.WriteLine(txtCode.GetType());
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            index--;
            print(index - 1);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            index++;
            print(index - 1);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            employsArr[index - 1] = null;
            for (int i = index; i < employsArr.Length - 1; i++) { 
                employsArr[i].Code = employsArr[i].Code - 1;
            }
            index--;
            print(index - 1);
        }

        private void txtSearchByCode_TextChanged(object sender, EventArgs e)
        {
            print(int.Parse(txtSearchByCode.Text) - 1);
            index = int.Parse(txtSearchByCode.Text);
        }

        private void txtSearchById_TextChanged(object sender, EventArgs e)
        {
            print(int.Parse(txtSearchById.Text) - 1);
            index = int.Parse(txtSearchById.Text);
        }
    }
}