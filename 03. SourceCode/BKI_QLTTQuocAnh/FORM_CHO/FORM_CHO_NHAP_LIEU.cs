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

namespace BKI_DichVuMatDat.FORM_CHO
{
    public partial class FORM_CHO_NHAP_LIEU : MaterialSkin.Controls.MaterialForm
    {
        public FORM_CHO_NHAP_LIEU()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("./Default/webframe.html", FileMode.Open, FileAccess.Read);
            //  MessageBox.Show(fs.Name);
            Uri uri = new Uri(fs.Name + "#Nh.html");
            Document v_f = new Document();
            v_f.Display(uri);
        }
    }
}
