using DevExpress.XtraEditors;
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
    public partial class THAM_SO_KHAC : MaterialSkin.Controls.MaterialForm
    {
        public THAM_SO_KHAC()
        {
            InitializeComponent();
            load_du_lieu();
            
        }

        private void text_box_key_up_format_currency(object sender, KeyEventArgs e)
        {
            TextEdit textbox = (TextEdit)sender;
            try
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double valueBefore = Double.Parse(textbox.Text, System.Globalization.NumberStyles.AllowThousands);
                textbox.Text = String.Format(culture, "{0:N0}", valueBefore);
                textbox.Select(textbox.Text.Length, 0);

            }
            catch (Exception)
            {
                XtraMessageBox.Show("Nhập chẵn số tiền!");
                textbox.Text = "";
            }

        }

        private void text_box_format_numeric_not_contain_point(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception v_e)
            {
                
                throw v_e;
            }
        }


        private void load_du_lieu()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            //  v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN=5");
            v_us.FillDatasetWithTableName(v_ds, "DM_THAM_SO");
            m_txt_giam_tru_gia_canh.Text = ((decimal)v_ds.Tables[0].Rows[0]["SO_TIEN"]).ToString("N0");
            m_txt_giam_tru_phu_thuoc.Text = ((decimal)v_ds.Tables[0].Rows[1]["SO_TIEN"]).ToString("N0");
            m_txt_luong_toi_thieu_quy_dinh.Text = ((decimal)v_ds.Tables[0].Rows[3]["SO_TIEN"]).ToString("N0");
            m_txt_luong_toi_thieu_vung.Text = ((decimal)v_ds.Tables[0].Rows[2]["SO_TIEN"]).ToString("N0");
            m_txt_so_thang_tinh_bhxh.Text = ((decimal)v_ds.Tables[0].Rows[4]["SO_TIEN"]).ToString("N0"); 
            
        }

        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            if (check_du_lieu_is_ok())
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                decimal Giam_tru_gia_canh = decimal.Parse(m_txt_giam_tru_gia_canh.Text.ToString().Replace(",", ""));
                decimal Phu_thuoc = decimal.Parse(m_txt_giam_tru_phu_thuoc.Text.ToString().Replace(",", ""));
                decimal Luong_toi_thieu_quy_dinh = decimal.Parse(m_txt_luong_toi_thieu_quy_dinh.Text.ToString().Replace(",", ""));
                decimal Luong_toi_thieu_vung = decimal.Parse(m_txt_luong_toi_thieu_vung.Text.ToString().Replace(",", ""));
                decimal So_thang_tinh_bhxh = decimal.Parse(m_txt_so_thang_tinh_bhxh.Text.ToString().Replace(",", ""));
                v_us.UpdateThamSoKhac(Giam_tru_gia_canh, Phu_thuoc, Luong_toi_thieu_quy_dinh, Luong_toi_thieu_vung, So_thang_tinh_bhxh);
                XtraMessageBox.Show("Lưu thành công dữ liệu về 1 số tham số khác!");
            }
        }

        private bool check_du_lieu_is_ok()
        {
            if (m_txt_so_thang_tinh_bhxh.Text != "" && m_txt_luong_toi_thieu_vung.Text != "" && m_txt_giam_tru_phu_thuoc.Text != "" && m_txt_luong_toi_thieu_quy_dinh.Text != "" && m_txt_giam_tru_gia_canh.Text != "")
                return true;
            else
            {
                XtraMessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return false;
            }
           
        }
    }
}
