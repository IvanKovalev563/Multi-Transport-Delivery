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
    public partial class FormTransport : Form
    {
        public FormTransport()
        {
            InitializeComponent();
            loadTable();
            listViewTransport_SelectedIndexChanged(null, null);
            FormTransport_ResizeEnd(null, null);
        }
        private void loadTable()
        {
            List<ListViewItem> items = DataTransport.getTransport();
            listViewTransport.Items.Clear();

            if (items.Count > 0)
            {
                labelEmptyTransport.Visible = false;
                for (int i = 0; i < items.Count; i++)
                {
                    listViewTransport.Items.Add(items[i]);
                }
            }
            else
            {
                labelEmptyTransport.Visible = true;
            }
        }

        private void FormTransport_ResizeEnd(object sender, EventArgs e)
        {
            int totalWidth_order = listViewTransport.ClientSize.Width;
            int columnCount_order = 2;
            int colWidth_order = totalWidth_order / columnCount_order;
            listViewTransport.BeginUpdate();
            for (int i = 0; i < columnCount_order; i++)
            {
                if (i == columnCount_order - 1)
                {
                    listViewTransport.Columns[i].Width = totalWidth_order - (colWidth_order * (columnCount_order - 1));
                }
                else
                {
                    listViewTransport.Columns[i].Width = colWidth_order;
                }
            }
            listViewTransport.EndUpdate();
            labelEmptyTransport.Location = new Point(listViewTransport.Location.X + (totalWidth_order / 2), listViewTransport.Location.Y + (listViewTransport.Height / 2));
        }

        private void listViewTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTransport.SelectedItems.Count > 0)
            {
                buttonEditTransport.Enabled = true;
                buttonDelTransport.Enabled = true;
            }
            else
            {
                buttonEditTransport.Enabled = false;
                buttonDelTransport.Enabled = false;
            }
        }

        private void buttonAddTransport_Click(object sender, EventArgs e)
        {
            FormAddTransport formAddTransport = new FormAddTransport();
            formAddTransport.ShowDialog();
            loadTable();
        }

        private void buttonEditTransport_Click(object sender, EventArgs e)
        {
            FormEditTransport formEditTransport = new FormEditTransport(listViewTransport.SelectedItems[0]);
            formEditTransport.ShowDialog();
            loadTable();
        }

        private void buttonDelTransport_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить этот элемент без возможности восстановления?", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListViewItem item = listViewTransport.SelectedItems[0];
                DataTransport.delTransport(Int32.Parse(item.SubItems[2].Text));
                loadTable();
            }
            listViewTransport_SelectedIndexChanged(null, null);
        }
    }
}
