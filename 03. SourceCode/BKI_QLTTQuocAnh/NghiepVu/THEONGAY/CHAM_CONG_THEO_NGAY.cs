﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using IP.Core.IPCommon;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using IP.Core.IPSystemAdmin;
using BKI_DichVuMatDat.NghiepVu.THEONGAY;
using BKI_DichVuMatDat.NghiepVu.THEOTHOIGIAN;


namespace BKI_DichVuMatDat.NghiepVu.THEONGAY
{
    public partial class CHAM_CONG_THEO_NGAY : MaterialSkin.Controls.MaterialForm
    {
         #region Public Interface
        public CHAM_CONG_THEO_NGAY()
        {
            InitializeComponent();
            //FormatControl.SetVisibleSimpleButton(this);
            this.m_grv.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(WinFormControls.m_grv_PopupMenuShowing);
            this.m_grv.OptionsPrint.AutoWidth = false;
            set_initial_form_load();
            WinFormControls.formatGridView(m_grv);
        }
        private void set_initial_form_load()
        {
            m_dat_chon_thang.EditValue = DateTime.Now;
            set_trang_thai_cham_cong();
            set_define_events();
        }
        #endregion

        #region Members
        US_GD_CHAM_CONG m_us_gd_cham_cong = new US_GD_CHAM_CONG();
        DataSet m_ds_ngay_cong = new DataSet();
        DataSet m_ds_nhan_vien = new DataSet();
        int m_so_nv_da_cham_cong = 0;
        public enum Loi { 
            DuplicateMaNV,
            TrongMaNV,
            MaNVKhongTonTai,
            MaNgayCongKhongTonTai
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
                //v_us.get_bang_cham_cong(v_ds, m_dat_chon_thang.DateTime.Month.ToString(), m_dat_chon_thang.DateTime.Year.ToString());
                int thang = Convert.ToInt16(m_dat_chon_thang.DateTime.Month.ToString());
                int nam = Convert.ToInt16(m_dat_chon_thang.DateTime.Year.ToString());
                DateTime v_dat_bat_dau = new DateTime(nam, thang, 1);
                DateTime v_dat_ket_thuc = new DateTime(nam, thang, 1).AddMonths(1);
                for (DateTime i = v_dat_bat_dau; i < v_dat_ket_thuc; i = i.AddDays(1))
                {
                    var v_c = new DataColumn();
                    v_c.ColumnName = i.ToString("dd/MM");
                    v_ds.Tables[0].Columns.Add(v_c);
                }
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
            bool lua_chon_1 = true;
            LUA_CHON v_f = new LUA_CHON();
            v_f.showForOption(ref lua_chon_1);
            splashScreenManager1.ShowWaitForm();
            m_grv.Columns.Clear();
            WinFormControls.load_xls_to_gridview_co_ghi_chu(ip_path, m_grc);
            if (lua_chon_1 == false)
            {
                DataTable dt = new DataTable();
                WinFormControls.Convert_gridcontrol_to_datatable(m_grv, dt);
                LayDuLieuNhanVien();
                for (int i = 0; i < m_ds_nhan_vien.Tables[0].Rows.Count; i++)
                {
                    String ma_nv = m_ds_nhan_vien.Tables[0].Rows[i]["MA_NV"].ToString();
                    bool contains = dt.AsEnumerable().Any(row => ma_nv == row.Field<String>("MA_NV"));
                    if (!contains)
                    {
                        dt.Rows.Add(m_ds_nhan_vien.Tables[0].Rows[i]["MA_NV"].ToString(), m_ds_nhan_vien.Tables[0].Rows[i]["HO_DEM"].ToString(), m_ds_nhan_vien.Tables[0].Rows[i]["TEN"].ToString());
                    }
                    
                }
                m_grc.DataSource = dt;

            }
            m_grv.Columns["Ghi chú"].Visible = false;
           
            WinFormControls.make_stt_indicator(m_grv);
            for (int i = 0; i < 3; i++)
            {
                m_grv.Columns[i].Fixed = FixedStyle.Left;
            }      
            format_gridview();
            splashScreenManager1.CloseWaitForm();
        }

