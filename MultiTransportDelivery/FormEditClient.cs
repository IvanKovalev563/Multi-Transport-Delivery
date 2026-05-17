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
            loadBoxRegion();
            this.oldClient = oldClient;
            textBoxName.Text = oldClient.SubItems[0].Text;
            textBoxPersAccount.Text = oldClient.SubItems[2].Text;
            maskedTextBoxPhone.Text = oldClient.SubItems[3].Text;
            comboBoxRegion.SelectedValue = int.Parse(oldClient.SubItems[5].Text.ToString());
            loadBoxCity(int.Parse(oldClient.SubItems[5].Text.ToString()));
            comboBoxCity.SelectedValue = int.Parse(oldClient.SubItems[6].Text.ToString());
            loadBoxStreet(int.Parse(oldClient.SubItems[6].Text.ToString()));
            comboBoxStreet.SelectedValue = int.Parse(oldClient.SubItems[7].Text.ToString());
            textBoxHouse.Text = oldClient.SubItems[8].Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxPersAccount.Text) || textBoxPersAccount.Text.Length != 20 || maskedTextBoxPhone.Text.Length != 18 || comboBoxRegion.SelectedIndex < 0 || comboBoxCity.SelectedIndex < 0 || comboBoxStreet.SelectedIndex < 0 || string.IsNullOrWhiteSpace(textBoxHouse.Text))
            {
                MessageBox.Show("Поля: Имя, Регион, Город, Улица, Дом, Лицевой счёт и Номер телефона обязательны для заполнения!",
                                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int regionId = (int)comboBoxRegion.SelectedValue;
            int cityId = (int)comboBoxCity.SelectedValue;
            int streetId = (int)comboBoxStreet.SelectedValue;
            string house = textBoxHouse.Text;

            string name = textBoxName.Text;
            string persAccount = textBoxPersAccount.Text;
            string phone = maskedTextBoxPhone.Text;

            if (DataClient.isClientDuplicate(name, persAccount, phone, regionId, cityId, streetId, house))
            {
                MessageBox.Show("Клиент с такими данными уже существует!", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (DataClient.editClient(name, regionId, cityId, streetId, house, persAccount, phone, oldClient))
            {
                this.Close();
            }
        }

        private void loadBoxRegion()
        {
            List<ListViewItem> items = DataAddress.getRegions();
            comboBoxRegion.DropDownStyle = ComboBoxStyle.DropDownList;

            if (items.Count > 0)
            {
                var dict = new Dictionary<int, string>();

                foreach (ListViewItem item in items)
                {
                    int id = Convert.ToInt32(item.SubItems[1].Text);
                    string name = item.SubItems[0].Text;
                    dict.Add(id, name);
                }

                comboBoxRegion.DataSource = new BindingSource(dict, null);
                comboBoxRegion.DisplayMember = "Value";
                comboBoxRegion.ValueMember = "Key";
                comboBoxRegion.SelectedIndex = -1;
            }
        }

        private void loadBoxCity(int regionId)
        {
            List<ListViewItem> items = DataAddress.getCities(regionId);
            comboBoxCity.DropDownStyle = ComboBoxStyle.DropDownList;

            if (items.Count > 0)
            {
                var dict = new Dictionary<int, string>();

                foreach (ListViewItem item in items)
                {
                    int id = Convert.ToInt32(item.SubItems[1].Text);
                    string name = item.SubItems[0].Text;
                    dict.Add(id, name);
                }

                comboBoxCity.DataSource = new BindingSource(dict, null);
                comboBoxCity.DisplayMember = "Value";
                comboBoxCity.ValueMember = "Key";
                comboBoxCity.SelectedIndex = -1;
            }
        }

        private void loadBoxStreet(int cityId)
        {
            List<ListViewItem> items = DataAddress.getStreets(cityId);
            comboBoxStreet.DropDownStyle = ComboBoxStyle.DropDownList;

            if (items.Count > 0)
            {
                var dict = new Dictionary<int, string>();

                foreach (ListViewItem item in items)
                {
                    int id = Convert.ToInt32(item.SubItems[1].Text);
                    string name = item.SubItems[0].Text;
                    dict.Add(id, name);
                }

                comboBoxStreet.DataSource = new BindingSource(dict, null);
                comboBoxStreet.DisplayMember = "Value";
                comboBoxStreet.ValueMember = "Key";
                comboBoxStreet.SelectedIndex = -1;
            }
        }

        private void textBoxPersAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && e.KeyChar != '/' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRegion.SelectedValue is int regionId && regionId != -1)
            {
                loadBoxCity(regionId);
                comboBoxStreet.DataSource = null;
            }
            else
            {
                comboBoxStreet.DataSource = null;
                comboBoxCity.DataSource = null;
            }
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCity.SelectedValue is int cityId && cityId != -1)
            {
                loadBoxStreet(cityId);
            }
            else
            {
                comboBoxStreet.DataSource = null;
            }
        }
    }
}
