using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_DichVuMatDat;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.US;
using DevExpress.Spreadsheet;
using DevExpress.XtraSplashScreen;
using DevExpress;
using DevComponents;
using DevExpress.XtraEditors;
using IP.Core.IPSystemAdmin;
using BKI_DichVuMatDat.DTO;
using BKI_DichVuMatDat.CONFIRM;
using BKI_DichVuMatDat.COMMON;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using BKI_DichVuMatDat.NghiepVu.Luong;
using System.Threading;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class f409_rpt_bang_luong_nv_v2 : MaterialSkin.Controls.MaterialForm
    {
        //Field & Property
        BindingList<DTO_BANG_LUONG_V2> m_lst_luong_v2 = new BindingList<DTO_BANG_LUONG_V2>();
        BindingList<string> m_lst_nhan_vien_khong_ton_tai = new BindingList<string>();
        ENUM_CONFIRM_TINH_BANG_LUONG v_dlg_confirm = ENUM_CONFIRM_TINH_BANG_LUONG.NONE;

        #region Public Interface
        ~f409_rpt_bang_luong_nv_v2()
        {
            Dispose(true);
        }
        public f409_rpt_bang_luong_nv_v2()
        {
            InitializeComponent();
            format_controls();
        }
        public void Display()
        {
            this.m_grv_main.BestFitColumns(true);
            this.ShowDialog();
        }
        public void Display(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            this.m_grv_main.BestFitColumns(true);
            m_txt_thang.Text = ip_dc_thang.ToString();
            m_txt_nam.Text = ip_dc_nam.ToString();
            m_txt_thang.Enabled = false;
            m_txt_nam.Enabled = false;
         //   this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.ShowDialog();
        }
        #endregion

        #region Event Handle
        private void set_define_events()
        {
            FormClosed += f409_rpt_bang_luong_FormClosed;
            Load += f409_rpt_bang_luong_Load;         
            m_txt_thang.Leave += m_txt_thang_Leave;
            m_txt_nam.Leave += m_txt_nam_Leave;
          //  m_cmd_import_excel.Click += m_cmd_import_excel_Click;
          
            m_grv_main.MouseWheel += m_grv_main_MouseWheel;          
            format_grid();
        }

        private void format_grid()
        {
            m_grv_main.ColumnPanelRowHeight = 35;
            m_grv_main.RowHeight = 30;
        }

        void m_cmd_kiem_tra_du_lieu_Click(object sender, EventArgs e)
        {
            try
            {
                if(TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam()).CHOT_BANG_LUONG)
                {
                    XtraMessageBox.Show("Bảng lương đã được chốt, bạn không được thực hiện thao tác này. (Nếu muốn thực hiện, cần bỏ chốt bảng lương)!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                ra_soat_thong_tin_du_lieu_tinh_luong();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_grv_main_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                m_grv_main.TopRowIndex += e.Delta > 0 ? -3 : 3;
                ((DXMouseEventArgs)e).Handled = true;
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_export_excel_Click(object sender, EventArgs e)
        {
            try
            {
                xuat_excel_bang_luong();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        //void m_cmd_import_excel_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if(TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam()).CHOT_BANG_LUONG)
        //        {
        //            XtraMessageBox.Show("Bảng lương đã được chốt, bạn không được thực hiện thao tác này. (Nếu muốn thực hiện, cần bỏ chốt bảng lương)!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //            return;
        //        }
        //        load_data_excel_to_grid(WinFormControls.openFileDialog());
        //    }
        //    catch(Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        void f409_rpt_bang_luong_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Dispose();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f409_rpt_bang_luong_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        //Nghiep vu tinh luong
        void m_cmd_luu_du_lieu_Click(object sender, EventArgs e)
        {
            try
            {
                if(TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam()).CHOT_BANG_LUONG)
                {
                    XtraMessageBox.Show("Bảng lương đã được chốt, bạn không được thực hiện thao tác này. (Nếu muốn thực hiện, cần bỏ chốt bảng lương)!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                start_luu_bang_luong_process();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_tinh_bang_luong_Click(object sender, EventArgs e)
        {
            try
            {
                if(TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam()).CHOT_BANG_LUONG)
                {
                    XtraMessageBox.Show("Bảng lương đã được chốt, bạn không được thực hiện thao tác này. (Nếu muốn thực hiện, cần bỏ chốt bảng lương)!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if(m_bgwk.IsBusy)
                {
                    XtraMessageBox.Show("Chức năng đang thực hiện tính toán dữ liệu lương rồi, bạn đợi chút", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if(m_grc_main.DataSource != null && m_grv_main.RowCount != 0)
                {
                    var v_dlg_confirm = XtraMessageBox.Show("Lưới đang có dữ liệu. Việc tính này sẽ xóa dữ liệu đã tính trên lưới. Bạn có muốn tiếp tục?"
                                                                , "XÁC NHẬN"
                                                                , MessageBoxButtons.YesNo
                                                                , MessageBoxIcon.Question);
                    if(v_dlg_confirm == System.Windows.Forms.DialogResult.No)
                    {
                        XtraMessageBox.Show("Bạn đã hủy thao tác", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                clear_grid();
                hide_grid();
                
                Thread.Sleep(1000);
                start_tinh_bang_luong_process();
               
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_bgwk_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            try
            {

                if(!kiem_tra_tinh_hop_le_du_lieu_tren_giao_dien())
                {
                    worker.CancelAsync();
                    e.Cancel = true;
                    return;
                }
                var v_ds_danh_sach_nhan_vien = TinhLuongQL.Instance.LayDanhSachNhanVienCanTinhLuong(v_dlg_confirm, lay_thang(), lay_nam());
                tinh_bang_luong_tu_dong(v_ds_danh_sach_nhan_vien);
                
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    worker.CancelAsync();
                }
            }
            catch(Exception v_e)
            {
                worker.CancelAsync();
                e.Cancel = true;
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_bgwk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                var worker = sender as BackgroundWorker;
                if((e.Cancelled == true))
                {
                    m_prb.Text = "Thao tác bị hoãn!";
                    hide_progress_bar();
                    hide_grid();
                    clear_grid();
                    return;
                }

                else if(!(e.Error == null))
                {
                    m_prb.Text = ("Lỗi: " + e.Error.Message);
                    hide_progress_bar();
                    hide_grid();
                    clear_grid();
                    return;
                }
                else
                {
                    m_prb.Text = "Đã xong!";
                }
                hide_progress_bar();
                load_data_2_grid();
                hien_thi_thong_tin_bang_luong();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_bgwk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                //this.m_prb.Text = (e.ProgressPercentage.ToString() + "%");
              this.m_prb.EditValue = e.ProgressPercentage;
            }
            catch(Exception)
            {
            }

        }


        //Other
        void m_txt_nam_Leave(object sender, EventArgs e)
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
        void m_txt_thang_Leave(object sender, EventArgs e)
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

        private void m_cmd_xem_bang_luong_Click(object sender, EventArgs e)
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
        private void m_grv_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            try
            {
                var v_dr_Focused = m_grv_main.GetDataRow(m_grv_main.FocusedRowHandle);
                var v_obj_oldValue = m_grv_main.GetRowCellDisplayText(m_grv_main.FocusedRowHandle, m_grv_main.FocusedColumn);
                if(XtraMessageBox.Show(String.Format("Bạn có chắc chắn muốn thay đổi dữ liệu từ \"{0}\" thành \"{1}\"? " +
                                                        "Việc này sẽ thay đổi giá trị đã tính toán trước đó.", v_obj_oldValue, e.Value)
                                                        , "XÁC NHẬN LẠI SỰ THAY ĐỔI"
                                                        , MessageBoxButtons.YesNo
                                                        , MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Valid = false;
                }
                else
                {
                    e.Valid = true;
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
        
        #region Private Methods
        //Setup Form
        private void format_controls()
        {
            WinFormControls.formatGridView(m_grv_main);
            set_define_events();
        }
        private void set_initial_form_load()
        {
            hide_progress_bar();
            hien_thi_thong_tin_bang_luong();
            hide_grid();
        }

        //Action giao dien
        private void hide_progress_bar()
        {
            m_prb.Visible = false;
        }
        private void show_progress_bar()
        {
            m_prb.Visible = true;
            m_prb.BringToFront();
        }
        private void show_grid()
        {
            m_grc_main.Visible = true;
        }
        private void hide_grid()
        {
            m_grc_main.Visible = false;
        }
        private void clear_grid()
        {
            m_lst_luong_v2 = new BindingList<DTO_BANG_LUONG_V2>();
            m_lst_nhan_vien_khong_ton_tai = new BindingList<string>();
            m_grc_main.DataSource = null;
            m_grc_main.RefreshDataSource();
        }

        //Load data
        private decimal lay_thang()
        {
            return Convert.ToDecimal(m_txt_thang.Text.Trim());
        }
        private decimal lay_nam()
        {
            return Convert.ToDecimal(m_txt_nam.Text.Trim());
        }

        private void load_data_2_grid()
        {
            m_grc_main.DataSource = null;
            m_grc_main.DataSource = m_lst_luong_v2;
            show_grid();
            format_grid_columns_width();
            WinFormControls.make_stt_indicator(m_grv_main);
        }

        private void format_grid_columns_width()
        {
            for (int i = 0; i < m_grv_main.Columns.Count; i++)
            {
                m_grv_main.Columns[i].Width = 99;
            }
            m_grv_main.BandPanelRowHeight = 40;
        }
        private void hien_thi_thong_tin_bang_luong()
        {
            if(m_txt_thang.Text.Trim() == "" || m_txt_nam.Text.Trim() == "")
            {
                return;
            }
            var v_dto_thong_tin_bang_luong = TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam());

            if(v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH == v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH)
            {
                m_lbl_thong_bao.Text = "Bảng lương trong Phần mềm đã có lương của ";
                m_lbl_thong_bao.ForeColor = Color.Green;
                m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Green;
            }
            if(v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH > v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH)
            {
                m_lbl_thong_bao.Text = "Bảng lương trong Phần mềm đã có lương của ";
                m_lbl_thong_bao.ForeColor = Color.Red;
                m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Red;
            }

            if(v_dto_thong_tin_bang_luong.CHOT_BANG_LUONG)
            {
                m_lbl_trang_thai_bang_luong.ForeColor = Color.Gray;
                m_lbl_trang_thai_bang_luong.Text = "|Đã chốt, không chỉnh sửa";
                m_lbl_so_luong_nv_tinh_luong.Text = v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH.ToString();
                m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Gray;
            }

            else
            {
                m_lbl_so_luong_nv_tinh_luong.ForeColor = Color.Gray;
                m_lbl_so_luong_nv_tinh_luong.Text = v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_DA_TINH.ToString() + "/"
                                                    + v_dto_thong_tin_bang_luong.SO_LUONG_NHAN_VIEN_CAN_TINH.ToString() + " (nhân viên)";
                m_lbl_trang_thai_bang_luong.ForeColor = Color.Green;
                m_lbl_trang_thai_bang_luong.Text = "|Chưa chốt, có thể chỉnh sửa";
            }
        }

        //Check data

        private bool kiem_tra_tinh_hop_le_du_lieu_tren_giao_dien()
        {
            if(m_txt_thang.Text.Trim() == null || m_txt_nam.Text.Trim() == null)
            {
                XtraMessageBox.Show("Bạn nhập tháng & năm trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void ra_soat_thong_tin_du_lieu_tinh_luong()
        {
            F401_he_so_bao_cao_luong v_frm = new F401_he_so_bao_cao_luong();
            v_frm.hien_thi_ra_soat_tinh_luong(lay_thang(), lay_nam());
        }

        //Action
        private void xoa_bang_luong_thang()
        {
            TinhLuongQL.Instance.XoaToanBoBangLuong(lay_thang(), lay_nam());
        }


        //Process tinh bang luong
        private void start_tinh_bang_luong_process()
        {

             v_dlg_confirm = confirm_cach_tinh_bang_luong_tu_nguoi_dung();
            if(v_dlg_confirm == ENUM_CONFIRM_TINH_BANG_LUONG.NONE)
            {
               // m_bgwk.CancelAsync();
                return;
            }
            else
            {
                show_progress_bar();
                m_bgwk.RunWorkerAsync();
            }
           
           
        }
        private ENUM_CONFIRM_TINH_BANG_LUONG confirm_cach_tinh_bang_luong_tu_nguoi_dung()
        {
            msg001_confirm_tinh_bang_luong v_msg_confirm = new msg001_confirm_tinh_bang_luong();
            ENUM_CONFIRM_TINH_BANG_LUONG v_dlg_confirm;
            var v_dto_thong_tin_bang_luong = TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam());
            if(v_dto_thong_tin_bang_luong.CO_DU_LIEU_LUONG)
            {
                v_dlg_confirm = v_msg_confirm.display();
            }
            else
            {
                v_dlg_confirm = ENUM_CONFIRM_TINH_BANG_LUONG.TINH_LAI_TOAN_BO;
            }

            return v_dlg_confirm;
        }


        private void tinh_bang_luong_tu_dong(DataSet ip_ds_danh_sach_nv)
        {

            int v_i_so_luong_nv = ip_ds_danh_sach_nv.Tables[0].Rows.Count;
            for(int i = 0; i < v_i_so_luong_nv; i++)
            {
                DataRow v_dr_nv = ip_ds_danh_sach_nv.Tables[0].Rows[i];
                decimal v_dc_id_nhan_vien = Convert.ToDecimal(v_dr_nv[0]);
                DTO_BANG_LUONG_V2 v_dto_luong = TinhLuongQL.Instance.TinhToanBangLuongNhanVien(v_dc_id_nhan_vien, lay_thang(), lay_nam());
                m_lst_luong_v2.Add(v_dto_luong);
                m_bgwk.ReportProgress((i + 1) * 100 / ip_ds_danh_sach_nv.Tables[0].Rows.Count);
            }
        }



        //Process luu bang luong
        private void start_luu_bang_luong_process()
        {
            if(m_bgwk.IsBusy)
            {
                XtraMessageBox.Show("Chức năng đang thực hiện tính toán dữ liệu lương rồi, bạn đợi chút", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var v_dto_thong_tin_bang_luong = TinhLuongQL.Instance.LayThongTinBangLuong(lay_thang(), lay_nam());
            msg002_confirm_luu_du_lieu_bang_luong v_msg_confirm;
            ENUM_CONFIRM_LUU_BANG_LUONG v_dlg_confirm_save;

            if(v_dto_thong_tin_bang_luong.CHOT_BANG_LUONG)
            {
                var v_yn_tiep_tuc = XtraMessageBox.Show("Bảng lương đã được chốt! Bạn có muốn chỉnh sửa dữ liệu lương không? (Việc này có thể dẫn đến việc sai lệch với dữ liệu lương đã chốt)", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if(v_yn_tiep_tuc == System.Windows.Forms.DialogResult.No)
                {
                    XtraMessageBox.Show("Bạn đã hủy thao tác!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    XtraMessageBox.Show("Bạn đã chọn việc sửa lại bảng lương sau khi đã chốt!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if(v_dto_thong_tin_bang_luong.CO_DU_LIEU_LUONG)
            {
                v_msg_confirm = new msg002_confirm_luu_du_lieu_bang_luong();
                v_dlg_confirm_save = v_msg_confirm.Display();
            }
            else
            {
                v_dlg_confirm_save = ENUM_CONFIRM_LUU_BANG_LUONG.TINH_LAI_TOAN_BO;
            }

            try
            {

                //progressBarControl1.Visible = true;
                //progressBarControl1.Show();
                save_data(v_dlg_confirm_save);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                //progressBarControl1.Visible = false;
                //progressBarControl1.Hide();

            }

        }
      
     
        private void save_data(ENUM_CONFIRM_LUU_BANG_LUONG ip_confirm_save)
        {
            SplashScreenManager.ShowForm(this, typeof(SplashScreen1), true, true, false);
            string v_str_msg = "";
            try
            {
                if(ip_confirm_save == ENUM_CONFIRM_LUU_BANG_LUONG.NONE)
                {
                    XtraMessageBox.Show("Bạn đã hủy thao tác!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                //US_RPT_LUONG_V2 v_us_rpt_luong_v2 = new US_RPT_LUONG_V2();
                DTO_BANG_LUONG_V2 v_dto_bang_luong_v2 = new DTO_BANG_LUONG_V2();

                var v_i_row_count = m_grv_main.RowCount;
                if(ip_confirm_save == ENUM_CONFIRM_LUU_BANG_LUONG.NONE)
                {
                    XtraMessageBox.Show("Bảng lương chưa được lưu!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(ip_confirm_save == ENUM_CONFIRM_LUU_BANG_LUONG.TINH_LAI_TOAN_BO)
                {
                    TinhLuongQL.Instance.XoaToanBoBangLuong(lay_thang(), lay_nam());
                }

                int v_i_so_luong_ghi_moi = 0;
                int v_i_so_luong_ghi_de = 0;
                for(int v_i_row = 0; v_i_row < v_i_row_count; v_i_row++)
                {
                    v_dto_bang_luong_v2 = (DTO_BANG_LUONG_V2)m_grv_main.GetRow(v_i_row);
                  //  v_us_rpt_luong_v2 = transfer_dto_2_us_object(v_dto_bang_luong_v2);

                    var v_bol_nv_co_trong_bang_luong_chua = TinhLuongQL.Instance.KiemTraNhanVienCoTrongBangLuongChua(v_dto_bang_luong_v2);
                    switch(ip_confirm_save)
                    {
                        case ENUM_CONFIRM_LUU_BANG_LUONG.TINH_LAI_TOAN_BO:
                            TinhLuongQL.Instance.InsertBanGhiLuongNhanVien(v_dto_bang_luong_v2);
                            v_i_so_luong_ghi_moi = v_i_so_luong_ghi_moi + 1;
                            break;
                        case ENUM_CONFIRM_LUU_BANG_LUONG.CHUA_CO_THI_GHI_MOI_DA_CO_THI_KHONG_LAM_GI:
                            if(!v_bol_nv_co_trong_bang_luong_chua)
                            {
                                TinhLuongQL.Instance.InsertBanGhiLuongNhanVien(v_dto_bang_luong_v2);
                                v_i_so_luong_ghi_moi = v_i_so_luong_ghi_moi + 1;
                            }
                            break;
                        case ENUM_CONFIRM_LUU_BANG_LUONG.CHUA_CO_THI_GHI_MOI_DA_CO_THI_GHI_DE:
                            if(!v_bol_nv_co_trong_bang_luong_chua)
                            {
                                TinhLuongQL.Instance.InsertBanGhiLuongNhanVien(v_dto_bang_luong_v2);
                                v_i_so_luong_ghi_moi = v_i_so_luong_ghi_moi + 1;
                            }
                            else
                            {
                                TinhLuongQL.Instance.ReplaceBanGhiLuongNhanVien(v_dto_bang_luong_v2);
                                v_i_so_luong_ghi_de = v_i_so_luong_ghi_de + 1;
                            }
                            break;
                        case ENUM_CONFIRM_LUU_BANG_LUONG.CHUA_CO_THI_KHONG_LAM_GI_DA_CO_THI_GHI_DE:
                            if(v_bol_nv_co_trong_bang_luong_chua)
                            {
                                TinhLuongQL.Instance.ReplaceBanGhiLuongNhanVien(v_dto_bang_luong_v2);
                                v_i_so_luong_ghi_de = v_i_so_luong_ghi_de + 1;
                            }
                            break;
                        default:
                            throw new Exception("Chưa gán giá trị cho ENUM_CONFIRM_LUU_BANG_LUONG!");

                    }
                    //m_prb.EditValue = (int)((decimal)v_i_row / (decimal)v_i_row_count * 100);
                    SplashScreenManager.Default.SendCommand(SplashScreen1.SplashScreenCommand.SetProgress, (int)((decimal)v_i_row / (decimal)v_i_row_count * 100));
                    //progressBarControl1.EditValue = (int)((decimal)v_i_row / (decimal)v_i_row_count * 100);
                }
                v_str_msg = "Lưu dữ liệu lương thành công. Có " + v_i_so_luong_ghi_moi + " bản ghi lương nhân viên mới, có " + v_i_so_luong_ghi_de + " bản ghi lương nhân viên ghi đè!";
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }

            XtraMessageBox.Show(v_str_msg, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hien_thi_thong_tin_bang_luong();
        }

        private void xuat_excel_bang_luong()
        {
            string v_str_file_name = "SOAN_THAO_BL" + lay_thang() + lay_nam() + "_Bang luong dang soan thao thang " + lay_thang() + "-" + lay_nam() + CHRMCommon.gen_version();
            CHRMCommon.ExportExcelWithFileName(m_grv_main, v_str_file_name);
        }
        #endregion

        private void m_btn_khong_tinh_luong_Click(object sender, EventArgs e)
        {
            BKI_DichVuMatDat.BaoCao.Luong.NHAN_VIEN_KHONG_CHAM_CONG_THANG v_f = new Luong.NHAN_VIEN_KHONG_CHAM_CONG_THANG();
            v_f.hienThiDanhSach(lay_thang(), lay_nam());
        }

        private void m_btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        

       
    }
}
