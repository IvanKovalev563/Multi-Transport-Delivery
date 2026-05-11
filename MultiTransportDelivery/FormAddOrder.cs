using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiTransportDelivery
{
    public partial class FormAddOrder : Form
    {
        public FormAddOrder()
        {
            InitializeComponent();
            loadBoxClient();
            loadBoxTransport();
            loadBoxDirection();
            calculateCost(null, null);
        }

        private void loadBoxClient()
        {
            List<ListViewItem> items = DataClient.getClients();
            comboBoxClient.Items.Clear();
            comboBoxClient.DropDownStyle = ComboBoxStyle.DropDownList;

            if (items.Count > 0)
            {
                var dict = new Dictionary<int, string>();

                foreach (ListViewItem item in items)
                {
                    int id = Convert.ToInt32(item.SubItems[4].Text);
                    string name = item.SubItems[0].Text;
                    dict.Add(id, name);
                }

                comboBoxClient.DataSource = new BindingSource(dict, null);
                comboBoxClient.DisplayMember = "Value";
                comboBoxClient.ValueMember = "Key";

                comboBoxClient.SelectedIndex = -1;
            }
        }
        private void loadBoxTransport()
        {
            List<ListViewItem> items = DataTransport.getTransport(-1);
            comboBoxTransport.Items.Clear();
            comboBoxTransport.DropDownStyle = ComboBoxStyle.DropDownList;

            if (items.Count > 0)
            {
                var dict = new Dictionary<int, string>();

                foreach (ListViewItem item in items)
                {
                    int id = Convert.ToInt32(item.SubItems[2].Text);
                    string name = $"{item.SubItems[0].Text} ({item.SubItems[1].Text} руб./км*тонна)";
                    dict.Add(id, name);
                }

                comboBoxTransport.DataSource = new BindingSource(dict, null);
                comboBoxTransport.DisplayMember = "Value";
                comboBoxTransport.ValueMember = "Key";

                comboBoxTransport.SelectedIndex = -1;
            }
        }
        private void loadBoxDirection()
        {
            List<ListViewItem> items = DataDirections.getDirections();
            comboBoxDirection.Items.Clear();
            comboBoxDirection.DropDownStyle = ComboBoxStyle.DropDownList;

            if (items.Count > 0)
            {
                var dict = new Dictionary<int, string>();

                foreach (ListViewItem item in items)
                {
                    int id = Convert.ToInt32(item.SubItems[1].Text);
                    string name = item.SubItems[0].Text;
                    dict.Add(id, name);
                }

                comboBoxDirection.DataSource = new BindingSource(dict, null);
                comboBoxDirection.DisplayMember = "Value";
                comboBoxDirection.ValueMember = "Key";

                comboBoxDirection.SelectedIndex = -1;
            }
        }

        private void calculateCost(object sender, EventArgs e)
        {
            if (comboBoxClient.Text.Length > 0 && comboBoxTransport.Text.Length > 0 && comboBoxDirection.Text.Length > 0 && numericUpDownDistance.Value > 0 && numericUpDownWeight.Value > 0)
            {
                float costPerKm = float.Parse(DataTransport.getTransport(int.Parse(comboBoxTransport.SelectedValue.ToString()))[0].SubItems[1].Text);
                float distance = float.Parse(numericUpDownDistance.Value.ToString());
                float weight = float.Parse(numericUpDownWeight.Value.ToString()) / 1000;
                float total = (float)Math.Round(costPerKm * distance * weight, 2);
                labelCost.Text = $"Итого: {total.ToString()} руб.";
            }
            else
            {
                labelCost.Text = "";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.Text.Length > 0 && comboBoxTransport.Text.Length > 0 && comboBoxDirection.Text.Length > 0 && numericUpDownDistance.Value > 0 && numericUpDownWeight.Value > 0)
            {
                float costPerKm = float.Parse(DataTransport.getTransport(int.Parse(comboBoxTransport.SelectedValue.ToString()))[0].SubItems[1].Text);
                float distance = float.Parse(numericUpDownDistance.Value.ToString());
                float weight = float.Parse(numericUpDownWeight.Value.ToString()) / 1000;
                float total = (float)Math.Round(costPerKm * distance * weight, 2);

                DataOrders.addOrder((int)comboBoxClient.SelectedValue, (int)comboBoxTransport.SelectedValue, (int)comboBoxDirection.SelectedValue, (float)numericUpDownWeight.Value, (float)numericUpDownDistance.Value, total);
                this.Close();
            }
            else
            {
                MessageBox.Show("Поля: Клиент, Транспорт, Направление, Расстояние, Вес обязательно должны быть заполнены!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
