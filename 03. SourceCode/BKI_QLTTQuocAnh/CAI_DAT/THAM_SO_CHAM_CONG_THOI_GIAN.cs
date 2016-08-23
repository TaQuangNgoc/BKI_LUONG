using BKI_DichVuMatDat.CAI_DAT.DETAIL;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using MaterialSkin;
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
    public partial class THAM_SO_CHAM_CONG_THOI_GIAN : MaterialSkin.Controls.MaterialForm
    {
        

        public THAM_SO_CHAM_CONG_THOI_GIAN()
        {
            InitializeComponent();
            tab_Control1.SizeMode = TabSizeMode.Fixed;
            tab_Control1.ItemSize = new Size(tab_Control1.Width / tab_Control1.TabCount, 40);
            

            

        }
        private void THAM_SO_CHAM_CONG_THOI_GIAN_Load(object sender, EventArgs e)
        {
            try
            {
                load_du_lieu_vao_bang_loai_ngay_cong();
                load_du_lieu_vao_bang_Lam_them_gio();
                load_du_lieu_vao_bang_phu_cap();

                load_du_lieu_vao_bang_bao_hiem();
                load_du_lieu_vao_bang_thue();

                m_grv_ngay_cong.ColumnPanelRowHeight = 40;
                m_grv_ngay_cong.RowHeight = 35;

                m_grv_bao_hiem.ColumnPanelRowHeight = 40;
                m_grv_bao_hiem.RowHeight = 35;

                m_grv_lam_them_gio.ColumnPanelRowHeight = 40;
                m_grv_lam_them_gio.RowHeight = 35;

                m_grv_phu_cap.ColumnPanelRowHeight = 40;
                m_grv_phu_cap.RowHeight = 35;

                m_grv_thue.ColumnPanelRowHeight = 40;
                m_grv_thue.RowHeight = 35;
            }
            catch (Exception v_e)
            {

                XtraMessageBox.Show(v_e.Message);
            }
           
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
        private void load_du_lieu_vao_bang_thue()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "DM_THUE");
            m_grc_thue.DataSource = v_ds.Tables[0];
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
                textbox.Select(textbox.Text.Length, 0);

            }
            catch (Exception)
            {
                XtraMessageBox.Show("Nhập chẵn số tiền!");
                textbox.Text = "";
            }

        }


        private void m_cmd_them_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tab_Control1.SelectedTab.Name)
                {
                    case "tab_loaingaycong":
                        LOAI_NGAY_CONG_DETAIL v_f_loai_ngay_cong = new LOAI_NGAY_CONG_DETAIL();
                        v_f_loai_ngay_cong.dislay_for_insert();
                        load_du_lieu_vao_bang_loai_ngay_cong();
                        break;
                    case "tab_lamthemgio":
                        LAM_THEM_GIO_DETAIL v_f_lam_them_gio = new LAM_THEM_GIO_DETAIL();
                        v_f_lam_them_gio.dislay_for_insert();
                        load_du_lieu_vao_bang_Lam_them_gio();
                        break;
                    case "tab_phucap":
                        PHU_CAP_DETAIL v_f_phu_cap = new PHU_CAP_DETAIL();
                        v_f_phu_cap.dislay_for_insert();
                        load_du_lieu_vao_bang_phu_cap();
                        break;
                    case "tab_baohiem":
                        BAO_HIEM_DETAIL v_f_bao_hiem = new BAO_HIEM_DETAIL();
                        v_f_bao_hiem.dislay_for_insert();
                        load_du_lieu_vao_bang_bao_hiem();
                        break;
                    case "tab_thue":
                        THUE_DETAIL v_f_thue = new THUE_DETAIL();
                        v_f_thue.dislay_for_insert();
                        load_du_lieu_vao_bang_thue();
                        break;
                    
                    default:
                        break;
                }
                
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tab_Control1.SelectedTab.Name)
                {
                    case "tab_loaingaycong":
                        loại_ngay_cong_delete();
                        break;
                    case "tab_lamthemgio":
                        lam_them_gio_delete();
                        break;
                    case "tab_baohiem":
                        bao_hiem_delete();
                        break;
                    case "tab_thue":
                       thue_delete();
                        break;
                    case "tab_phucap":
                        phucap_delete();
                        break;
                        
                    default:
                        break;
                }
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void phucap_delete()
        {
            try
            {
                DialogResult dialogresult = XtraMessageBox.Show("bạn có chắc chắn muốn hoàn thành tác vụ này không?", "cảnh báo", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                DataRow v_dr = m_grv_phu_cap.GetDataRow(m_grv_phu_cap.FocusedRowHandle);
                decimal v_id = CIPConvert.ToDecimal(v_dr["ID"].ToString());
                US_DM_PHU_CAP v_us = new US_DM_PHU_CAP(v_id);
                v_us.Delete();
                XtraMessageBox.Show("Đã xóa thành công tên phụ cấp : " + v_dr["TEN_PHU_CAP"] +" !");
                load_du_lieu_vao_bang_phu_cap();
            }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Đã tồn tại ngày chấm công chứa mã ngày công này!\n Bạn không thể xóa phụ cấp này ");
                
            }
            
        }
            

        private void thue_delete()
        {
            DialogResult dialogresult = XtraMessageBox.Show("bạn có chắc chắn muốn hoàn thành tác vụ này không?", "cảnh báo", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                DataRow v_dr = m_grv_thue.GetDataRow(m_grv_thue.FocusedRowHandle);
                decimal v_id = CIPConvert.ToDecimal(v_dr["ID"].ToString());
                US_DM_THUE v_us = new US_DM_THUE(v_id);
                v_us.Delete();
                XtraMessageBox.Show("Đã xóa thành công " + " !");
                load_du_lieu_vao_bang_thue();
            }
        }

        private void bao_hiem_delete()
        {
            DialogResult dialogresult = XtraMessageBox.Show("bạn có chắc chắn muốn hoàn thành tác vụ này không?", "cảnh báo", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                DataRow v_dr = m_grv_bao_hiem.GetDataRow(m_grv_bao_hiem.FocusedRowHandle);
                decimal v_id = CIPConvert.ToDecimal(v_dr["ID"].ToString());
                US_DM_BAO_HIEM v_us = new US_DM_BAO_HIEM(v_id);
                v_us.Delete();
                XtraMessageBox.Show("Đã xóa thành công mã loại bảo hiểm " + v_dr["MA_BH"] + " !");
                load_du_lieu_vao_bang_bao_hiem();
            }
        }

        private void lam_them_gio_delete()
        {
            try
            {
                DialogResult dialogresult = XtraMessageBox.Show("bạn có chắc chắn muốn hoàn thành tác vụ này không?", "cảnh báo", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    DataRow v_dr = m_grv_lam_them_gio.GetDataRow(m_grv_lam_them_gio.FocusedRowHandle);
                    decimal v_id = CIPConvert.ToDecimal(v_dr["ID"].ToString());
                    US_DM_TI_LE_LAM_THEM v_us = new US_DM_TI_LE_LAM_THEM(v_id);
                    v_us.Delete();
                    XtraMessageBox.Show("Đã xóa thành công mã loại làm thêm " + v_dr["MA_LAM_THEM"] + " !");
                    load_du_lieu_vao_bang_Lam_them_gio();
                }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Đã tồn tại ngày chấm công chứa mã ngày công này!\n Bạn không thể xóa loại làm thêm này ");
            }
            
        }

        private void loại_ngay_cong_delete()
        {
            try
            {
                DialogResult dialogresult = XtraMessageBox.Show("bạn có chắc chắn muốn hoàn thành tác vụ này không?", "cảnh báo", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    DataRow v_dr = m_grv_ngay_cong.GetDataRow(m_grv_ngay_cong.FocusedRowHandle);
                    decimal v_id = CIPConvert.ToDecimal(v_dr["ID"].ToString());
                    US_DM_LOAI_NGAY_CONG v_us = new US_DM_LOAI_NGAY_CONG(v_id);
                    v_us.Delete();
                    XtraMessageBox.Show("Đã xóa thành công mã ngày công " + v_dr["MA_NGAY_CONG"] + " !");
                    load_du_lieu_vao_bang_loai_ngay_cong();
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Đã tồn tại ngày chấm công chứa mã ngày công này!\n Bạn không thể xóa loại ngày công này ");
                
            }
            
        }

        private void m_cmd_sua_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tab_Control1.SelectedTab.Name)
                {
                    case "tab_loaingaycong":
                        loai_ngay_cong_update();
                        break;
                    case "tab_lamthemgio":
                        lam_them_gio_update();
                        break;
                    case "tab_phucap":
                        phu_cap_update();
                        break;
                    case "tab_baohiem":
                       bao_hiem_update();
                        break;
                    case "tab_thue":
                       thue_update();
                        break;



                    default:
                        break;
                }
            }

            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void thue_update()
        {
            var v_count_thue = m_grv_thue.SelectedRowsCount;
            if (v_count_thue == 0)
            {
                XtraMessageBox.Show("Bạn phải chọn 1 sản phẩm mới có thể cập nhật!");
            }
            else if (v_count_thue > 1)
            {
                XtraMessageBox.Show("Vui lòng chỉ lựa chọn 1 sản phẩm để cập nhật!");
            }
            else
            {
                DataRow v_dr = m_grv_thue.GetDataRow(m_grv_thue.FocusedRowHandle);
                US_DM_THUE v_us = new US_DM_THUE(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                THUE_DETAIL v_f = new THUE_DETAIL();
                v_f.dislay_for_update(v_us);
                load_du_lieu_vao_bang_thue();
            }
        }

        private void bao_hiem_update()
        {
            var v_count_bao_hiem = m_grv_bao_hiem.SelectedRowsCount;
            if (v_count_bao_hiem == 0)
            {
                XtraMessageBox.Show("Bạn phải chọn 1 sản phẩm mới có thể cập nhật!");
            }
            else if (v_count_bao_hiem > 1)
            {
                XtraMessageBox.Show("Vui lòng chỉ lựa chọn 1 sản phẩm để cập nhật!");
            }
            else
            {
                DataRow v_dr = m_grv_bao_hiem.GetDataRow(m_grv_bao_hiem.FocusedRowHandle);
                US_DM_BAO_HIEM v_us = new US_DM_BAO_HIEM(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                BAO_HIEM_DETAIL v_f = new BAO_HIEM_DETAIL();
                v_f.dislay_for_update(v_us);
                load_du_lieu_vao_bang_bao_hiem();
            }
        }

        private void phu_cap_update()
        {
            var v_count_phu_cap = m_grv_phu_cap.SelectedRowsCount;
            if (v_count_phu_cap == 0)
            {
                XtraMessageBox.Show("Bạn phải chọn 1 sản phẩm mới có thể cập nhật!");
            }
            else if (v_count_phu_cap > 1)
            {
                XtraMessageBox.Show("Vui lòng chỉ lựa chọn 1 sản phẩm để cập nhật!");
            }
            else
            {
                DataRow v_dr = m_grv_phu_cap.GetDataRow(m_grv_phu_cap.FocusedRowHandle);
                US_DM_PHU_CAP v_us = new US_DM_PHU_CAP(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                PHU_CAP_DETAIL v_f = new PHU_CAP_DETAIL();
                v_f.dislay_for_update(v_us);
               
                load_du_lieu_vao_bang_phu_cap();
            }
        }

        private void lam_them_gio_update()
        {
            var v_count_lam_them_gio = m_grv_lam_them_gio.SelectedRowsCount;
            if (v_count_lam_them_gio == 0)
            {
                XtraMessageBox.Show("Bạn phải chọn 1 sản phẩm mới có thể cập nhật!");
            }
            else if (v_count_lam_them_gio > 1)
            {
                XtraMessageBox.Show("Vui lòng chỉ lựa chọn 1 sản phẩm để cập nhật!");
            }
            else
            {
                DataRow v_dr = m_grv_lam_them_gio.GetDataRow(m_grv_lam_them_gio.FocusedRowHandle);
                US_DM_TI_LE_LAM_THEM v_us = new US_DM_TI_LE_LAM_THEM(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                LAM_THEM_GIO_DETAIL v_f = new LAM_THEM_GIO_DETAIL();
                v_f.dislay_for_update(v_us);
                load_du_lieu_vao_bang_Lam_them_gio();
            }
        }

        private void loai_ngay_cong_update()
        {
            var v_count_loai_ngay_cong = m_grv_ngay_cong.SelectedRowsCount;
            if (v_count_loai_ngay_cong == 0)
            {
                XtraMessageBox.Show("Bạn phải chọn 1 sản phẩm mới có thể cập nhật!");
            }
            else if (v_count_loai_ngay_cong > 1)
            {
                XtraMessageBox.Show("Vui lòng chỉ lựa chọn 1 sản phẩm để cập nhật!");
            }
            else
            {
                DataRow v_dr = m_grv_ngay_cong.GetDataRow(m_grv_ngay_cong.FocusedRowHandle);
                US_DM_LOAI_NGAY_CONG v_us = new US_DM_LOAI_NGAY_CONG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                LOAI_NGAY_CONG_DETAIL v_f = new LOAI_NGAY_CONG_DETAIL();
                v_f.dislay_for_update(v_us);
                load_du_lieu_vao_bang_loai_ngay_cong();
            }
        }   

        private void tab_Control1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tab_Control1.SelectedTab.Name == "tab_doanphi")
            {
                load_data_to_tab_doan_phi();
                m_cmd_luu.Visible = true;
                m_cmd_sua.Visible = false;
                m_cmd_them.Visible = false;
                m_cmd_xoa.Visible = false;
            }
            else
            {
                m_cmd_luu.Visible = false;
                m_cmd_sua.Visible = true;
                m_cmd_them.Visible = true;
                m_cmd_xoa.Visible = true;
            }
        }

        private void load_data_to_tab_doan_phi()
        {
            load_data_to_cb_cua_tien();
            load_data_to_cb_cua_tien_lon_nhat();
            fill_du_lieu_to_tab_doan_phi();
            m_rd_so_tien_change();
            m_rd_ti_le_change();
        }

        private void fill_du_lieu_to_tab_doan_phi()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM DM_DOAN_PHI");
            if (v_ds.Tables[0].Rows.Count>0)
            {
                if (decimal.Parse(v_ds.Tables[0].Rows[0]["TI_LE"].ToString()) != 0)
                {
                    m_rd_ti_le_doan_phi.Checked = true;
                    m_cb_cua_tien.SelectedValue = int.Parse(v_ds.Tables[0].Rows[0]["CUA_TIEN"].ToString());
                    m_cb_cua_tien_lon_nhat.SelectedValue = int.Parse(v_ds.Tables[0].Rows[0]["CUA_TIEN_LON_NHAT"].ToString());
                    m_txt_ti_le_doan_phi.Text = v_ds.Tables[0].Rows[0]["TI_LE"].ToString();
                    m_txt_ti_le_tien_lon_nhat.Text = v_ds.Tables[0].Rows[0]["TI_LE_LON_NHAT_BANG"].ToString();
                }
                else
                {
                    m_rd_so_tien_doan_phi.Checked = true;
                    m_txt_so_tien_doan_phi.Text = v_ds.Tables[0].Rows[0]["SO_TIEN"].ToString();
                }
            }
        }

        private void load_data_to_cb_cua_tien_lon_nhat()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN=24");
            m_cb_cua_tien_lon_nhat.DataSource = v_ds.Tables[0];
            m_cb_cua_tien_lon_nhat.DisplayMember = "TEN";
            m_cb_cua_tien_lon_nhat.ValueMember = "ID";
        }

        private void load_data_to_cb_cua_tien()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN=23");
            m_cb_cua_tien.DataSource = v_ds.Tables[0];
            m_cb_cua_tien.DisplayMember = "TEN";
            m_cb_cua_tien.ValueMember = "ID";
           // .DataSource = v_ds.Tables[0];
        }

        private void m_cmd_luu_Click(object sender, EventArgs e)
        {
            decimal ti_le,cua_tien,ti_le_max,cua_tien_max,so_tien;
            if (m_rd_ti_le_doan_phi.Checked == true)
            {
                 ti_le =decimal.Parse(m_txt_ti_le_doan_phi.Text);
                 cua_tien = (decimal)m_cb_cua_tien.SelectedValue;
                 ti_le_max =decimal.Parse(m_txt_ti_le_tien_lon_nhat.Text);
                 cua_tien_max = (decimal)m_cb_cua_tien_lon_nhat.SelectedValue;
                so_tien=0;
                
            }
            else
            {
                ti_le = 0;
                cua_tien = 790;
                ti_le_max = 0;
                cua_tien_max = 791;
                so_tien = decimal.Parse(m_txt_so_tien_doan_phi.Text);
            }
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_us.UpdateDoanPhi(ti_le, cua_tien, ti_le_max, cua_tien_max, so_tien);
            XtraMessageBox.Show("Lưu thành công!","Thông báo");
        }

        private void m_rd_ti_le_doan_phi_CheckedChanged(object sender, EventArgs e)
        {
            m_rd_ti_le_change();
        }

        private void m_rd_ti_le_change()
        {
            if (m_rd_ti_le_doan_phi.Checked == true)
            {
                m_txt_ti_le_doan_phi.Enabled = true;
                m_cb_cua_tien.Enabled = true;
                m_txt_ti_le_tien_lon_nhat.Enabled = true;
                m_cb_cua_tien_lon_nhat.Enabled = true;
            }
            else
            {
                m_txt_ti_le_doan_phi.Enabled = false;
                m_cb_cua_tien.Enabled = false;
                m_txt_ti_le_tien_lon_nhat.Enabled = false;
                m_cb_cua_tien_lon_nhat.Enabled = false;
            }
        }

        private void m_rd_so_tien_doan_phi_CheckedChanged(object sender, EventArgs e)
        {
            m_rd_so_tien_change();
           
        }

        private void m_rd_so_tien_change()
        {
            if (m_rd_so_tien_doan_phi.Checked == true)
            {
                m_txt_so_tien_doan_phi.Enabled = true;
            }
            else
            {
                m_txt_so_tien_doan_phi.Enabled = false;
            }
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }
    
     
    }
}