        private void format_gridview()
        {
            m_grv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            m_grv.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            m_grv.Columns[1].Width = 120;
            for (int i = 2; i < m_grv.Columns.Count; i++)
            {
                m_grv.Columns[i].Width = 50;
                m_grv.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            m_grc.Refresh();
        }
        #endregion

        #region Lay du lieu tu db
        private void LayDuLieuNhanVien()
        {  
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            m_ds_nhan_vien = new DS_DM_NHAN_VIEN();
            v_us.FillDatasetWithQuery(m_ds_nhan_vien, "SELECT * FROM DM_NHAN_VIEN WHERE ID IN ( SELECT ID_NHAN_VIEN FROM GD_NHAN_VIEN_HINH_THUC_TINH_LUONG WHERE ID_HINH_THUC_TINH_LUONG=2 AND CO_YN='Y')");
        }

        private void LayDuLieuLoaiNgayCong()
        {
            DS_DM_LOAI_NGAY_CONG v_ds = new DS_DM_LOAI_NGAY_CONG();
            US_DM_LOAI_NGAY_CONG v_us = new US_DM_LOAI_NGAY_CONG();
            v_us.FillDataset(v_ds);
            m_ds_ngay_cong = v_ds;
        }

        private decimal get_nhan_vien_by_ma_nv(string ip_ma_nhan_vien)
        {
            EnumerableRowCollection<DataRow> res = from row in m_ds_nhan_vien.Tables[0].AsEnumerable()
                                                   where row.Field<string>(DM_NHAN_VIEN.MA_NV) == ip_ma_nhan_vien
                                                   select row;

            return CIPConvert.ToDecimal(res.First()[DM_NHAN_VIEN.ID].ToString());
        }

        private decimal get_loai_ngay_cong(string ip_ma_ngay_cong)
        {
            EnumerableRowCollection<DataRow> res = from row in m_ds_ngay_cong.Tables[0].AsEnumerable()
                                                   where row.Field<string>(DM_LOAI_NGAY_CONG.MA_NGAY_CONG).ToUpper() == ip_ma_ngay_cong.ToUpper()
                                                   select row;

            return CIPConvert.ToDecimal(res.First()[DM_LOAI_NGAY_CONG.ID].ToString());
        }
        #endregion

        #region Kiem tra du lieu tren grid
        private bool check_cham_cong_hop_le()
        {
            LayDuLieuLoaiNgayCong();
            LayDuLieuNhanVien();
            if (!checkBangChamCong())
                return false;
            decimal v_so_nv_da_cham_cong = get_so_luong_cham_cong();
            if (v_so_nv_da_cham_cong != 0)
            {
                string v_str_confirm = "Hiện có " + v_so_nv_da_cham_cong + "/" + m_grv.RowCount + " nhân viên trong bảng chấm công đã có dữ liệu. \nBạn có muốn xóa dữ liệu cũ của những nhân viên này và nhập lại?";
                DialogResult v_dialog = XtraMessageBox.Show(v_str_confirm, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (v_dialog == DialogResult.No)
                    return false;
            }
            return true;
        }

        private decimal get_so_luong_cham_cong()
        {
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_us.FillDatasetChamCongTheoIdHinhThuc(v_ds, m_dat_chon_thang.DateTime.Month.ToString(), m_dat_chon_thang.DateTime.Year.ToString(), 2);
            return decimal.Parse(v_ds.Tables[0].Rows[0]["SO_LUONG"].ToString());
        }

        private int check_db_da_cham_cong()
        {
            
            DS_GD_CHAM_CONG v_ds = new DS_GD_CHAM_CONG();
            US_GD_CHAM_CONG v_us = new US_GD_CHAM_CONG();
            //v_us.FillDatasetChamCong(v_ds, m_txt_thang.Text, m_txt_nam.Text);
            v_us.FillDatasetChamCongOutputSoLuong(v_ds, m_dat_chon_thang.DateTime.Month.ToString(), m_dat_chon_thang.DateTime.Year.ToString(),2);

            return v_ds.Tables[0].Rows.Count;
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
                check_ngay_cong_ko_ton_tai(v_dr, ref trang_thai);
            }
            if (trang_thai == false)
            {
                m_grv.Columns["Ghi chú"].Visible = true;
                m_grc.DataSource = m_grv;
                m_grv.Columns["Ghi chú"].Width = 200;
                XtraMessageBox.Show("Thông tin up lên chưa chính xác. \n Vui lòng đọc cột ghi chú(cột cuối cùng để điều chỉnh lại thông tin trước khi nhập!","Thông báo");
                
            }
            return trang_thai;
          
        }

        private void check_ngay_cong_ko_ton_tai(DataRow v_dr, ref bool trang_thai)
        {
            for (int j = 3; j < m_grv.Columns.Count - 1; j++)
            {
                if (v_dr[j].ToString().Trim() != "")
                {
                    bool trung_loi = false;               
                    for (int k = 3; k < j; k++)
                        {
                            if (v_dr[k].ToString().Trim() == v_dr[j].ToString().Trim())
                                trung_loi = true;
                        }
                    if (j == 3)
                    {
                        trung_loi = false;
                    }      
                    if (trung_loi == false)
                        {
                            DataRow[] v_dr_cham_cong = m_ds_ngay_cong.Tables[0].Select("MA_NGAY_CONG = '" + v_dr[j].ToString().ToUpper() + "'");
                            if (v_dr_cham_cong.Count() == 0)
                            {
                                trang_thai = false;
                                v_dr["Ghi chú"] += v_dr[j].ToString() + ": " + get_text_by_enum(Loi.MaNgayCongKhongTonTai);
                            }
                        }
                    
                }
            }
        }

        private void check_ma_nv_ko_ton_tai(DataRow v_dr, ref bool trang_thai)
        {
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
            if (loi == Loi.MaNgayCongKhongTonTai)
            {
                return " Mã ngày công này không tồn tại; ";
            }
            else return "";
        }

        #endregion

        #region Luu du lieu vao db

        private void m_bgwk_DoWork(object sender, DoWorkEventArgs e)
        { 
            BackgroundWorker worker = sender as BackgroundWorker;
            m_us_gd_cham_cong.BeginTransaction();
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                luuChamCong(m_grv.GetDataRow(i));
                 worker.ReportProgress((i + 1) * 100 / m_grv.RowCount);
            }
            m_us_gd_cham_cong.CommitTransaction();
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
            //this.m_cmd_nhap_cham_cong.Enabled = false;
            XtraMessageBox.Show("Lưu thành công!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            //m_grc.DataSource = null; 
            set_trang_thai_cham_cong();
        }

        private void luuChamCong(DataRow ip_dataRow)
        {
            xoa_du_lieu_cham_cong_cu(get_nhan_vien_by_ma_nv(ip_dataRow[0].ToString()));
            insert_gd_cham_cong(ip_dataRow);
          
        }

        private void xoa_du_lieu_cham_cong_cu(decimal ip_dc_id_nv)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //v_us.xoa_du_lieu_cham_cong(ip_dc_id_nv, m_txt_thang.Text, m_txt_nam.Text);
            v_us.xoaDuLieuChamCongByID(ip_dc_id_nv, m_dat_chon_thang.DateTime.Month.ToString(), m_dat_chon_thang.DateTime.Year.ToString(),2);
        }

