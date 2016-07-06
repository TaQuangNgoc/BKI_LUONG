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
            tab_Control1.SizeMode = TabSizeMode.Fixed;
            tab_Control1.ItemSize = new Size(tab_Control1.Width / tab_Control1.TabCount, 40);
            load_du_lieu_vao_bang_loai_ngay_cong();
            load_du_lieu_vao_bang_Lam_them_gio();
            load_du_lieu_vao_bang_phu_cap();
            load_du_lieu_vao_bang_bao_hiem();

           // tabControl1.Appearance = TabAppearance.FlatButtons;
        }

        private void load_du_lieu_vao_bang_bao_hiem()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "DM_BAO_HIEM");
            m_grc_bao_hiem.DataSource = v_ds.Tables[0];
        }

        private void load_du_lieu_vao_bang_phu_cap()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_PHU_CAP");
           m_grc_loai_phu_cap.DataSource = v_ds.Tables[0];
        }

        private void load_du_lieu_vao_bang_Lam_them_gio()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "DM_TI_LE_LAM_THEM");
            m_grc_loai_lam_them_gio.DataSource = v_ds.Tables[0];
        }

        private void load_du_lieu_vao_bang_loai_ngay_cong()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "DM_LOAI_NGAY_CONG");
            m_grc_ngay_cong.DataSource = v_ds.Tables[0];
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            

        }

        
      
        
        


       
        
       
        
       


       
      
     
    }
}
