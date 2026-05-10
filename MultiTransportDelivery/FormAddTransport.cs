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
    public partial class FormAddTransport : Form
    {
        public FormAddTransport()
        {
            InitializeComponent();
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
            if (!string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                if (!DataTransport.isTransportDuplicate(textBoxName.Text, numericUpDownPrice.Value.ToString()))
                {
                    if (DataTransport.addTransport(textBoxName.Text, numericUpDownPrice.Value.ToString()))
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
