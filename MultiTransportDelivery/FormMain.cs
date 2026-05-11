using DataAccess;
using Order_Manager;

namespace MultiTransportDelivery
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FormMain_ResizeEnd(null, null);
            loadTable();
            listViewOrders_SelectedIndexChanged(null, null);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void loadTable()
        {
            List<ListViewItem> items = DataOrders.getOrders(-1);
            listViewOrders.Items.Clear();

            if (items.Count > 0)
            {
                labelEmptyOrders.Visible = false;
                for (int i = 0; i < items.Count; i++)
                {
                    listViewOrders.Items.Add(items[i]);
                }
            }
            else
            {
                labelEmptyOrders.Visible = true;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void FormMain_ResizeEnd(object sender, EventArgs e)
        {
            int totalWidth_order = listViewOrders.ClientSize.Width;
            int columnCount_order = 9;
            int colWidth_order = totalWidth_order / columnCount_order;
            listViewOrders.BeginUpdate();
            for (int i = 0; i < columnCount_order; i++)
            {
                if (i == columnCount_order - 1)
                {
                    listViewOrders.Columns[i].Width = totalWidth_order - (colWidth_order * (columnCount_order - 1));
                }
                else
                {
                    listViewOrders.Columns[i].Width = colWidth_order;
                }
            }
            listViewOrders.EndUpdate();
            labelEmptyOrders.Location = new Point(listViewOrders.Location.X + (totalWidth_order / 2), listViewOrders.Location.Y + (listViewOrders.Height / 2));
        }
        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count > 0)
            {
                buttonEditOrder.Enabled = true;
                buttonDelOrder.Enabled = true;
                buttonPayOrder.Enabled = true;
            }
            else
            {
                buttonEditOrder.Enabled = false;
                buttonDelOrder.Enabled = false;
                buttonPayOrder.Enabled = false;
            }
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            FormClients client = new FormClients();
            client.ShowDialog();
        }

        private void buttonTransport_Click(object sender, EventArgs e)
        {
            FormTransport transport = new FormTransport();
            transport.ShowDialog();
        }

        private void buttonDirections_Click(object sender, EventArgs e)
        {
            FormDirections directions = new FormDirections();
            directions.ShowDialog();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            FormAddOrder formAddOrder = new FormAddOrder();
            formAddOrder.ShowDialog();
            loadTable();
        }

        private void buttonEditOrder_Click(object sender, EventArgs e)
        {
            FormEditOrder formEditOrder = new FormEditOrder(listViewOrders.SelectedItems[0]);
            formEditOrder.ShowDialog();
            loadTable();
        }

        private void buttonDelOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить этот элемент без возможности восстановления?", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListViewItem item = listViewOrders.SelectedItems[0];
                DataOrders.delOrder(Int32.Parse(item.SubItems[8].Text));
                loadTable();
            }
            listViewOrders_SelectedIndexChanged(null, null);
        }

        private void сведенияОЗаказахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrdersInfo formOrdersInfo = new FormOrdersInfo();
            formOrdersInfo.ShowDialog();
        }

        private void сведенияОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDebtors formDebtors = new FormDebtors();
            formDebtors.ShowDialog();
        }

        private void buttonPayOrder_Click(object sender, EventArgs e)
        {
            FormPayOrder payOrder = new FormPayOrder(listViewOrders.SelectedItems[0]);
            payOrder.ShowDialog();
            loadTable();
        }
    }
}
