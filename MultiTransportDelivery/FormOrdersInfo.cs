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
    public partial class FormOrdersInfo : Form
    {
        public FormOrdersInfo()
        {
            InitializeComponent();
            loadTable();
            labelOrders.Text = $"Заказов: {DataOrders.getOrdersCount(false).ToString()}";
            labelActiveOrders.Text = $"Активных заказов: {DataOrders.getOrdersCount(true).ToString()}";
        }

        private void loadTable()
        {
            List<ListViewItem> items = DataTransport.getNeededTransport();
            listViewNeededTransport.Items.Clear();

            if (items.Count > 0)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    listViewNeededTransport.Items.Add(items[i]);
                }
            }
        }
    }
}
