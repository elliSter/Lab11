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
    public partial class CustomerDetails : Form
    {
        
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {

            string strSQL = "SELECT * FROM Customers where CompanyName='" + Form1.company + "';";

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
    }
}