        private void insert_gd_cham_cong(DataRow ip_dataRow)
        {
            for (int i = 3; i < ip_dataRow.Table.Columns.Count - 1; i++)
            {
                try
                {
                    US_GD_CHAM_CONG v_us = new US_GD_CHAM_CONG();
                    v_us.dcID_NHAN_VIEN = get_nhan_vien_by_ma_nv(ip_dataRow[0].ToString());
                    int v_thang_cham_cong = int.Parse(ip_dataRow.Table.Columns[i].ColumnName.ToString().Substring(3, 2));
                    int v_ngay_cham_cong = int.Parse(ip_dataRow.Table.Columns[i].ColumnName.ToString().Substring(0, 2));
                    //v_us.datNGAY_CHAM_CONG = new DateTime(int.Parse(m_txt_nam.Text), v_thang_cham_cong, v_ngay_cham_cong);
                    int nam = Convert.ToInt16(m_dat_chon_thang.DateTime.Year);
                    v_us.strDA_XOA = "N";
                    v_us.strNGUOI_LAP = "";
                    v_us.datNGAY_LAP = DateTime.Now;
                    v_us.datNGAY_CHAM_CONG = new DateTime(nam, v_thang_cham_cong, v_ngay_cham_cong);
                    if (ip_dataRow[i].ToString().Trim() == "")
                        v_us.dcID_LOAI_NGAY_CONG = get_loai_ngay_cong(ip_dataRow[i].ToString());
                    else
                        v_us.dcID_LOAI_NGAY_CONG = get_loai_ngay_cong(ip_dataRow[i].ToString());
                   
                    v_us.Insert();
                }
                catch (Exception v_e)
                {
                    CSystemLog_301.ExceptionHandle(v_e);
                }
            }
        }


