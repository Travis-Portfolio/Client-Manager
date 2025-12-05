using MySql.Data.MySqlClient;

namespace Client_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectString = ""; // connection string data removed for security purposes
                // put the connection logic below into the ClientRepository class
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = connectString;
                connection.Open();

            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
