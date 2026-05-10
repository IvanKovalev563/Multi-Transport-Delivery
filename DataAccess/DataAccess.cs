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
        public static void delClient(int id)
        {
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    using (var cmd = new MySqlCommand($"delete from client where (client_id={id})", conn))
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
        public static bool editClient(string Name, string Address, string PersAccount, string Phone, ListViewItem oldClient)
        {
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    using (var cmd = new MySqlCommand(
                        $"update client" +
                        $" set full_name = '{Name}', address = '{Address}', personal_account = '{PersAccount}', phone = '{Phone}'" +
                        $" where client_id={oldClient.SubItems[4].Text}", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка изменения данных в client: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static bool isClientDuplicate(string Name, string Address, string PersonalAccount, string Phone)
        {
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    using (var cmd = new MySqlCommand(@"SELECT COUNT(*) FROM client 
                           WHERE full_name = @fn AND address = @ad AND personal_account = @pa 
                           AND phone = @ph", conn))
                    {
                        cmd.Parameters.AddWithValue("@fn", Name);
                        cmd.Parameters.AddWithValue("@pa", PersonalAccount);
                        cmd.Parameters.AddWithValue("@ad", Address);
                        cmd.Parameters.AddWithValue("@ph", Phone);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при проверке дубликата клиента: {ex.Message}",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

    public static class DataTransport
    {
        public static List<ListViewItem> getTransport(string searchName)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    using (var cmd = new MySqlCommand($"select * from transport", conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["name"].ToString());
                                item.SubItems.Add(reader["price_per_km"].ToString());
                                item.SubItems.Add(reader["transport_id"].ToString());

                                items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка получения данных из transport: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return items;
        }
        public static bool addTransport(string Name, string Price)
        {
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    using (var cmd = new MySqlCommand($"insert into transport (name, price_per_km) values ('{Name}', '{Price}')", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления данных в transport: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static void delTransport(int id)
        {
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    using (var cmd = new MySqlCommand($"delete from transport where (transport_id={id})", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("Невозможно удалить транспорт: у него есть оформленные заказы.\nСначала удалите или переназначьте заказы этого клиента.",
                                "Удаление невозможно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления данных из transport: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool editTransport(string Name, string Price, ListViewItem oldTransport)
        {
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    using (var cmd = new MySqlCommand(
                        $"update client" +
                        $" set name = '{Name}', price_per_km = '{Price}'" +
                        $" where client_id={oldTransport.SubItems[2].Text}", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка изменения данных в transport: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static bool isTransportDuplicate(string Name, string Price)
        {
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    using (var cmd = new MySqlCommand(@"SELECT COUNT(*) FROM transport 
                           WHERE name = @n AND price_per_km = @p", conn))
                    {
                        cmd.Parameters.AddWithValue("@n", Name);
                        cmd.Parameters.AddWithValue("@p", Int32.Parse(Price));

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при проверке дубликата транспорта: {ex.Message}",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
