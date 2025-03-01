namespace CustomersManagement
{
    public partial class CustomerManagement : Form
    {
        string connectionstring = "Server=LENOVO;Database=CustomersManagement;Trusted_connection=true;";
        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();

        }
    }
}
