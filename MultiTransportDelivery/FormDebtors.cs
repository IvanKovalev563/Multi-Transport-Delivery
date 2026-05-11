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
    public partial class FormDebtors : Form
    {
        public FormDebtors()
        {
            InitializeComponent();
            loadTable();
        }

        private void loadTable()
        {
            List<ListViewItem> items = DataPayments.getDebtors();
            listViewDebtors.Items.Clear();

            if (items.Count > 0)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    listViewDebtors.Items.Add(items[i]);
                }
            }
        }
    }
}
