using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class Connection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;



        public Connection()
        {
            Init();
        }

        private void Init()
        {
            server = "localhost";
            database = "phonebook";
            uid = "root";
            password = "Zhekbcn666!";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public void Update_DeleteContact(string query)
        {
            if (this.Open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                this.Close();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public void Select(List<Contacts> lstContacts, string query)
        {
            if (this.Open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lstContacts.Add(new Contacts()
                    {
                        id = Convert.ToInt32(reader["id"]),
                        name = reader["name"].ToString(),
                        lastName = reader["lastName"].ToString(),
                        phone = Convert.ToInt32(reader["phone"]),
                        address = reader["address"].ToString(),
                        email = reader["email"].ToString(),
                    });
                }

                reader.Close();

                this.Close();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public long InsertNewContact(string query, List<Contacts> lstContacts)
        {
            if (this.Open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lstContacts.Add(new Contacts()
                    {
                        id = Convert.ToInt32(reader["id"]),
                        name = reader["name"].ToString(),
                        lastName = reader["lastName"].ToString(),
                        phone = Convert.ToInt32(reader["phone"]),
                        address = reader["address"].ToString(),
                        email = reader["email"].ToString(),
                    });
                }

                this.Close();

                return cmd.LastInsertedId;
            }
            else
            {
                Environment.Exit(0);
                return 0;
            }
        }

        public bool Open()
        {
            try
            {
                connection.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Close()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
