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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MultiTransportDelivery
{
    public partial class FormAddOrder : Form
    {
        private int _cityFromId = -1;
        private int _cityToId = -1;
        float _calculatedDistance = 0;
        private bool _updatingCities = false;

        public FormAddOrder()
        {
            InitializeComponent();
            loadBoxClient();
            loadBoxTransport();
            loadBoxCurrency();
            loadBoxRegionFromTo();
            comboBoxRegionFrom_SelectedIndexChanged(null, null);
            comboBoxRegionTo_SelectedIndexChanged(null, null);
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
        private void loadBoxRegionFromTo()
        {
            List<ListViewItem> items = DataAddress.getRegions();
            comboBoxRegionFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRegionTo.DropDownStyle = ComboBoxStyle.DropDownList;

            if (items.Count > 0)
            {
                var dict = new Dictionary<int, string>();

                foreach (ListViewItem item in items)
                {
                    int id = Convert.ToInt32(item.SubItems[1].Text);
                    string name = item.SubItems[0].Text;
                    dict.Add(id, name);
                }

                comboBoxRegionFrom.DataSource = new BindingSource(dict, null);
                comboBoxRegionFrom.DisplayMember = "Value";
                comboBoxRegionFrom.ValueMember = "Key";
                comboBoxRegionFrom.SelectedIndex = -1;

                comboBoxRegionTo.DataSource = new BindingSource(dict, null);
                comboBoxRegionTo.DisplayMember = "Value";
                comboBoxRegionTo.ValueMember = "Key";
                comboBoxRegionTo.SelectedIndex = -1;
            }
        }
        private void LoadCitiesToComboBox(ComboBox combo, int cityExcludeId, int regionId)
        {
            var items = DataAddress.getCities(regionId, cityExcludeId);
            var dict = new Dictionary<int, string>();
            foreach (ListViewItem item in items)
            {
                int id = Convert.ToInt32(item.SubItems[1].Text);
                string name = item.SubItems[0].Text;
                dict.Add(id, name);
            }

            int? previousSelectedId = null;
            if (combo.SelectedItem is KeyValuePair<int, string> prevKvp)
                previousSelectedId = prevKvp.Key;

            combo.DataSource = null;
            combo.DataSource = new BindingSource(dict, null);
            combo.DisplayMember = "Value";
            combo.ValueMember = "Key";

            if (previousSelectedId.HasValue && dict.ContainsKey(previousSelectedId.Value) && previousSelectedId.Value != cityExcludeId)
                combo.SelectedValue = previousSelectedId.Value;
            else
                combo.SelectedIndex = -1;
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
        private void loadBoxSubTransport(int transportId)
        {
            var items = DataTransport.getSubtypes(transportId);
            var dict = new Dictionary<int, string>();
            foreach (ListViewItem it in items)
            {
                int id = Convert.ToInt32(it.SubItems[2].Text);
                string name = it.SubItems[0].Text;
                dict.Add(id, name);
            }

            comboBoxSubtransport.DataSource = null;
            comboBoxSubtransport.Items.Clear();
            if (dict.Count > 0)
            {
                comboBoxSubtransport.DataSource = new BindingSource(dict, null);
                comboBoxSubtransport.DisplayMember = "Value";
                comboBoxSubtransport.ValueMember = "Key";
            }
            comboBoxSubtransport.SelectedIndex = -1;
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

        private void UpdateDistance()
        {
            if (comboBoxCityFrom.SelectedItem is KeyValuePair<int, string> fromKvp &&
                comboBoxCityTo.SelectedItem is KeyValuePair<int, string> toKvp)
            {
                if (fromKvp.Key == toKvp.Key)
                {

                    labelDistance.Text = $"Расстояние:   - км";
                    _calculatedDistance = 0;
                    return;
                }

                double? distance = DataAddress.GetDistanceBetweenCities(fromKvp.Key, toKvp.Key);
                if (distance.HasValue)
                {
                    _calculatedDistance = (float)distance;
                    labelDistance.Text = $"Расстояние:    {_calculatedDistance:F1} км";
                }
                else
                {
                    labelDistance.Text = "Расстояние: не найдено";
                    _calculatedDistance = 0;
                }
                calculateCost(null, null);
            }
            else
            {
                labelDistance.Text = "Расстояние: —";
                _calculatedDistance = 0;
            }
        }
        private void calculateCost(object sender, EventArgs e)
        {
            if (comboBoxClient.Text.Length > 0 && comboBoxTransport.Text.Length > 0 && comboBoxCityFrom.Text.Length > 0 && comboBoxCityTo.Text.Length > 0 && _calculatedDistance > 0 && numericUpDownWeight.Value > 0 && comboBoxCurrency.Text.Length > 0)
            {
                float costPerKm = float.Parse(DataTransport.getTransport(int.Parse(comboBoxTransport.SelectedValue.ToString()))[0].SubItems[1].Text);
                float distance = (float)_calculatedDistance;
                float weight = float.Parse(numericUpDownWeight.Value.ToString()) / 1000;

                float costRub = costPerKm * distance * weight;
                float rate = DataCurrency.GetRate((int)comboBoxCurrency.SelectedValue);

                float total = (float)Math.Round(costRub / rate, 2);
                string currencyCode = comboBoxCurrency.Text.Substring(0, 3);
                labelCost.Text = $"Итого: {total.ToString()} {currencyCode}";
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
            if (comboBoxClient.Text.Length > 0 && comboBoxTransport.Text.Length > 0 && comboBoxRegionFrom.Text.Length > 0 && _calculatedDistance > 0 && numericUpDownWeight.Value > 0 && comboBoxSubtransport.Text.Length > 0)
            {
                float costPerKm = float.Parse(DataTransport.getTransport(int.Parse(comboBoxTransport.SelectedValue.ToString()))[0].SubItems[1].Text);
                float distance = (float)_calculatedDistance;
                float weight = float.Parse(numericUpDownWeight.Value.ToString()) / 1000;
                float total = (float)Math.Round(costPerKm * distance * weight, 2);

                DataOrders.addOrder((int)comboBoxClient.SelectedValue, (int)comboBoxTransport.SelectedValue, (int)comboBoxSubtransport.SelectedValue, (int)comboBoxCityFrom.SelectedValue, (int)comboBoxCityTo.SelectedValue, (float)numericUpDownWeight.Value, (float)_calculatedDistance, total, (int)comboBoxCurrency.SelectedValue);
                this.Close();
            }
            else
            {
                MessageBox.Show("Поля: Клиент, Транспорт, Направление, Расстояние, Вес, Валюта обязательно должны быть заполнены!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBoxTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateCost(null, null);
            if (comboBoxTransport.SelectedItem is KeyValuePair<int, string> kvp)
            {
                int transportId = kvp.Key;
                loadBoxSubTransport(transportId);
            }
        }

        private void comboBoxRegionFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRegionFrom.SelectedValue is int regionId && regionId != -1)
            {
                LoadCitiesToComboBox(comboBoxCityFrom, cityExcludeId: _cityToId, regionId: regionId);
            }
            else
            {
                comboBoxCityFrom.DataSource = null;
            }
        }

        private void comboBoxCityFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_updatingCities) return;  // защита от рекурсии
            _updatingCities = true;

            try
            {
                if (comboBoxCityFrom.SelectedItem is KeyValuePair<int, string> kvp)
                    _cityFromId = kvp.Key;
                else
                    _cityFromId = -1;

                // Обновляем противоположный комбобокс, исключая выбранный город
                if (comboBoxRegionTo.SelectedValue is int regionToId && regionToId != -1)
                {
                    LoadCitiesToComboBox(comboBoxCityTo, cityExcludeId: _cityFromId, regionId: regionToId);
                }
                else
                {
                    comboBoxCityTo.DataSource = null;
                }

                // Проверяем, не совпадает ли теперь город назначения с городом отправления
                if (comboBoxCityTo.SelectedItem is KeyValuePair<int, string> toKvp && toKvp.Key == _cityFromId)
                    comboBoxCityTo.SelectedIndex = -1;
            }
            finally
            {
                _updatingCities = false;
            }

            UpdateDistance();
        }

        private void comboBoxCityTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_updatingCities) return;  // защита от рекурсии
            _updatingCities = true;

            try
            {
                if (comboBoxCityTo.SelectedItem is KeyValuePair<int, string> kvp)
                    _cityToId = kvp.Key;
                else
                    _cityToId = -1;

                // Обновляем противоположный комбобокс, исключая выбранный город
                if (comboBoxRegionFrom.SelectedValue is int regionFromId && regionFromId != -1)
                {
                    LoadCitiesToComboBox(comboBoxCityFrom, cityExcludeId: _cityToId, regionId: regionFromId);
                }
                else
                {
                    comboBoxCityFrom.DataSource = null;
                }

                // Проверяем, не совпадает ли теперь город отправления с городом назначения
                if (comboBoxCityFrom.SelectedItem is KeyValuePair<int, string> fromKvp && fromKvp.Key == _cityToId)
                    comboBoxCityFrom.SelectedIndex = -1;
            }
            finally
            {
                _updatingCities = false;
            }

            UpdateDistance();
        }

        private void comboBoxRegionTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRegionTo.SelectedValue is int regionId && regionId != -1)
            {
                LoadCitiesToComboBox(comboBoxCityTo, cityExcludeId: _cityFromId, regionId: regionId);
            }
            else
            {
                comboBoxCityTo.DataSource = null;
            }
        }
    }
}