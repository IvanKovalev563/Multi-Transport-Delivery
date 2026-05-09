using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_Manager
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            string infoVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductVersion;
            string author = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).CompanyName;

            infoVersion = infoVersion?.Contains('+') == true? infoVersion.Substring(0, infoVersion.IndexOf('+')) : infoVersion ?? "0.0.0";

            labelVersion.Text = "v" + infoVersion;
            labelAuthor.Text = "Автор: " + author;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
