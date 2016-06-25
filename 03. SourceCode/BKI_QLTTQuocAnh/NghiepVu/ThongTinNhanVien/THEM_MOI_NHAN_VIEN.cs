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
    public partial class THEM_MOI_NHAN_VIEN : Form
    {
        public THEM_MOI_NHAN_VIEN()
        {
            InitializeComponent();
            auto_scroll_tabControl();
            format_beauty();
        }

        private void format_beauty()
        {
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(tabControl1.Width / tabControl1.TabCount, 40);
            tabControl1.Appearance = TabAppearance.Buttons;
            lblNoteTab1.MaximumSize = new Size(groupBoxNoteTab1.Width - 10, 0);
            lblNoteTab1.AutoSize = true;
            //lblNoteTab3.MaximumSize = new Size(groupBoxNoteTab3.Width - 10, 0);
            //lblNoteTab3.AutoSize = true;
           
        }

        private void auto_scroll_tabControl()
        {
            foreach (TabPage _Page in tabControl1.TabPages)
            {
                _Page.AutoScroll = true;
                _Page.AutoScrollMargin = new System.Drawing.Size(100, 100);
                _Page.AutoScrollMinSize = new System.Drawing.Size(_Page.Width+100, _Page.Height+100);
            }
        }

        //private void m_txt_lns_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(m_txt_lns.Text))
        //  {
        //      System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
        //      double valueBefore = Double.Parse(m_txt_lns.Text, System.Globalization.NumberStyles.AllowThousands);
        //      m_txt_lns.Text = String.Format(culture, "{0:N0}", valueBefore);
        //      m_txt_lns.Select(m_txt_lns.Text.Length, 0); 
        //  }
        //}

        //private void m_txt_lcd_KeyUp(object sender, KeyEventArgs e)
        //{
            
        //    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
        //    double valueBefore = Double.Parse(m_txt_lcd.Text, System.Globalization.NumberStyles.AllowThousands);
        //    m_txt_lcd.Text = String.Format(culture, "{0:N0}", valueBefore);
        //    m_txt_lcd.Select(m_txt_lns.Text.Length, 0); 
        //}

        private void text_box_key_up_format_currency(object sender, KeyEventArgs e)
        {
            try
            {
                TextBox textbox = (TextBox)sender;
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double valueBefore = Double.Parse(textbox.Text, System.Globalization.NumberStyles.AllowThousands);
                textbox.Text = String.Format(culture, "{0:N0}", valueBefore);
                textbox.Select(m_txt_lns.Text.Length, 0);
                MessageBox.Show(textbox.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Nhập chẵn số tiền!");
            }
           
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

       

       
    }
        
   }

