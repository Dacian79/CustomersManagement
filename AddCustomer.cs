using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomersManagement
{
    public partial class AddCustomer : Form
    {
        private CustomerManagement _mainForm;
        public AddCustomer(CustomerManagement mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;// de ce?
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Server=LENOVO;Database=CustomersManagement;Trusted_connection=true;TrustServerCertificate=true";
            string query = "select * from Customer";
            SqlDataAdapter sqlDA = new SqlDataAdapter(query, connectionstring);
            DataSet dataSet = new DataSet();

            sqlDA.Fill(dataSet, "Customer");

            DataRow row = dataSet.Tables["Customer"].NewRow();
            row["CustomerNumber"] = int.Parse(textBox6.Text);
            row["LastName"] = textBox1.Text;
            row["FirstName"] = textBox2.Text;
            row["AreaCode"] = textBox3.Text;
            row["Address"] = textBox4.Text;
            row["Phone"] = textBox5.Text;

            dataSet.Tables["Customer"].Rows.Add(row);

            SqlCommandBuilder sqlCB = new SqlCommandBuilder(sqlDA);
            sqlDA.Update(dataSet.Tables["Customer"]);

            _mainForm.RefreshGrid();
            
            this.Close();

        }
    }
}
