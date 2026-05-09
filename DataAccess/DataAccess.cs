using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DataAccess
{
    public static class DatabaseAccess
    {
        public static string DB_connection = "server=localhost;user=root;password=root;database=multi_transport_delivery";
        public static MySqlConnection connectDB()
        {
            var conn = new MySqlConnection(DB_connection);
            conn.Open();
            return conn;
        }
    }

    public static class DataClient
    {
        public static List<ListViewItem> getClients(string searchName)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    using (var cmd = new MySqlCommand($"select * from client where full_name like '{searchName}%'", conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["full_name"].ToString());
                                item.SubItems.Add(reader["address"].ToString());
                                item.SubItems.Add(reader["personal_account"].ToString());
                                item.SubItems.Add(reader["phone"].ToString());
                                item.SubItems.Add(reader["client_id"].ToString());

                                items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка получения данных из client: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return items;
        }
        public static bool addClient(string Name, string Address, string PersonalAccount, string Phone)
        {
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    using (var cmd = new MySqlCommand($"insert into client (full_name, address, personal_account, phone) values ('{Name}', '{Address}', '{PersonalAccount}', '{Phone}')", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления данных в client: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static void delClient(string LName, string FName, string Surname, string Phone, string Email)
        {
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    using (var cmd = new MySqlCommand($"delete from client where (first_name like '{FName}' and last_name like '{LName}' and surname like '{Surname}' and phone like '{Phone}' and email like'{Email}')", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("Невозможно удалить клиента: у него есть оформленные заказы.\nСначала удалите или переназначьте заказы этого клиента.",
                                "Удаление невозможно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления данных из client: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
