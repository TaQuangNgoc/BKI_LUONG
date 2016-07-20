using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using IP.Core.IPCommon;
using DevExpress.XtraEditors;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.DTO;
using BKI_DichVuMatDat.NghiepVu.Luong;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class CAC_LOAI_TIEN_KHAC : Form
    {
        bool phai_dong_bao_hiem = false;
        bool giam_tru_thue = false;
        ENUM_CONFIRM_XOA_DU_LIEU_CU v_enum_xoa_du_lieu_cu = new ENUM_CONFIRM_XOA_DU_LIEU_CU();
        
        #region Public Interface
        public CAC_LOAI_TIEN_KHAC()
        {
            InitializeComponent();
            this.m_grv.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv.OptionsPrint.AutoWidth = false;
            fill_data_to_sle();
            set_initial_form_load();
        }

        private void fill_data_to_sle()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN=22");
            m_sle_loai_tien.Properties.DataSource = v_ds.Tables[0];
            m_sle_loai_tien.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }
         private void set_initial_form_load()
        {
            m_dat_chon_thang.EditValue = DateTime.Now;
           // set_trang_thai_cham_cong();
            set_define_events();
        }
        #endregion

        #region Members
      
        DataSet m_ds_nhan_vien = new DataSet();
       
        public enum Loi { 
            DuplicateMaNV,
            TrongMaNV,
            MaNVKhongTonTai,
            SoTienSai,
            SaiNam,
            SaiThang
        }
        #endregion

        #region Private Methods

        #region Tao file excel mau
        private void tao_file_mau(string ip_file_name)
        {
            m_grv.Columns.Clear();
            string targetPath = WinFormControls.saveFileDialog(ip_file_name);
            if (targetPath != "")
            {
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_ds.Tables[0].Columns.Add("MA_NV");
                v_ds.Tables[0].Columns.Add("HO_DEM");
                v_ds.Tables[0].Columns.Add("TEN");
                v_ds.Tables[0].Columns.Add("THANG");
                v_ds.Tables[0].Columns.Add("NAM");
                v_ds.Tables[0].Columns.Add("SO_TIEN");           
                m_grc.DataSource = v_ds.Tables[0];
                format_gridview();
                SaveXLSX(ip_file_name, targetPath);
            }           
        }

        private void SaveXLSX(string ip_file_name, string targetPath)
        {
            m_grv.ExportToXls(targetPath);
            XtraMessageBox.Show("Đã lưu file mẫu tại " + targetPath + ".\nFile sẽ tự động mở ngay sau đây!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var process = new System.Diagnostics.Process();
            process.StartInfo.FileName = targetPath;
            process.StartInfo.Verb = "Open";
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            process.Start();
        }
        #endregion

        #region Load excel to grid
        private void load_data_2_grid(string ip_path)
        {        
            splashScreenManager1.ShowWaitForm();
            m_grv.Columns.Clear();
            WinFormControls.load_xls_to_gridview_co_ghi_chu(ip_path, m_grc);      
            m_grv.Columns["Ghi chú"].Visible = false;
            WinFormControls.make_stt_indicator(m_grv);
            for (int i = 0; i < 3; i++)
            {
                m_grv.Columns[i].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            }      
            format_gridview();
            splashScreenManager1.CloseWaitForm();
        }

        private void format_gridview()
        {
            m_grv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
          //  m_grv.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            
            for (int i = 0; i < m_grv.Columns.Count; i++)
            {
                m_grv.Columns[i].Width = 120;
               // m_grv.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            m_grv.Columns["SO_TIEN"].DisplayFormat.FormatString = "n0";
            m_grv.Columns["SO_TIEN"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            m_grv.Columns["MA_NV"].Caption = "Mã nhân viên";
            m_grv.Columns["HO_DEM"].Caption = "Họ đệm";
            m_grv.Columns["TEN"].Caption = "Tên";
            m_grv.Columns["SO_TIEN"].Caption = "Số tiền";
            
        }
        #endregion

        #region Lay du lieu tu db
        private void LayDuLieuNhanVien()
        {  
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            m_ds_nhan_vien = new DS_DM_NHAN_VIEN();
            v_us.FillDatasetWithQuery(m_ds_nhan_vien, "SELECT * FROM DM_NHAN_VIEN ");
        }

      
        private decimal get_nhan_vien_by_ma_nv(string ip_ma_nhan_vien)
        {
            EnumerableRowCollection<DataRow> res = from row in m_ds_nhan_vien.Tables[0].AsEnumerable()
                                                   where row.Field<string>(DM_NHAN_VIEN.MA_NV) == ip_ma_nhan_vien
                                                   select row;

            return CIPConvert.ToDecimal(res.First()[DM_NHAN_VIEN.ID].ToString());
        }

        #endregion

        #region Kiem tra du lieu tren grid
        private bool check_cham_cong_hop_le()
        {
            if (!checkBangChamCong())
                return false;
               
            return true;
        }

        private bool checkBangChamCong()
        {
            bool trang_thai = true;
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                var v_dr = m_grv.GetDataRow(i);
                check_ma_nv_duplicate(v_dr, ref trang_thai);
                check_ma_nv_trong(v_dr, ref trang_thai);
                check_ma_nv_ko_ton_tai(v_dr, ref trang_thai);
                check_thang_nam_trong_file(v_dr, ref trang_thai);
                check_so_tien(v_dr, ref trang_thai);
            }
            if (trang_thai == false)
            {
                m_grv.Columns["Ghi chú"].Visible = true;
                m_grc.DataSource = m_grv;
                m_grv.Columns["Ghi chú"].Width = 200;
                XtraMessageBox.Show("Thông tin up lên chưa chính xác. \n Vui lòng xem cột ghi chú(cột cuối cùng để điều chỉnh lại thông tin trước khi nhập!","Thông báo");
                
            }
            return trang_thai;
          
        }

        private void check_thang_nam_trong_file(DataRow v_dr, ref bool trang_thai)
        {
            if (m_dat_chon_thang.DateTime.Month.ToString() != v_dr["THANG"].ToString())
            {
                v_dr["Ghi chú"] += get_text_by_enum(Loi.SaiThang);
            }
            if (m_dat_chon_thang.DateTime.Year.ToString() != v_dr["NAM"].ToString())
            {
                v_dr["Ghi chú"] += get_text_by_enum(Loi.SaiNam);
            }
        }

        private void check_so_tien(DataRow v_dr, ref bool trang_thai)
        {
            decimal result;
            if(! decimal.TryParse(v_dr["SO_TIEN"].ToString(), out result))
            {
                v_dr["Ghi chú"] += get_text_by_enum(Loi.SoTienSai);
            }
         }
         
        private void check_ma_nv_ko_ton_tai(DataRow v_dr, ref bool trang_thai)
        {
            LayDuLieuNhanVien();
            DataRow[] v_dr_1_nv = m_ds_nhan_vien.Tables[0].Select("MA_NV = '" + v_dr[0].ToString() + "'");
            if (v_dr_1_nv.Count() == 0)
            {
                trang_thai = false;
                v_dr["Ghi chú"]+=  get_text_by_enum(Loi.MaNVKhongTonTai);
               
            }
        }

        private void check_ma_nv_trong(DataRow v_dr, ref bool trang_thai)
        {
            if (v_dr["MA_NV"].ToString() == "")
            {
                trang_thai = false;
                v_dr["Ghi chú"] += get_text_by_enum(Loi.TrongMaNV);
            }
        }

        private void check_ma_nv_duplicate(DataRow v_dr, ref bool trang_thai)
        {
            DataTable v_dt = new DataTable();
            v_dt.Columns.Add();
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                var v_drow = m_grv.GetDataRow(i);
                v_dt.Rows.Add(v_drow[0]);
            }
            int v_count = v_dt.AsEnumerable().Where(x => x["Column1"].ToString() == v_dr["MA_NV"].ToString()).ToList().Count;
            if (v_count > 1)
            {
                trang_thai = false;
                v_dr["Ghi chú"] += get_text_by_enum(Loi.DuplicateMaNV);
                string a = v_dr["Ghi chú"].ToString();
            }
        }

        private string get_text_by_enum(Loi loi)
        {
            if (loi == Loi.DuplicateMaNV)
            {
                return "Trùng mã nhân viên; ";
            }
            if (loi == Loi.TrongMaNV)
            {
                return "Trống mã nhân viên; ";
            }
            if (loi == Loi.MaNVKhongTonTai)
            {
                return "Mã nhân viên không tồn tại hoặc nhân viên này không có hình thức tính lương theo thời gian; ";
            }
            if (loi == Loi.SaiThang)
            {
                return "Tháng bạn chọn và năm ở file excel khác nhau; ";
            }
            if (loi == Loi.SaiNam)
            {
                return "Năm bạn chọn và năm ở file excel khác nhau; ";
            }
            if (loi == Loi.SoTienSai)
            {
                return "Số tiền phải ở dạng số; ";
            }

            
            else return "";
        }
        #endregion

        #region Luu du lieu vao db

        private void m_bgwk_DoWork(object sender, DoWorkEventArgs e)
        {
            if (v_enum_xoa_du_lieu_cu == ENUM_CONFIRM_XOA_DU_LIEU_CU.XOA_CU)
            {
                xoa_du_lieu_cu_loai_tien_khac();
            }
            BackgroundWorker worker = sender as BackgroundWorker;
           
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                luuChamCong(m_grv.GetDataRow(i));
                 worker.ReportProgress((i + 1) * 100 / m_grv.RowCount);
            }
          
        }

        private void xoa_du_lieu_cu_loai_tien_khac()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds,"DELETE FROM GD_CAC_LOAI_TIEN_KHAC WHERE ID_LOAI_TIEN_KHAC="+ m_sle_loai_tien.EditValue.ToString()+ " AND THANG="+laythang()+ " AND NAM="+ laynam() );
        }

        private void m_bgwk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.m_prb.EditValue = e.ProgressPercentage;
        }

        private void m_bgwk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.m_prb.Visible = false;
            this.m_pn.Visible = false;
            this.m_cmd_nhap_cham_cong.Text = "Lưu chấm công";
            XtraMessageBox.Show("Lưu thành công!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            //m_grc.DataSource = null; 
            
        }

        private void luuChamCong(DataRow ip_dataRow)
        {
            insert_gd_so_tien_khac(ip_dataRow);        
        }

        private void insert_gd_so_tien_khac(DataRow v_dr)
        {
            US_GD_CAC_LOAI_TIEN_KHAC v_us = new US_GD_CAC_LOAI_TIEN_KHAC();
            v_us.dcID_LOAI_TIEN_KHAC = decimal.Parse(m_sle_loai_tien.EditValue.ToString());
            v_us.dcID_NHAN_VIEN = get_nhan_vien_by_ma_nv(v_dr["MA_NV"].ToString());
            v_us.dcTHANG = decimal.Parse(v_dr["THANG"].ToString());
            v_us.dcNAM = decimal.Parse(v_dr["NAM"].ToString());
            v_us.dcSO_TIEN = decimal.Parse(v_dr["SO_TIEN"].ToString());
            v_us.strLI_DO = "";
            v_us.strDA_XOA = "N";
            v_us.datNGAY_NHAP = DateTime.Now;
            if (phai_dong_bao_hiem == true)
                v_us.strDONG_BAO_HIEM_YN = "Y";
            else
            {
                v_us.strDONG_BAO_HIEM_YN = "N";
            }
            if (giam_tru_thue==true)
            {
                v_us.strGIAM_TRU_THUE_YN = "Y";
            }
            else
            {
                v_us.strGIAM_TRU_THUE_YN = "N";
            }
            v_us.Insert();

        }
  
        #endregion

        #endregion

        #region Events Handle
        private void set_define_events()
        {
            m_cmd_mo_file_mau.Click += m_cmd_mo_file_mau_Click;
            m_cmd_chon_du_lieu.Click += m_cmd_chon_du_lieu_Click;
            m_cmd_nhap_cham_cong.Click += m_cmd_nhap_cham_cong_Click;
            this.Load += F696_Cham_cong_xls_Load;
            m_btn_xoa_dong.Enabled = false;
            
        }

     private void F696_Cham_cong_xls_Load(object sender, EventArgs e)
        {
            try
            {
                //set_trang_thai_cham_cong();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

     public decimal laythang()
     {
         return decimal.Parse(m_dat_chon_thang.DateTime.Month.ToString());
     }

     public decimal laynam()
     {
         return decimal.Parse(m_dat_chon_thang.DateTime.Year.ToString());
     }

        private void m_cmd_nhap_cham_cong_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (m_dat_chon_thang.EditValue == null)
                {
                    CHRM_BaseMessages.MsgBox_Error("Chưa chọn tháng và năm chấm công");
                    return;
                }
                string string_thang = m_grv.Columns[3].Name.ToString().Substring(6,2);
               
                if (m_sle_loai_tien.Text=="")
                {
                    XtraMessageBox.Show("Bạn chưa chọn loại làm thêm. /nVui lòng kiểm tra lại thông tin!", "Thông báo");
                    return;
                }

                else if (check_bang_luong_da_chot(decimal.Parse(m_dat_chon_thang.DateTime.Month.ToString()),decimal.Parse(m_dat_chon_thang.DateTime.Year.ToString())))
                {
                    CHRM_BaseMessages.MsgBox_Error("Tháng đã chốt bảng lương. Vui lòng không cập nhật");
                }
                else if (m_bgwk.IsBusy)
                    m_bgwk.CancelAsync();
                else if (check_cham_cong_hop_le())
                {                 
                    THONG_TIN_BO_SUNG_CAC_KHOAN_TIEN_KHAC v_f = new THONG_TIN_BO_SUNG_CAC_KHOAN_TIEN_KHAC();
                    v_f.displayForBoSungThongTin(ref phai_dong_bao_hiem, giam_tru_thue);
                    
                    BKI_DichVuMatDat.CONFIRM.confirm_cac_loai_tien_khac v_k = new CONFIRM.confirm_cac_loai_tien_khac();
                    v_enum_xoa_du_lieu_cu = v_k.Display();
                    this.m_pn.Visible = true;
                    this.m_prb.Visible = true;
                    this.m_cmd_nhap_cham_cong.Text = "Đang lưu chấm công ...";
                    this.m_cmd_nhap_cham_cong.Enabled = false;
                    m_bgwk.RunWorkerAsync();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        public enum ENUM_CONFIRM_XOA_DU_LIEU_CU
        {
            XOA_CU = 1,
            KHONG_XOA_CU = 2
            
        }

        private bool check_bang_luong_da_chot(decimal thang, decimal nam)
        {
           // US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            US_RPT_CHOT_BANG_LUONG v_us = new US_RPT_CHOT_BANG_LUONG();
            if (v_us.IsLockBangLuong(thang, nam))
                return true;
            return false;
        }

        private void m_cmd_chon_du_lieu_Click(object sender, EventArgs e)
        {
            try
            {
                string ip_path = WinFormControls.openFileDialog();
                if (ip_path != "")
                {
                    load_data_2_grid(ip_path);
                    m_cmd_nhap_cham_cong.Enabled = true;
                    m_btn_xoa_dong.Enabled = false;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_mo_file_mau_Click(object sender, EventArgs e)
        {
            try
            {
                //if (int.Parse(m_txt_thang.Text) <= 0 || int.Parse(m_txt_thang.Text) > 12 || int.Parse(m_txt_nam.Text) < 0)
                //    XtraMessageBox.Show("Vui lòng nhập tháng và năm chấm công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //else tao_file_mau("Chấm công tháng " + m_txt_thang.Text + "-" + m_txt_nam.Text + ".xls");
                if (m_dat_chon_thang.EditValue == null)
                {
                    CHRM_BaseMessages.MsgBox_Error("Chưa chọn tháng và năm!");
                }
                if (m_sle_loai_tien.EditValue == null)
                {
                    XtraMessageBox.Show("Vui lòng chọn loại tiền cần import trước khi tải file về!");
                }
                else
                {
                    tao_file_mau("File import tiền " + m_sle_loai_tien.Text+" trong "+ m_dat_chon_thang.DateTime.Month.ToString() + "-" + m_dat_chon_thang.DateTime.Year.ToString() + ".xls");
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        private void m_btn_hien_thi_Click(object sender, EventArgs e)
        {
            if (m_sle_loai_tien.EditValue == null||  m_sle_loai_tien.EditValue.ToString()=="")
            {
                XtraMessageBox.Show( "Bạn phải chọn loại tiền mới có thể hiển thị được dữ liệu lên lưới!","Thông báo");    
            }
            else
            {

                m_grv.Columns.Clear();
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.loadDataToCacLoaiTienKhac(v_ds, laythang(), laynam(), decimal.Parse(m_sle_loai_tien.EditValue.ToString()));
                m_grc.DataSource = v_ds.Tables[0];
                m_grv.Columns["ID"].Visible = false;
                m_grv.Columns["ID_NHAN_VIEN"].Visible = false;
                m_grv.Columns["NGAY_NHAP"].DisplayFormat.FormatString = "dd/MM/yyyy";
                m_grv.Columns["NGAY_NHAP"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                m_grv.Columns["NGAY_NHAP"].Caption = "Ngày nhập";
                format_gridview();
                m_btn_xoa_dong.Enabled = true;
                m_cmd_nhap_cham_cong.Enabled = false;
            }

        }

        private void m_btn_xoa_dong_Click(object sender, EventArgs e)
        {
            DataRow v_dr= m_grv.GetDataRow(m_grv.FocusedRowHandle);
            var v_confirm = System.Windows.Forms.DialogResult.No;
            if (check_da_tinh_luong_nhung_chua_chot(decimal.Parse(v_dr["ID_NHAN_VIEN"].ToString()), laythang(), laynam()))
            {
                v_confirm = XtraMessageBox.Show("Bảng lương tháng " + laythang() + "/" + laynam() + " đã có lương của nhân viên có mã" + v_dr["MA_NV"].ToString()
                     + "/n. Nếu xóa bản ghi này, phần mềm sẽ tự động tính lại thông tin về lương tháng " + laythang() + "cho nhân viên này."
                     + "Bạn có chắc chắn muốn thực hiện tác vụ này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               
            }
            else
            {
                v_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn thực hiện tác vụ này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
             if (v_confirm == System.Windows.Forms.DialogResult.Yes)
                {

                    delete_tien_khac(v_dr);
                    update_rpt_luong(v_dr["ID_NHAN_VIEN"].ToString(), laythang(), laynam());
                    XtraMessageBox.Show("Xóa thành công!","Thông báo");
                }
        }

        private void delete_tien_khac(DataRow v_dr)
        {
            US_GD_CAC_LOAI_TIEN_KHAC v_us = new US_GD_CAC_LOAI_TIEN_KHAC(decimal.Parse(v_dr["ID"].ToString()));
            v_us.Delete();
        }

        private void update_rpt_luong(string id_nhan_vien, decimal thang , decimal nam)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_us.FillDatasetWithQueryNotReturnDataset("DELETE FROM RPT_LUONG WHERE THANG=" + thang + " AND NAM=" + nam + " AND ID_NHAN_VIEN=" + id_nhan_vien);
            v_us.DeleteRptLuong(decimal.Parse(id_nhan_vien), thang, nam);
            DTO_BANG_LUONG_V2 v_dto_luong = TinhLuongQL.Instance.TinhToanBangLuongNhanVien(decimal.Parse(id_nhan_vien), thang, nam);
            TinhLuongQL.Instance.InsertBanGhiLuongNhanVien(v_dto_luong);
        }

        private bool check_da_tinh_luong_nhung_chua_chot(decimal id_nhan_vien, decimal thang, decimal nam)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            return  v_us.CheckDaTinhLuongNhungChuaChot(id_nhan_vien, thang, nam);           
        }

     
    }
}
