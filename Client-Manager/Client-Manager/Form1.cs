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
            ReadClient();
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
        private void ReadClient()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Phone");
            dataTable.Columns.Add("Address");

            var repo = new ClientRepository();
            var clients = repo.GetClients();

            foreach (var client in clients)
            {
                var row = dataTable.NewRow();

                row["ID"] = client.Id;
                row["Name"] = client.firstName + " " + client.lastName;
                row["Email"] = client.email;
                row["Phone"] = client.phoneNumber;
                row["Address"] = client.address;

                dataTable.Rows.Add(row);
                
            }


        }
    }
}
