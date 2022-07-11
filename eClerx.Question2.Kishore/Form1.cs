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
        private SqlCommand cmd = null;
        private DataSet ds = null;
        private void BtnGetData_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HR"].ConnectionString))
            {
                using (cmd = new SqlCommand("Select * from Customer where City=@CustomerCity", con)) //take Hyderabad City and check all Validation
                {
                    cmd.Parameters.AddWithValue("@CustomerCity", TxtCustomerCity.Text);
                    adapter = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    adapter.Fill(ds, "Customer");
                    DataView dv = ds.Tables["Customer"].DefaultView; 
                    if (ComboSortBy.SelectedIndex == 0)
                    {
                        dv.sort = "CreditLimit ASC";
                        //dv.RowFilter = "CreditLimit>=0 and CreditLimit<=90000";
                    }
                    else if (ComboSortBy.SelectedIndex == 1)
                    {
                        dv.sort = "CreditLimit DESC";
                        //dv.RowFilter = "CreditLimit<=90000 and CreditLimit>=0 ";
                    }
                    else if (ComboSortBy.SelectedIndex == 2)
                    {
                        dv.sort = "CustomerName ASC";
                        //dv.RowFilter = "select * from Customer order by CustomerName ASC";
                    }
                    else
                    {
                        dv.sort = "CustomerName DESC";
                        //dv.RowFilter = "select * from Customer order by City DESC";
                    }
                     GridCustomer.DataSource = dv;
                }
            } 
        }
    }
}
