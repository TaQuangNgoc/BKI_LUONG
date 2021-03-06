﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using DevExpress.XtraEditors;

using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using BKI_DichVuMatDat.XtraReport;
using BKI_DichVuMatDat.NghiepVu.Luong;
using DevExpress.XtraSplashScreen;
using BKI_DichVuMatDat.DTO;
using System.IO;
namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f412_rpt_tong_hop_tt_v2 : MaterialSkin.Controls.MaterialForm
    {
        #region Public Interface
        public f412_rpt_tong_hop_tt_v2()
        {
            InitializeComponent();
            m_btn_huy_chot_bang_luong.Enabled = false;
            WinFormControls.formatGridView(m_adv_tong_hop);
        }
        #endregion

        #region Member
        public List<int> m_lst_index = new List<int>();
        #endregion

        #region Private Method
        private decimal lay_thang()
        {
            return Convert.ToDecimal(m_dat_thang.DateTime.Month);
        }
        private decimal lay_nam()
        {
            return Convert.ToDecimal(m_dat_thang.DateTime.Year);
        }
        private void load_data_2_grid()
        {
            try
            {
                WinFormControls.make_stt_indicator(m_adv_tong_hop);
                //.make_stt(m_adv_tong_hop);
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.HienThiBangLuong(v_ds, lay_thang(), lay_nam());
                m_grc_tong_hop.DataSource = v_ds.Tables[0];
                m_grc_tong_hop.RefreshDataSource();

                format_grid_columns_width();
            }
            catch (Exception v_e)
            {
                XtraMessageBox.Show(v_e.Message);
            }           
        }

        private void format_grid_columns_width()
        {
            for (int i = 0; i < m_adv_tong_hop.Columns.Count; i++)
            {
                m_adv_tong_hop.Columns[i].Width = 99;
            }
            m_adv_tong_hop.BandPanelRowHeight = 40;
            m_adv_tong_hop.ColumnPanelRowHeight = 35;
            m_adv_tong_hop.RowHeight = 30;
           
        }
        private void resetText()
        {
            m_lbl_so_luong_nv_tinh_luong.ResetText();
            m_lbl_trang_thai_bang_luong.ResetText();
        }
        private bool isValidInputDate()
        {
          
            if(m_dat_thang.EditValue == null)
            {
                return false;
            }
            return true;
        }
        private void hien_thi_thong_tin_bang_luong()
        {
            if(!isValidInputDate())
            {
                resetText();
                return;
            }
            var v_dto_thong_tin_bang_luong = TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam());

            if(v_dto_thong_tin_bang_luong.CHOT_BANG_LUONG)
            {
                m_lbl_trang_thai_bang_luong.ForeColor = Color.Gray;
                m_lbl_trang_thai_bang_luong.Text = "|Đã chốt, không chỉnh sửa";
                m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Gray;
                m_lbl_so_luong_nv_tinh_luong.Text = v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH.ToString() + " NV ";

                m_cmd_soan_thao_bang_luong.Enabled = false;
                m_btn_bat_tinh_nang_sua.Enabled = false;
                m_btn_bat_tinh_nang_sua.Enabled = false;
                m_cmd_chot_bang_luong.Enabled = false;
                m_btn_luu.Enabled = false;
                m_btn_huy_chot_bang_luong.Enabled = true;
            }
            else
            {
                m_lbl_trang_thai_bang_luong.ForeColor = Color.Green;
                m_lbl_trang_thai_bang_luong.Text = "|Chưa chốt, có thể chỉnh sửa";
                if(v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH == v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH)
                {
                    m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Green;
                }
                if(v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH > v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH)
                {
                    m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Red;
                }
                m_lbl_so_luong_nv_tinh_luong.Text = v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH.ToString() + "/"
                                                    + v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH.ToString() + " NV ";

                m_cmd_soan_thao_bang_luong.Enabled = true;
                m_btn_bat_tinh_nang_sua.Enabled = true;
                m_btn_bat_tinh_nang_sua.Enabled = true;
                m_cmd_chot_bang_luong.Enabled = true;
                m_btn_luu.Enabled = true;
            }
        }
        private bool kiem_tra_da_tinh_het_luong_nhan_vien_chua()
        {
            var v_dto_thong_tin_bang_luong = TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam());
            decimal v_dc_sl_nv_can_tinh = v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH;
            decimal v_dc_sl_nv_da_tinh = v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH;
            if(v_dc_sl_nv_can_tinh <= v_dc_sl_nv_da_tinh)
            {
                return true;
            }
            return false;
        }
        private void chot_bang_luong()
        {
            DialogResult v_dlg_confirm;
            string v_str_text_confirm;

            if(!kiem_tra_da_tinh_het_luong_nhan_vien_chua())
            {
                v_str_text_confirm = "Chưa tính toán xong dữ liệu nhân viên. Bạn có chắc chắn muốn chốt bảng lương tháng " + lay_thang() + " năm " + lay_nam() + "?";
            }
            else
            {
                v_str_text_confirm = "Bạn có chắc chắn muốn chốt bảng lương tháng " + lay_thang() + " năm " + lay_nam() + "?";
            }
            v_dlg_confirm = XtraMessageBox.Show(v_str_text_confirm
                                                            , "XÁC NHẬN"
                                                            , MessageBoxButtons.YesNo
                                                            , MessageBoxIcon.Question);
            if(v_dlg_confirm == System.Windows.Forms.DialogResult.No)
            {
                XtraMessageBox.Show("Bạn đã hủy thao tác!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            TinhLuongQL.Instance.ChotBangLuongThang(lay_thang(), lay_nam());
        }
        private string gen_ten_bang_luong()
        {
            var v_str_op = "BL" + lay_thang() + lay_nam() + "_Bang luong thang " + lay_thang() + "-" + lay_nam() 
                            + "_version" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + "." + DateTime.Now.Hour + "h." + DateTime.Now.Minute + "p";
            return v_str_op;
        }
        #endregion

        #region Event Handle
        private void f413_rpt_tong_hop_thong_tin_Load(object sender, EventArgs e)
        {
            try
            {
                m_prb.Visible = false;
                this.m_panel.Visible = false;
                m_dat_thang.DateTime = DateTime.Now.Date;
                m_cmd_view.Focus();
                hien_thi_thong_tin_bang_luong();
                load_data_2_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_luu_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.FileName = gen_ten_bang_luong();
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    m_adv_tong_hop.OptionsView.ShowViewCaption = true;
                    m_adv_tong_hop.ViewCaption = "Báo cáo bảng lương tháng " + lay_thang() + "/ " + lay_nam();

                    //m_adv_tong_hop.Bands[0].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
                   
                    //m_adv_tong_hop.Bands["gridBand5"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
                    //m_adv_tong_hop.OptionsView.ColumnAutoWidth = true;
                    //m_adv_tong_hop.OptionsView.ColumnAutoWidth = true;
                   
                    //format_grid_columns_width();
                    m_adv_tong_hop.ExportToXls(saveFileDialog1.FileName);
                    XtraMessageBox.Show("Lưu báo cáo thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //var fileInfo = new FileInfo(saveFileDialog1.FileName);
                    //fileInfo.IsReadOnly = true;
                    //fileInfo.OpenRead();
                }

               // ReportHelper.ExportXLS(m_grc_tong_hop, "BÁO CÁO TỔNG HỢP LƯƠNG", gen_ten_bang_luong());
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tinh_lai_nhan_vien_Click(object sender, EventArgs e)
        {
            try
            {
                if(m_adv_tong_hop.FocusedRowHandle < 0)
                {
                    XtraMessageBox.Show("Chọn nhân viên trước để tính lại lương!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam()).CHOT_BANG_LUONG)
                {
                    XtraMessageBox.Show("Bảng lương đã được chốt, bạn không được lại lương cho nhân viên. (Nếu muốn tính lại, cần bỏ chốt bảng lương)!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                decimal v_id_nhan_vien = Convert.ToDecimal(m_adv_tong_hop.GetRowCellValue(m_adv_tong_hop.FocusedRowHandle, "ID_NHAN_VIEN"));
                TinhLuongQL.Instance.ReplaceBanGhiLuongNhanVien(v_id_nhan_vien, lay_thang(), lay_nam());
                load_data_2_grid();

                CHRMCommon.SelectRowInGrid(m_adv_tong_hop, RPT_THONG_TIN_TONG_HOP_V2.ID_NHAN_VIEN, v_id_nhan_vien);
                hien_thi_thong_tin_bang_luong();
                XtraMessageBox.Show("Tính lại lương nhân viên thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_adv_tong_hop_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                m_adv_tong_hop.TopRowIndex += e.Delta > 0 ? -3 : 3;
                ((DXMouseEventArgs)e).Handled = true;
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_soan_thao_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                if(!isValidInputDate())
                {
                    XtraMessageBox.Show("Ngày tháng nhập vào chưa hợp lệ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam()).CHOT_BANG_LUONG)
                {
                    XtraMessageBox.Show("Bảng lương đã được chốt, bạn không được soạn thảo bảng lương. (Nếu muốn soạn thảo lại, cần bỏ chốt bảng lương)!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                f409_rpt_bang_luong_nv_v2 v_frm = new f409_rpt_bang_luong_nv_v2();
                v_frm.Display(lay_thang(), lay_nam());
                hien_thi_thong_tin_bang_luong();
                load_data_2_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_view_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_chot_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                chot_bang_luong();
                hien_thi_thong_tin_bang_luong();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_dat_thang_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                hien_thi_thong_tin_bang_luong();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        private void m_cmd_delete_luong_Click(object sender, EventArgs e)
        {
            try
            {
                if(TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam()).CHOT_BANG_LUONG)
                {
                    XtraMessageBox.Show("Bảng lương đã được chốt, bạn không được xóa lương nhân viên. (Nếu muốn xóa lương, cần bỏ chốt bảng lương)!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                var v_dlg = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa lương của nhân viên này!", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(v_dlg == System.Windows.Forms.DialogResult.Yes)
                {
                    decimal v_id_nhan_vien = Convert.ToDecimal(m_adv_tong_hop.GetRowCellValue(m_adv_tong_hop.FocusedRowHandle, "ID_NHAN_VIEN"));
                    TinhLuongQL.Instance.XoaBanGhiLuongNhanVien(v_id_nhan_vien, lay_thang(), lay_nam());
                    load_data_2_grid();

                    hien_thi_thong_tin_bang_luong();
                    XtraMessageBox.Show("Xóa lương nhân viên thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_btn_huy_chot_bang_luong_Click(object sender, EventArgs e)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_us.HuyChotBangLuong(lay_thang(), lay_nam());
            XtraMessageBox.Show("Hủy chốt thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Enable_button_chot_bang_luong();
        }

        private void Enable_button_chot_bang_luong()
        {
            m_cmd_soan_thao_bang_luong.Enabled = true;
            m_btn_bat_tinh_nang_sua.Enabled = true;
            m_cmd_chot_bang_luong.Enabled = true;
            m_btn_bat_tinh_nang_sua.Enabled = true;
            m_btn_huy_chot_bang_luong.Enabled = false;
            m_btn_luu.Enabled = true;
        }

        private void m_btn_bat_tinh_nang_sua_Click(object sender, EventArgs e)
        {
            m_adv_tong_hop.OptionsBehavior.Editable = true;
            m_btn_bat_tinh_nang_sua.Appearance.BackColor = Color.Gray;
            m_btn_bat_tinh_nang_sua.Appearance.ForeColor = Color.White;
            m_btn_luu.Enabled = true;
        }

        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                luu_du_lieu_thay_doi();
                 XtraMessageBox.Show("Lưu thành công thay đổi cho bảng lương tháng "+ lay_thang()+"/"+ lay_nam()+"!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Vui lòng nhập số, không nhập chữ, và các kí tự khác! ","THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void luu_du_lieu_thay_doi()
        {
            foreach (var item in m_lst_index)
            {
                DTO_BANG_LUONG_V2 v_dto_bang_luong_v2 = new DTO_BANG_LUONG_V2();
                DataRow v_dr = m_adv_tong_hop.GetDataRow(item);
                v_dto_bang_luong_v2= TinhLuongQL.Instance.transfer_data_row_db_luong_2_object(decimal.Parse(v_dr["ID"].ToString()), v_dr, lay_thang(), lay_nam());
                TinhLuongQL.Instance.ReplaceBanGhiLuongNhanVien(v_dto_bang_luong_v2);
               
            }
        }

       
        private void m_adv_tong_hop_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
            if (!m_lst_index.Exists(x => x == e.RowHandle))
            {
                m_lst_index.Add(e.RowHandle);
            }
        

        }

        
    }
}
