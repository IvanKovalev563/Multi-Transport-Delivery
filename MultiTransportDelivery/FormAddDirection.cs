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
        public partial class FormAddDirection : Form
        {
            public FormAddDirection()
            {
                InitializeComponent();
            }
            private void buttonCancel_Click(object sender, EventArgs e)
            {
                this.Close();
            }
            private void buttonAccept_Click(object sender, EventArgs e)
            {
                if (!string.IsNullOrWhiteSpace(textBoxName.Text))
                {
                    if (!DataDirections.isDirectionDuplicate(textBoxName.Text))
                    {
                        if (DataDirections.addDirection(textBoxName.Text))
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Такое направление уже существует!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Поле: Направление обязательно должно быть заполнено!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
