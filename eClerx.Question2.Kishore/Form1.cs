using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace eClerx.Question2.Kishore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboSortBy.Items.Add("Credit Limit: Low to High");
            ComboSortBy.Items.Add("Credit Limit: High to Low");
            ComboSortBy.Items.Add("Customer Name: A to Z");
            ComboSortBy.Items.Add("Customer Name: Z to A");
        }
        private SqlConnection con = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;
        private void BtnGetData_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HR"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Customer", con))
                {
                    ds = new DataSet();
                    adapter.Fill(ds, "Customer");
                    DataView dv = ds.Tables["Customer"].DefaultView; 
                    if (ComboSortBy.SelectedIndex == 0)
                    {
                        dv.RowFilter = "CreditLimit>=0 and CreditLimit<=90000 ";
                    }
                    else if (ComboSortBy.SelectedIndex == 1)
                    {
                        dv.RowFilter = "CreditLimit<=90000 and CreditLimit>=0 ";
                    }
                    else if (ComboSortBy.SelectedIndex == 2)
                    {
                        dv.RowFilter = "select * from Customer order by CustomerCity ASC";
                    }
                    else
                    {
                        dv.RowFilter = "select * from Customer order by CustomerCity DESC";
                    }
                }
            } 
        }
    }
}
