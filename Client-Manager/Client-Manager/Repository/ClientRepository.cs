using Client_Manager.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Manager.Repository
{
    public class ClientRepository
    {
        private readonly string connectString = ""; // connection string data removed for security purposes

        public List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();

            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = connectString;
                connection.Open();

                string sqlTest = "SELECT * FROM client_table ORDER BY clientID DESC";
                MySqlCommand cmdTest = new MySqlCommand(sqlTest, connection);

                MySqlDataReader reader = cmdTest.ExecuteReader();

                while (reader.Read())
                {
                    Client client = new Client();
                    client.Id = (int) reader["clientID"];
                    client.firstName = (string) reader["first_name"];
                    client.lastName = (string) reader["last_name"];
                    client.email = (string)reader["email"];
                    client.phoneNumber = (string)reader["phone_number"];
                    client.address = (string)reader["address"];

                    clients.Add(client);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return clients;
        }
    }
}
