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
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = connectString;
                connection.Open();
                populate_Form(connection);
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void populate_Form(MySqlConnection connection)
        {
            string sqlTest = "SELECT * FROM client_table";
            MySqlCommand cmdTest = new MySqlCommand(sqlTest, connection);

            MySqlDataReader reader = cmdTest.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show("Client " + reader["clientID"] + " " + reader["first_name"]);
            }

        }
    }
}
