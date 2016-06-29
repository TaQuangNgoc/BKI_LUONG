using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat
{
    public partial class THAM_SO_CHAM_CONG_THOI_GIAN : Form
    {
        public THAM_SO_CHAM_CONG_THOI_GIAN()
        {
            InitializeComponent();
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(tabControl1.Width / tabControl1.TabCount, 40);
           // tabControl1.Appearance = TabAppearance.FlatButtons;
        }

        private void text_box_format_numeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void text_box_key_up_format_currency(object sender, KeyEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            try
            {
               
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double valueBefore = Double.Parse(textbox.Text, System.Globalization.NumberStyles.AllowThousands);
                textbox.Text = String.Format(culture, "{0:N0}", valueBefore);       
            }
            catch (Exception)
            {

                MessageBox.Show("Nhập chẵn số tiền!");
                textbox.Text = "";
            }

        }

        
      
        
        


       
        
       
        
       


       
      
     
    }
}
