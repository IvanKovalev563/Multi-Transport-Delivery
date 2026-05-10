using DataAccess;
using Order_Manager;
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
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
            FormClients_ResizeEnd(null, null);
            listViewClients_SelectedIndexChanged(null, null);
            loadTable();
        }

        private void loadTable()
        {
            List<ListViewItem> items = DataClient.getClients();
            listViewClients.Items.Clear();

            if (items.Count > 0)
            {
                labelEmptyClients.Visible = false;
                for (int i = 0; i < items.Count; i++)
                {
                    listViewClients.Items.Add(items[i]);
                }
            }
            else
            {
                labelEmptyClients.Visible = true;
            }
        }

        private void FormClients_ResizeEnd(object sender, EventArgs e)
        {
            int totalWidth_order = listViewClients.ClientSize.Width;
            int columnCount_order = 4;
            int colWidth_order = totalWidth_order / columnCount_order;
            listViewClients.BeginUpdate();
            for (int i = 0; i < columnCount_order; i++)
            {
                if (i == columnCount_order - 1)
                {
                    listViewClients.Columns[i].Width = totalWidth_order - (colWidth_order * (columnCount_order - 1));
                }
                else
                {
                    listViewClients.Columns[i].Width = colWidth_order;
                }
            }
            listViewClients.EndUpdate();
            labelEmptyClients.Location = new Point(listViewClients.Location.X + (totalWidth_order / 2), listViewClients.Location.Y + (listViewClients.Height / 2));
        }

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count > 0)
            {
                buttonEditClient.Enabled = true;
                buttonDelClient.Enabled = true;
            }
            else
            {
                buttonEditClient.Enabled = false;
                buttonDelClient.Enabled = false;
            }
        }
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            FormAddClient formAddClient = new FormAddClient();
            formAddClient.ShowDialog();
            loadTable();
        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            FormEditClient formEditClient = new FormEditClient(listViewClients.SelectedItems[0]);
            formEditClient.ShowDialog();
            loadTable();
        }

        private void buttonDelClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить этот элемент без возможности восстановления?", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListViewItem item = listViewClients.SelectedItems[0];
                DataClient.delClient(Int32.Parse(item.SubItems[4].Text));
                loadTable();
            }
            listViewClients_SelectedIndexChanged(null, null);
        }
    }
}
