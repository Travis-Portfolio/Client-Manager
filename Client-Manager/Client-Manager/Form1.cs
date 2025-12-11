using Client_Manager.Repository;
using MySql.Data.MySqlClient;
using System.Data;

namespace Client_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillTable();
        }

        private void FillTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Email");
            table.Columns.Add("Phone");
            table.Columns.Add("Address");

            var repository = new ClientRepository();
            var clients = repository.GetClients();

            foreach(var client in clients)
            {
                var row = table.NewRow();

                row["ID"] = client.Id;
                row["Name"] = client.firstName + " " + client.lastName;
                row["Email"] = client.email;
                row["Phone"] = client.phoneNumber;
                row["Address"] = client.address;

                table.Rows.Add(row);
            }

            this.clientsTable.DataSource = table;
        }
    }
}
