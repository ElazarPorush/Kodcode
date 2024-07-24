using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace CoffeeMachine
{
    public partial class Form1 : Form
    {
        //public bool flag = false;
        private DrinkesMenager drinkesMenager;
        public Form1()
        {
            InitializeComponent();
            drinkesMenager = new DrinkesMenager(MainProject.Main());      
        }

        public void PrintTable()
        {
            List<List<string>> allDrinkes = drinkesMenager.GetDrinkes();
            foreach (List<string> drink in allDrinkes)
            {
                dataGridView1.Rows.Add(drink.ToArray());
            }
        }

        public void DeleteText()
        {
            txtbxName.Text = "";
            cmbtxtShuger.Text = "0.5";
            cmbtxtCoffee.Text = "0.5";
            cmbtxtMilk.Text = "0.5";
            cmbtxtCackau.Text = "0.5";
            txtbxPrice.Text = "4";
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            double tmp = double.Parse(txtbxPrice.Text);
            tmp += 0.5;
            txtbxPrice.Text = tmp.ToString();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            double tmp = double.Parse(txtbxPrice.Text);
            if (tmp > 0)
            {
                tmp -= 0.5;
            }
            txtbxPrice.Text = tmp.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrintTable();
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> names = new List<string>() { txtbxName.Text, cmbtxtShuger.Text, cmbtxtCoffee.Text, cmbtxtMilk.Text, cmbtxtCackau.Text, txtbxPrice.Text };
            drinkesMenager.AddDrink(names);
            dataGridView1.Rows.Add(names.ToArray());    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            drinkesMenager.Save();
            DeleteText();
        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {
            
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(txtbxName.Text))
                    {
                        row.Selected = true;
                        DialogResult result = MessageBox.Show($"האם אתה רוצה לעדכן את המוצר {txtbxName.Text}?"
                            , "עדכון מוצר", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            txtbxName.Text = row.Cells[0].Value.ToString();
                            cmbtxtShuger.Text = row.Cells[1].Value.ToString();
                            cmbtxtCoffee.Text = row.Cells[2].Value.ToString();
                            cmbtxtMilk.Text = row.Cells[3].Value.ToString();
                            cmbtxtCackau.Text = row.Cells[4].Value.ToString();
                            txtbxPrice.Text = row.Cells[5].Value.ToString();
                            btnUpdate.Visible = true;
                            btnDelete.Visible = true;
                            btnSave.Visible = false;
                            btnAdd.Visible = false;
                        }
                        else
                        {
                            row.Selected = false;
                        }
                        break;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                row.Selected = true;
                DialogResult result = MessageBox.Show($"האם אתה רוצה לעדכן את המוצר {txtbxName.Text}?"
                    , "עדכון מוצר", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //flag = true;
                    txtbxName.Text = row.Cells[0].Value.ToString();
                    cmbtxtShuger.Text = row.Cells[1].Value.ToString();
                    cmbtxtCoffee.Text = row.Cells[2].Value.ToString();
                    cmbtxtMilk.Text = row.Cells[3].Value.ToString();
                    cmbtxtCackau.Text = row.Cells[4].Value.ToString();
                    txtbxPrice.Text = row.Cells[5].Value.ToString();
                    btnUpdate.Visible = true;
                    btnDelete.Visible = true;
                    btnSave.Visible = false;
                    btnAdd.Visible = false;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> names = new List<string>() { txtbxName.Text, cmbtxtShuger.Text, cmbtxtCoffee.Text, cmbtxtMilk.Text, cmbtxtCackau.Text, txtbxPrice.Text };
            drinkesMenager.UpdateDrink(names);
            dataGridView1.Rows.Clear();
            PrintTable();
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnSave.Visible = true;
            btnAdd.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"האם אתה בטוח שאתה רוצה למחוק את המוצר?"
                    , "מחיקת מוצר", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                drinkesMenager.Delete(txtbxName.Text);
                dataGridView1.Rows.Clear();
                PrintTable();
            }
            else
            {
                DeleteText();
            }
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnSave.Visible = true;
            btnAdd.Visible = true;
            
        }
    }
}
