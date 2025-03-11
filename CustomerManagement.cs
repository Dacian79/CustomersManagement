using Microsoft.Data.SqlClient;
using System.Data;

namespace CustomersManagement
{
    public partial class CustomerManagement : Form
    {
        string connectionstring = "Server=LENOVO;Database=CustomersManagement;Trusted_connection=true;TrustServerCertificate=true";
        public CustomerManagement()
        {
            InitializeComponent();
        }

        public void RefreshGrid()
        {

            string query = "select * from Customer";
            SqlDataAdapter sqlDA = new SqlDataAdapter(query, connectionstring);
            DataSet dataSet = new DataSet();

            sqlDA.Fill(dataSet, "Customer");

            dataGridView1.DataSource = dataSet.Tables["Customer"];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "select * from Customer";
            SqlDataAdapter sqlDA = new SqlDataAdapter(query, connectionstring);
            DataSet dataSet = new DataSet();

            sqlDA.Fill(dataSet, "Customer");

            dataGridView1.DataSource = dataSet.Tables["Customer"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer(this); // de ce?
            addCustomer.ShowDialog();
            
        }
    }
}
