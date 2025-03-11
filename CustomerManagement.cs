using Microsoft.Data.SqlClient;
using System.Data;

namespace CustomersManagement
{
    public partial class CustomerManagement : Form
    {
        private string connectionstring = "Server=LENOVO;Database=CustomersManagement;Trusted_connection=true;TrustServerCertificate=true";
        private string query = "SELECT * FROM Customer";
        public CustomerManagement()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter(query, connectionstring);
                DataSet dataSet = new DataSet();
                sqlDA.Fill(dataSet, "Customer");
                dataGridView1.DataSource = dataSet.Tables["Customer"];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        //open add customer form 
        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer(this);
            addCustomer.ShowDialog();

        }
        //edit customer
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter(query, connectionstring);
                //a database
                DataSet dataSet = new DataSet();
                sqlDA.Fill(dataSet, "Customer");
                //update using datagridview
                DataView dw = dataSet.Tables["Customer"].DefaultView;
                dw.AllowEdit = true;
                dw[dataGridView1.CurrentRow.Index].BeginEdit();
                dw[dataGridView1.CurrentRow.Index]["CustomerNumber"] = dataGridView1.CurrentRow.Cells[1].Value;
                dw[dataGridView1.CurrentRow.Index]["LastName"] = dataGridView1.CurrentRow.Cells[2].Value;
                dw[dataGridView1.CurrentRow.Index]["FirstName"] = dataGridView1.CurrentRow.Cells[3].Value;
                dw[dataGridView1.CurrentRow.Index]["AreaCode"] = dataGridView1.CurrentRow.Cells[4].Value;
                dw[dataGridView1.CurrentRow.Index]["Address"] = dataGridView1.CurrentRow.Cells[5].Value;
                dw[dataGridView1.CurrentRow.Index]["Phone"] = dataGridView1.CurrentRow.Cells[6].Value;
                dw[dataGridView1.CurrentRow.Index].EndEdit();

                dataGridView1.DataSource = dw;

                SqlCommandBuilder sqlCB = new SqlCommandBuilder(sqlDA);
                sqlDA.Update(dataSet.Tables["Customer"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter(query, connectionstring);
                //a database
                DataSet dataSet = new DataSet();
                sqlDA.Fill(dataSet, "Customer");

                dataSet.Tables["Customer"].Rows[dataGridView1.CurrentRow.Index].Delete();
                SqlCommandBuilder sqlCB = new SqlCommandBuilder(sqlDA);
                sqlDA.Update(dataSet.Tables["Customer"]);
                dataGridView1.DataSource = dataSet.Tables["Customer"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
