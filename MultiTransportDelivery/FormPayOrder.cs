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
    public partial class FormPayOrder : Form
    {
        ListViewItem order;
        public FormPayOrder(ListViewItem order)
        {
            InitializeComponent();
            this.order = order;
            loadBoxCurrency();
            comboBoxCurrency.SelectedValue = int.Parse(order.SubItems[12].Text);
            label1.Text = $"Оплата заказа №{order.SubItems[10].Text}";
        }

        private void loadBoxCurrency()
        {
            List<ListViewItem> items = DataCurrency.getCurrencies();
            comboBoxCurrency.Items.Clear();
            comboBoxCurrency.DropDownStyle = ComboBoxStyle.DropDownList;

            if (items.Count > 0)
            {
                var dict = new Dictionary<int, string>();

                foreach (ListViewItem item in items)
                {
                    int id = Convert.ToInt32(item.SubItems[1].Text);
                    string display = item.SubItems[0].Text;
                    dict.Add(id, display);
                }

                comboBoxCurrency.DataSource = new BindingSource(dict, null);
                comboBoxCurrency.DisplayMember = "Value";
                comboBoxCurrency.ValueMember = "Key";
                int rubId = -1;
                foreach (var pair in dict)
                {
                    if (pair.Value.StartsWith("RUB"))
                    {
                        rubId = pair.Key;
                        break;
                    }
                }
                if (rubId > 0) comboBoxCurrency.SelectedValue = rubId;
                else comboBoxCurrency.SelectedIndex = 0;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (numericUpDownPay.Value > 0)
            {
                float costVal = (float)numericUpDownPay.Value;
                float rate = 1;
                if (comboBoxCurrency.SelectedItem is KeyValuePair<int, string> kvp)
                {
                    int currencyId = kvp.Key;
                    rate = DataCurrency.GetRate(currencyId);
                }
                float total = (float)Math.Round(costVal * rate, 4);
                if (DataPayments.addPayment(int.Parse(order.SubItems[10].Text), int.Parse(order.SubItems[11].Text), total))
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Сумма оплаты не должна равняться нулю!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            float costRub = float.Parse(order.SubItems[9].Text);
            float rate = 1;
            if (comboBoxCurrency.SelectedItem is KeyValuePair<int, string> kvp)
            {
                int currencyId = kvp.Key;
                rate = DataCurrency.GetRate(currencyId);
            }
            float total = (float)Math.Round(costRub / rate, 4);
            numericUpDownPay.Maximum = (decimal)total;
        }
    }
}
