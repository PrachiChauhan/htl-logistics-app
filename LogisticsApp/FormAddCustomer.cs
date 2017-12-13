using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogisticsApp;

namespace LogisticsApp
{
    public partial class FormAddCustomer : Form
    {
        Logistics_db localdb;
        public FormAddCustomer(Logistics_db db)
        {
            InitializeComponent();
            localdb = db;
        }

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void txtAdd_Click(object sender, EventArgs e)
        {
                String[] dataValue = new String[5];
                dataValue[0] = txtid.Text;
                dataValue[1] = txtName.Text;
                dataValue[2] = txtAddress.Text;
                dataValue[3] = txtPhone.Text;
                dataValue[4] = txtPercent.Text;

                int x=localdb.addCustomer(dataValue);
                if (x > 0)
                {
                    MessageBox.Show("Insert successful");
                }
                else
                {
                    MessageBox.Show("Insert unsuccessful");
                }
        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMain mainForm = new formMain();
            mainForm.ShowDialog();
        }
    }
}
