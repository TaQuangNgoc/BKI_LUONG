using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat
{
    public partial class Document : Form
    {
        public Document()
        {
            InitializeComponent();
        }

        internal void Display(Uri uri)
        {
            webBrowser1.Navigate(uri);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.ShowDialog();
            
        }

        private void m_btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
