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
    public partial class FormEditClient : Form
    {
        ListViewItem oldClient;
        public FormEditClient(ListViewItem oldClient)
        {
            InitializeComponent();
            this.oldClient = oldClient;
            textBoxName.Text = oldClient.SubItems[0].Text;
            textBoxAddress.Text = oldClient.SubItems[1].Text;
            textBoxPersAccount.Text = oldClient.SubItems[2].Text;
            maskedTextBoxPhone.Text = oldClient.SubItems[3].Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPhone.Text.Length == 18 && !string.IsNullOrWhiteSpace(textBoxName.Text) && !string.IsNullOrWhiteSpace(textBoxAddress.Text) && !string.IsNullOrWhiteSpace(textBoxPersAccount.Text))
            {
                if (!DataClient.isClientDuplicate(textBoxName.Text, textBoxAddress.Text, textBoxPersAccount.Text, maskedTextBoxPhone.Text))
                {
                    if (DataClient.editClient(textBoxName.Text, textBoxAddress.Text, textBoxPersAccount.Text, maskedTextBoxPhone.Text, oldClient))
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Такой клиент уже существует!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Поля: Имя, Адрес, Лицевой счет, Номер телефона обязательно должны быть заполнены!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
