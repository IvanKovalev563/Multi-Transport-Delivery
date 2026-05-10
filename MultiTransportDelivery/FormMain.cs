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
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void FormMain_ResizeEnd(object sender, EventArgs e)
        {
            int totalWidth_order = listViewOrders.ClientSize.Width;
            int columnCount_order = 7;
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

        }
    }
}
