using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System.Windows.Forms;
using static Mysqlx.Crud.Order.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public static List<ListViewItem> getClients()
        {
            List<ListViewItem> items = new List<ListViewItem>();
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    using (var cmd = new MySqlCommand($"select * from client", conn))
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
        public static List<ListViewItem> getTransport(int id)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    string sql = "select * from transport";
                    if (id > -1) sql += $" where transport_id = {id}";
                    using (var cmd = new MySqlCommand(sql, conn))
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
                    using (var cmd = new MySqlCommand($"insert into transport (name, price_per_km) values ('{Name}', {Price})", conn))
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
                MessageBox.Show("Невозможно удалить транспорт: с ним есть оформленные заказы.",
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
                        $"update transport" +
                        $" set name = '{Name}', price_per_km = {Price}" +
                        $" where transport_id={oldTransport.SubItems[2].Text}", conn))
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
        public static List<ListViewItem> getNeededTransport()
        {
            List<ListViewItem> items = new List<ListViewItem>();
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    string sql = "select name, count(order_id) as count from transport, `order`" +
                        " where transport.transport_id = order.transport_id and status not like 'Доставлен'" +
                        " group by name";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["name"].ToString());
                                item.SubItems.Add(reader["count"].ToString());

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
    }

    public static class DataDirections
    {
        public static List<ListViewItem> getDirections()
        {
            List<ListViewItem> items = new List<ListViewItem>();
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    using (var cmd = new MySqlCommand($"select * from direction", conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["name"].ToString());
                                item.SubItems.Add(reader["direction_id"].ToString());

                                items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка получения данных из direction: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return items;
        }
        public static bool addDirection(string Name)
        {
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    using (var cmd = new MySqlCommand($"insert into direction (name) values ('{Name}')", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления данных в direction: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static void delDirection(int id)
        {
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    using (var cmd = new MySqlCommand($"delete from direction where (direction_id={id})", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("Невозможно удалить направление: с ним есть оформленные заказы.",
                                "Удаление невозможно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления данных из direction: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool editDirection(string Name, ListViewItem oldDirection)
        {
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    using (var cmd = new MySqlCommand(
                        $"update direction" +
                        $" set name = '{Name}'" +
                        $" where direction_id={oldDirection.SubItems[1].Text}", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка изменения данных в direction: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static bool isDirectionDuplicate(string Name)
        {
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    using (var cmd = new MySqlCommand(@"SELECT COUNT(*) FROM direction
                           WHERE name = @n", conn))
                    {
                        cmd.Parameters.AddWithValue("@n", Name);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при проверке дубликата направления: {ex.Message}",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

    public static class DataOrders
    {
        public static List<ListViewItem> getOrders(int clientID, DateTime dateSearch, int directionSearch)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    string sql = @"
                    SELECT o.order_id, o.client_id, o.order_date, o.cargo_weight, o.distance, o.cost, o.status,
                           c.full_name, c.phone,
                           t.name AS transport, d.name AS direction,
                           COALESCE(paid.total_paid, 0) AS paid_amount,
                           o.cost - COALESCE(paid.total_paid, 0) AS debt
                    FROM `order` o
                    LEFT JOIN client c ON o.client_id = c.client_id
                    LEFT JOIN transport t ON o.transport_id = t.transport_id
                    LEFT JOIN direction d ON o.direction_id = d.direction_id
                    LEFT JOIN (
                        SELECT order_id, SUM(amount) AS total_paid
                        FROM payment
                        WHERE order_id IS NOT NULL
                        GROUP BY order_id
                    ) paid ON o.order_id = paid.order_id
                    WHERE (@clientId = -1 OR o.client_id = @clientId)";

                    if (dateSearch != DateTime.MinValue)
                    {
                        sql += " AND o.order_date >= @dateFrom AND o.order_date < @dateTo";
                    }

                    if (directionSearch != -1) sql += $" AND d.direction_id = {directionSearch}";

                    sql += " ORDER BY o.order_date DESC";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@clientId", clientID);
                        if (dateSearch != DateTime.MinValue)
                        {
                            cmd.Parameters.AddWithValue("@dateFrom", dateSearch.Date);
                            cmd.Parameters.AddWithValue("@dateTo", dateSearch.Date.AddDays(1));
                        }
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["full_name"].ToString()); //0
                                item.SubItems.Add(reader["transport"].ToString()); //1
                                item.SubItems.Add(reader["direction"].ToString()); //2
                                item.SubItems.Add(reader["distance"].ToString()); //3
                                item.SubItems.Add(reader["order_date"].ToString()); //4
                                item.SubItems.Add(reader["cargo_weight"].ToString()); //5
                                item.SubItems.Add(reader["cost"].ToString()); //6
                                item.SubItems.Add(Convert.ToDecimal(reader["paid_amount"]).ToString("F2")); //7
                                item.SubItems.Add(reader["status"].ToString()); //8
                                item.SubItems.Add(Convert.ToDecimal(reader["debt"]).ToString("F2")); //9
                                item.SubItems.Add(reader["order_id"].ToString()); //10
                                item.SubItems.Add(reader["client_id"].ToString()); //11

                                items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка получения заказов: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return items;
        }
        public static bool addOrder(int clientId, int transportId, int directionId, float weight, float distance, float cost, string status = "Новый")
        {
            DateTime orderDate = DateTime.Now;
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    string sql = @"INSERT INTO `order` 
                (client_id, transport_id, direction_id, order_date, 
                 cargo_weight, distance, cost, status)
                VALUES (@clientId, @transportId, @directionId, @orderDate,
                        @weight, @distance, @cost, @status)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@clientId", clientId);
                        cmd.Parameters.AddWithValue("@transportId", transportId);
                        cmd.Parameters.AddWithValue("@directionId", directionId);
                        cmd.Parameters.AddWithValue("@orderDate", orderDate);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@distance", distance);
                        cmd.Parameters.AddWithValue("@cost", cost);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления заказа: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static void delOrder(int id)
        {
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    using (var cmd = new MySqlCommand($"delete from `order` where order_id={id}", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("Невозможно удалить заказ: на него есть платежи.",
                                "Удаление невозможно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления данных из Order: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool editOrder(int clientId, int transportId, int directionId, float weight, float distance, float cost, string status, ListViewItem oldOrder)
        {
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    string sql = @"UPDATE `order` SET 
                                client_id = @clientId,
                                transport_id = @transportId,
                                direction_id = @directionId,
                                cargo_weight = @weight,
                                distance = @distance,
                                cost = @cost,
                                status = @status
                                WHERE order_id = @orderId";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@clientId", clientId);
                        cmd.Parameters.AddWithValue("@transportId", transportId);
                        cmd.Parameters.AddWithValue("@directionId", directionId);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@distance", distance);
                        cmd.Parameters.AddWithValue("@cost", cost);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@orderId", oldOrder.SubItems[10].Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка изменения заказа: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static int getOrdersCount(bool isAcitve)
        {
            int count = 0;
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    string sql = $"SELECT count(order_id) as count from `order`";
                    if (isAcitve) sql += " where status not like 'Доставлен'";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                count = int.Parse(reader["count"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка получения информации о данных из Order: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return count;
        }
    }

    public static class DataPayments
    {
        public static List<ListViewItem> getDebtors()
        {
            List<ListViewItem> items = new List<ListViewItem>();
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    string sql = @"SELECT 
                            c.client_id,
                            c.full_name,
                            COALESCE(SUM(o.cost), 0) - COALESCE(SUM(p.amount), 0) AS debt
                          FROM client c
                          LEFT JOIN `order` o 
                            ON c.client_id = o.client_id AND o.status = 'Доставлен'
                          LEFT JOIN payment p 
                            ON c.client_id = p.client_id
                          GROUP BY c.client_id, c.full_name
                          HAVING debt > 0
                          ORDER BY debt DESC";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["full_name"].ToString());
                                item.SubItems.Add(Convert.ToDecimal(reader["debt"]).ToString("F2"));
                                item.SubItems.Add(reader["client_id"].ToString());

                                items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка получения должников: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return items;
        }
        public static bool addPayment(int orderId, int clientId, float amount)
        {
            DateTime date = DateTime.Now;
            try
            {
                using (var conn = DatabaseAccess.connectDB())
                {
                    string sql = @"insert into payment (client_id, order_id, amount, payment_date)
                                    values (@clientId, @orderId, @amount, @date)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@clientId", clientId);
                        cmd.Parameters.AddWithValue("@orderId", orderId);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления оплаты: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
