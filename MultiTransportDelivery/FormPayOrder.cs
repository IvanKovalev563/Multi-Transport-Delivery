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
            label1.Text = $"Оплата заказа №{order.SubItems[10].Text}";
            numericUpDownPay.Maximum = decimal.Parse(order.SubItems[9].Text);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (numericUpDownPay.Value > 0)
            {
                if (DataPayments.addPayment(int.Parse(order.SubItems[10].Text), int.Parse(order.SubItems[11].Text), (float)numericUpDownPay.Value))
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Сумма оплаты не должна равняться нулю!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
