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
    public partial class FormDirections : Form
    {
        public FormDirections()
        {
            InitializeComponent();
            FormDirections_ResizeEnd(null, null);
            loadTable();
            listViewDirections_SelectedIndexChanged(null, null);
        }

        private void loadTable()
        {
            List<ListViewItem> items = DataDirections.getDirections(textBoxSearch.Text);
            listViewDirections.Items.Clear();

            if (items.Count > 0)
            {
                labelEmptyDirections.Visible = false;
                for (int i = 0; i < items.Count; i++)
                {
                    listViewDirections.Items.Add(items[i]);
                }
            }
            else
            {
                labelEmptyDirections.Visible = true;
            }
        }

        private void FormDirections_ResizeEnd(object sender, EventArgs e)
        {
            int totalWidth_order = listViewDirections.ClientSize.Width;
            int columnCount_order = 1;
            int colWidth_order = totalWidth_order / columnCount_order;
            listViewDirections.BeginUpdate();
            for (int i = 0; i < columnCount_order; i++)
            {
                if (i == columnCount_order - 1)
                {
                    listViewDirections.Columns[i].Width = totalWidth_order - (colWidth_order * (columnCount_order - 1));
                }
                else
                {
                    listViewDirections.Columns[i].Width = colWidth_order;
                }
            }
            listViewDirections.EndUpdate();
            labelEmptyDirections.Location = new Point(listViewDirections.Location.X + (totalWidth_order / 2), listViewDirections.Location.Y + (listViewDirections.Height / 2));
        }

        private void listViewDirections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDirections.SelectedItems.Count > 0)
            {
                buttonEditDirection.Enabled = true;
                buttonDelDirection.Enabled = true;
            }
            else
            {
                buttonEditDirection.Enabled = false;
                buttonDelDirection.Enabled = false;
            }
        }

        private void buttonAddDirection_Click(object sender, EventArgs e)
        {
            FormAddDirection formAddDirection = new FormAddDirection();
            formAddDirection.ShowDialog();
            loadTable();
        }

        private void buttonEditDirection_Click(object sender, EventArgs e)
        {
            FormEditDirection formEditDirection = new FormEditDirection(listViewDirections.SelectedItems[0]);
            formEditDirection.ShowDialog();
            loadTable();
        }

        private void buttonDelDirection_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить этот элемент без возможности восстановления?", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListViewItem item = listViewDirections.SelectedItems[0];
                DataDirections.delDirection(Int32.Parse(item.SubItems[1].Text));
                loadTable();
            }
            listViewDirections_SelectedIndexChanged(null, null);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            loadTable();
        }
    }
}
