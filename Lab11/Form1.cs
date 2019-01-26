using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Lab11
{
    public partial class Form1 : Form
    {
        public static string company,company1="WILMK";
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSetOrdersD.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.northwindDataSetOrdersD.Order_Details);
            // TODO: This line of code loads data into the 'northwindDataSetOrders.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.northwindDataSetOrders.Orders);
            // TODO: This line of code loads data into the 'northwindDataSetCustomersAllData.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this.northwindDataSetCustomersAllData.Customers);
            // TODO: This line of code loads data into the 'northwindDataSetCustomers.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwindDataSetCustomers.Customers);
            
            
                string strSQL = "SELECT * FROM Customers";
                string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Northwind.mdb;Persist Security Info=True";
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                       
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                     
                        if (i%3 ==0)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }else if(i%3==1)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        }else if (i%3==2)
                        {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                    }
                    
                    }
                }
                connection.Close();
            


        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            company= dataGridView1.Rows[0].Cells[e.ColumnIndex].FormattedValue.ToString();
            
            CustomerDetails customerDetailsForm = new CustomerDetails();
            customerDetailsForm.Show();

            

            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            company1 = dataGridView1.Rows[0].Cells[e.ColumnIndex].FormattedValue.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            ////string companyName= "SELECT * FROM Customers where CustomerID='" + company1 + "';";
            //string strSQL = "SELECT * FROM Orders where CustomerID='" + company1 + "';";


            string strSQL1 = "SELECT * FROM Customers where CompanyName='" + company1 + "';";

            try
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(strSQL1, Properties.Settings.Default.NorthwindConnectionString))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView2.DataSource = dt;

                    string data = string.Empty;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dataGridView2.Visible = true;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.Height = 30;
            }

        }

        

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            string countryFilter =toolStripTextBox1.Text;

            string strSQL = "SELECT * FROM Customers where Country = '" + countryFilter + "'; ";
            
            

            try
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(strSQL, Properties.Settings.Default.NorthwindConnectionString))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    string data = string.Empty;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
