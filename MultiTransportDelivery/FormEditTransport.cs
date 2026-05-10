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
    public partial class FormEditTransport : Form
    {
        ListViewItem oldTransport;
        public FormEditTransport(ListViewItem oldTransport)
        {
            InitializeComponent();
            this.oldTransport = oldTransport;
            textBoxName.Text = oldTransport.SubItems[0].Text;
            textBoxPrice.Text = oldTransport.SubItems[1].Text;
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxName.Text) && !string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                if (!DataTransport.isTransportDuplicate(textBoxName.Text, textBoxPrice.Text))
                {
                    if (DataTransport.editTransport(textBoxName.Text, textBoxPrice.Text, oldTransport))
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Такой транспорт уже существует!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Поля: Имя, Стоимость обязательно должны быть заполнены!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
