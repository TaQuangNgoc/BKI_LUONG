using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;

namespace BKI_DichVuMatDat
{
    public partial class THEM_MOI_NHAN_VIEN : Form
    {
        decimal m_id_nhan_vien;
        public THEM_MOI_NHAN_VIEN()
        {
            InitializeComponent();
            auto_scroll_tabControl();
            format_beauty();
            active_checkbox_hinh_thuc_tinh_luong();
        }

        private void active_checkbox_hinh_thuc_tinh_luong()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //LAY RA TẤT CẢ CÁC HÌNH THỨC TÍNH LƯƠNG, INSERT CHO NHÂN VIÊN , cho trạng thái CO_YN là N
            DataSet v_ds_hinh_thuc_tinh_luong = new DataSet();
            v_ds_hinh_thuc_tinh_luong.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds_hinh_thuc_tinh_luong, "SELECT * FROM GD_CONG_TY_HINH_THUC_TINH_LUONG WHERE CO_YN='Y'");
            for (int i = 0; i < v_ds_hinh_thuc_tinh_luong.Tables[0].Rows.Count; i++)
            {
                if(decimal.Parse(v_ds_hinh_thuc_tinh_luong.Tables[0].Rows[i]["ID"].ToString())==1)
                {
                    m_cb_luong_theo_thoi_gian.Checked= true;
                }
                if (decimal.Parse(v_ds_hinh_thuc_tinh_luong.Tables[0].Rows[i]["ID"].ToString()) == 2)
                {
                    m_cb_luong_ngay.Checked = true;
                }
                if (decimal.Parse(v_ds_hinh_thuc_tinh_luong.Tables[0].Rows[i]["ID"].ToString()) == 3)
                {
                    m_cb_luong_theo_san_pham.Checked = true;
                }
                if (decimal.Parse(v_ds_hinh_thuc_tinh_luong.Tables[0].Rows[i]["ID"].ToString()) == 4)
                {
                    m_cb_luong_khoan.Checked = true;
                }

            }
        }

        private void format_beauty()
        {
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(tabControl1.Width / tabControl1.TabCount, 40);
            tabControl1.Appearance = TabAppearance.Buttons;
            lblNoteTab1.MaximumSize = new Size(groupBoxNoteTab1.Width - 10, 0);
            lblNoteTab1.AutoSize = true;

            //NGÀY BẮT ĐẦU VÀO LÀM BAN ĐẦU CHO CHECKBOX LÀ UNCHECK
            m_dtp_ngay_bat_dau_lv.Checked = false;
        }

        private void auto_scroll_tabControl()
        {
            foreach (TabPage _Page in tabControl1.TabPages)
            {
                _Page.AutoScroll = true;
                _Page.AutoScrollMargin = new System.Drawing.Size(100, 100);
                _Page.AutoScrollMinSize = new System.Drawing.Size(_Page.Width + 100, _Page.Height + 100);
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
                textbox.Select(m_txt_lns.Text.Length, 0);

            }
            catch (Exception)
            {
                MessageBox.Show("Nhập chẵn số tiền!");
                textbox.Text = "";
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

        private void text_box_format_numeric_not_contain_point(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            luu_thong_tin_chung();
            gan_cac_hinh_thuc_tinh_luong();
            luu_thong_tin_luong_theo_thoi_gian();
            luu_thong_tin_luong_khac();
        }

        private void luu_thong_tin_luong_khac()
        {
            throw new NotImplementedException();
        }

        private void luu_thong_tin_luong_theo_thoi_gian()
        {
            throw new NotImplementedException();
        }

        private void gan_cac_hinh_thuc_tinh_luong()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //LAY RA TẤT CẢ CÁC HÌNH THỨC TÍNH LƯƠNG, INSERT CHO NHÂN VIÊN , cho trạng thái CO_YN là N
            DataSet v_ds_hinh_thuc_tinh_luong = new DataSet();
            v_ds_hinh_thuc_tinh_luong.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds_hinh_thuc_tinh_luong, "SELECT * FROM DM_HINH_THUC_TINH_LUONG");
            for (int i = 0; i < v_ds_hinh_thuc_tinh_luong.Tables[0].Rows.Count; i++)
            {
                US_GD_NHAN_VIEN_HINH_THUC_TINH_LUONG v_us_nv_httl = new US_GD_NHAN_VIEN_HINH_THUC_TINH_LUONG();
                v_us_nv_httl.dcID_NHAN_VIEN = m_id_nhan_vien;
                v_us_nv_httl.dcID_HINH_THUC_TINH_LUONG = IP.Core.IPCommon.CIPConvert.ToDecimal(v_ds_hinh_thuc_tinh_luong.Tables[0].Rows[i]["ID"].ToString());
                v_us_nv_httl.strCO_YN = "N";
                v_us_nv_httl.Insert();
            }

            //set trạng thái CO_YN phù hợp với các hình thức của công ty
            DataSet v_ds_hinh_thuc_active = new DataSet();
            v_ds_hinh_thuc_active.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds_hinh_thuc_active, "SELECT * FROM GD_CONG_TY_HINH_THUC_TINH_LUONG WHERE CO_YN='Y'");
            for (int i = 0; i < v_ds_hinh_thuc_active.Tables[0].Rows.Count; i++)
            {
                decimal v_id_hinh_thuc= decimal.Parse(v_ds_hinh_thuc_active.Tables[0].Rows[i]["ID"].ToString());
                v_us.active_hinh_thuc_tinh_luong(m_id_nhan_vien, v_id_hinh_thuc);
            }

        }

        private void luu_thong_tin_chung()
        {
            US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN();
            v_us.strHO_DEM = m_txt_ho_dem.Text;
            v_us.strTEN = m_txt_ten.Text;
            v_us.datNGAY_SINH = m_dtp_ngay_sinh.Value;
            v_us.strMA_NV = m_txt_ma_nhan_vien.Text;
            v_us.strSDT = m_txt_sdt.Text;
            v_us.strEMAIL = m_txt_email.Text;
            if (m_dtp_ngay_bat_dau_lv.Checked==true)
            v_us.datNGAY_BAT_DAU_LAM_VIEC = m_dtp_ngay_bat_dau_lv.Value;
            v_us.Insert();
            m_id_nhan_vien = v_us.dcID;
        }

        private void m_cb_luong_theo_thoi_gian_CheckStateChanged(object sender, EventArgs e)
        {
            if (m_cb_luong_theo_thoi_gian.Checked == false)
            {
                m_grb_doan_phi.Enabled = false;
                m_grb_loai_nv.Enabled = false;
                m_grb_nguoi_phu_thuoc.Enabled = false;
                m_grb_phan_tram_luong.Enabled = false;
                m_grb_phu_cap.Enabled = false;
                m_grb_thong_tin_ve_luong.Enabled = false;
            }
            else
            {
                m_grb_doan_phi.Enabled = true;
                m_grb_loai_nv.Enabled = true;
                m_grb_nguoi_phu_thuoc.Enabled = true;
                m_grb_phan_tram_luong.Enabled = true;
                m_grb_phu_cap.Enabled = true;
                m_grb_thong_tin_ve_luong.Enabled = true;
            }
        }



    }

}