        private void set_trang_thai_cham_cong()
        {
            m_lbl_trang_thai_cham_cong.Text = "Đã chấm công cho " + get_so_luong_cham_cong() + " nhân viên";
        }
        #endregion

        #endregion

        #region Events Handle
        private void set_define_events()
        {
            this.Load += F696_Cham_cong_xls_Load;          
        }

        private void F696_Cham_cong_xls_Load(object sender, EventArgs e)
        {

        }

        private void m_cmd_nhap_cham_cong_Click(object sender, EventArgs e)
        {
            try
            {
                string string_thang = m_grv.Columns[3].Name.ToString().Substring(6, 2);
                //if (int.Parse(m_txt_thang.Text) <= 0 || int.Parse(m_txt_thang.Text) > 12 || int.Parse(m_txt_nam.Text) < 0)
                //    XtraMessageBox.Show("Vui lòng nhập tháng và năm chấm công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //else if (check_bang_luong_da_chot(m_txt_thang.Text, m_txt_nam.Text))
                //    XtraMessageBox.Show("Tháng đã chốt bảng lương. \nVui lòng ko cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (m_dat_chon_thang.EditValue == null)
                {
                    CHRM_BaseMessages.MsgBox_Error("Chưa chọn tháng và năm chấm công");
                    return;
                }
                            
                else if (Convert.ToInt16(m_dat_chon_thang.DateTime.Month) != int.Parse(string_thang)) 
                {
                    XtraMessageBox.Show( "Tháng đã chọn và tháng ở file excel up lên khác nhau. \nVui lòng kiểm tra lại thông tin!","Thông báo");
                    return;
                }
                else if (check_bang_luong_da_chot(laythang(), laynam()))
                {
                    XtraMessageBox.Show("Bảng lương tháng " + laythang() + "/" + laynam() + " đã chốt. \nVui lòng ko cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (m_bgwk.IsBusy)
                    m_bgwk.CancelAsync();
                else if (check_cham_cong_hop_le())
                {
                    this.m_pn.Visible = true;
                    this.m_prb.Visible = true;
                    this.m_cmd_nhap_cham_cong.Text = "Đang lưu chấm công ...";
                    this.m_cmd_nhap_cham_cong.Enabled = false;
                    m_bgwk.RunWorkerAsync();
                }
            }
            catch (Exception v_e)
            {
                XtraMessageBox.Show("Không có dữ liệu trên bảng. \nVui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool check_bang_luong_da_chot(decimal thang, decimal nam)
        {
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
                if (m_dat_chon_thang.EditValue == null)
                {
                    CHRM_BaseMessages.MsgBox_Error("Chưa chọn tháng và năm!");
                }
                else
                {
                    tao_file_mau("Chấm công theo ngày trong tháng " + m_dat_chon_thang.DateTime.Month.ToString() + "-" + m_dat_chon_thang.DateTime.Year.ToString() + ".xls");
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        private void m_dat_chon_thang_EditValueChanged_1(object sender, EventArgs e)
        {
            set_trang_thai_cham_cong();
        }
        private decimal laythang()
        {
            return decimal.Parse(m_dat_chon_thang.DateTime.Month.ToString());
        }

        private decimal laynam()
        {
            return decimal.Parse(m_dat_chon_thang.DateTime.Year.ToString());
        }

        private void m_btn_hien_thi_Click(object sender, EventArgs e)
        {
            if (m_dat_chon_thang.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn tháng để hiện thị thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CHAM_CONG_DA_NHAP v_f = new CHAM_CONG_DA_NHAP();
                v_f.DisplayLuongNgay(laythang(), laynam());
            }
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("./Default/webframe.html", FileMode.Open, FileAccess.Read);
            //  MessageBox.Show(fs.Name);
            Uri uri = new Uri(fs.Name + "#Theo ngày.html");
            Document v_f = new Document();
            v_f.Display(uri);
        }

       

    }
}
