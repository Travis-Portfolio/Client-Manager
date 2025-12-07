using Client_Manager.Repository;
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
                ClientRepository cr = new ClientRepository();
                cr.GetClients();

            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
