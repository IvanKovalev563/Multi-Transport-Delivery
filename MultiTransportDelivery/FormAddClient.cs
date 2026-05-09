using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace Order_Manager
{
    public partial class FormAddClient : Form
    {
        public FormAddClient()
        {
            InitializeComponent();
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
                    if (DataClient.addClient(textBoxName.Text, textBoxAddress.Text, textBoxPersAccount.Text, maskedTextBoxPhone.Text))
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
