using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeClock
{
    public partial class frmLearning : Form
    {
        public frmLearning()
        {
            InitializeComponent();
        }

        private void frmLearning_Load(object sender, EventArgs e)
        {
            string sql = "select * from Employ";
            SqlDataReader reader = DBConection.RunSQLAllResult(sql);
            while (reader.Read())
            {
                int code = reader.GetInt32(0);
                string fullName =  reader.GetString(1);
                string id = reader.GetString(2);
                MessageBox.Show($"Code: {code}, Id: {id}, Full Name: {fullName}");
            }
        }
    }
}
