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

namespace BKI_DichVuMatDat.CAI_DAT
{
    public partial class FORM_CHO_CAI_DAT : MaterialSkin.Controls.MaterialForm
    {
        public FORM_CHO_CAI_DAT()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("./Default/webframe.html", FileMode.Open, FileAccess.Read);
            //  MessageBox.Show(fs.Name);
            Uri uri = new Uri(fs.Name + "#Cài.html");
            Document v_f = new Document();
            v_f.Display(uri);
        }
    }
}
