﻿using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;

using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS.CDBNames;
using System.Configuration;
using System.Data.OleDb;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Menu;
using System.IO;
using Microsoft.Office.Interop;
using System.Reflection;
using DevExpress.XtraEditors;
using System.Linq;

namespace BKI_DichVuMatDat
{
    public class WinFormControls
    {
        public WinFormControls()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public enum eTAT_CA
        {
            YES,
            NO
        }

        public enum eLOAI_TU_DIEN
        {
            TRANG_THAI_CHUC_VU,
            LOAI_HOP_DONG,
            LOAI_DON_VI,
            CAP_DON_VI,
            CO_CHE,
            LOAI_DU_AN,
            TRANG_THAI_DU_AN,
            LOAI_QUYET_DINH,
            TRANG_THAI_LAO_DONG,
            DM_CA_HOC
        }

      

        public static void load_data_to_auto_complete_source(string ip_str_table_name, string ip_str_column_name, TextBox ip_txt)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithProc(v_ds, ip_str_table_name, ip_str_column_name);
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                DataRow v_dr = v_ds.Tables[0].Rows[i];
                ip_txt.AutoCompleteCustomSource.Add(v_dr[ip_str_column_name].ToString());
            }
        }

        public static void load_data_to_combobox(string ip_str_table_name, string ip_str_value_field, string ip_str_display_field, string ip_str_condition, eTAT_CA ip_e_tat_ca, System.Windows.Forms.ComboBox ip_cbo)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetCBO(v_ds, ip_str_table_name, ip_str_value_field, ip_str_display_field, ip_str_condition);

            ip_cbo.DisplayMember = ip_str_display_field;
            ip_cbo.ValueMember = ip_str_value_field;
            ip_cbo.DataSource = v_ds.Tables[0];

            if (ip_e_tat_ca == eTAT_CA.YES)
            {
                DataRow v_dr = v_ds.Tables[0].NewRow();
                v_dr[0] = -1;
                v_dr[1] = "------ Tất cả ------";
                v_ds.Tables[0].Rows.InsertAt(v_dr, 0);
                ip_cbo.SelectedIndex = 0;
            }
            else
            {
                ip_cbo.SelectedIndex = 0;
            }
        }

        public static void load_data_to_combobox_with_query(System.Windows.Forms.ComboBox ip_cbo, string ip_str_value_field, string ip_str_display_field, eTAT_CA ip_e_tat_ca, string ip_query)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithQuery(v_ds, ip_query);

            ip_cbo.DisplayMember = ip_str_display_field;
            ip_cbo.ValueMember = ip_str_value_field;
            ip_cbo.DataSource = v_ds.Tables[0];

            if (ip_e_tat_ca == eTAT_CA.YES)
            {
                DataRow v_dr = v_ds.Tables[0].NewRow();
                v_dr[0] = -1;
                v_dr[1] = "------ Tất cả ------";
                v_ds.Tables[0].Rows.InsertAt(v_dr, 0);
                ip_cbo.SelectedIndex = 0;
            }
            else
            {
                ip_cbo.SelectedIndex = 0;
            }
        }
        public static void load_xls_to_gridview_v2(string ip_str_path, DevExpress.XtraGrid.GridControl ip_grc)
        {
            string conStr = "";
            conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
            conStr = String.Format(conStr, ip_str_path, "Yes");
            OleDbConnection con = new OleDbConnection(conStr);
            OleDbCommand ExcelCommand = new OleDbCommand();
            ExcelCommand.Connection = con;
            con.Open();
            DataTable ExcelDataSet = new DataTable();
            ExcelDataSet = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            DataTable dt = new DataTable();
            if(ExcelDataSet != null && ExcelDataSet.Rows.Count > 0)
            {
                string SheetName = ExcelDataSet.Rows[0]["TABLE_NAME"].ToString(); // get sheetname
                ExcelCommand.CommandText = "SELECT * From [" + SheetName + "]";
                OleDbDataAdapter ExcelAdapter = new OleDbDataAdapter(ExcelCommand);
                ExcelAdapter.SelectCommand = ExcelCommand;
                ExcelAdapter.Fill(dt);
            }
            con.Close();
            ip_grc.DataSource = dt;
        }

        public static void load_xls_to_gridview_v3(string ip_str_path, DevExpress.XtraGrid.GridControl ip_grc, string ip_name_sheet_import)
        {
            string conStr = "";
            string SheetName = ip_name_sheet_import + "$";
            conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
            conStr = String.Format(conStr, ip_str_path, "Yes");
            OleDbConnection con = new OleDbConnection(conStr);
            OleDbCommand ExcelCommand = new OleDbCommand();
            ExcelCommand.Connection = con;
            con.Open();
            DataTable ExcelDataSet = new DataTable();
            ExcelDataSet = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            DataTable dt = new DataTable();
            if (ExcelDataSet != null && ExcelDataSet.Rows.Count > 0)
            {
                //string SheetName = ExcelDataSet.Rows[0]["TABLE_NAME"].ToString(); // get sheetname
                ExcelCommand.CommandText = "SELECT * From [" + SheetName + "]";
                OleDbDataAdapter ExcelAdapter = new OleDbDataAdapter(ExcelCommand);
                ExcelAdapter.SelectCommand = ExcelCommand;
                ExcelAdapter.Fill(dt);
            }
            con.Close();
            //format_data_header(dt);
            DataTable v_dt_result = dt.Rows.Cast<DataRow>().Where(row => !row.ItemArray.All(field => field is System.DBNull || string.IsNullOrEmpty(field.ToString()) == true)).CopyToDataTable();
            ip_grc.DataSource = v_dt_result;
        }

        public static void load_xls_to_gridview(string ip_str_path, DevExpress.XtraGrid.GridControl ip_grc)
        {
            string conStr = "";
            conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
            conStr = String.Format(conStr, ip_str_path, "Yes");
            OleDbConnection con = new OleDbConnection(conStr);
            OleDbCommand ExcelCommand = new OleDbCommand();
            ExcelCommand.Connection = con;
            con.Open();
            DataTable ExcelDataSet = new DataTable();
            ExcelDataSet = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            DataTable dt = new DataTable();
            if (ExcelDataSet != null && ExcelDataSet.Rows.Count > 0)
            {
                string SheetName = ExcelDataSet.Rows[0]["TABLE_NAME"].ToString(); // get sheetname
                ExcelCommand.CommandText = "SELECT * From [" + SheetName + "]";
                OleDbDataAdapter ExcelAdapter = new OleDbDataAdapter(ExcelCommand);
                ExcelAdapter.SelectCommand = ExcelCommand;
                ExcelAdapter.Fill(dt);
            }
            con.Close();
            format_data_header(dt);
            ip_grc.DataSource = dt;
        }

        public static void load_xls_to_data_table(string ip_str_path, ref DataTable ip_dt_src)
        {
            string conStr = "";
            conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
            conStr = String.Format(conStr, ip_str_path, "Yes");
            OleDbConnection con = new OleDbConnection(conStr);
            OleDbCommand ExcelCommand = new OleDbCommand();
            ExcelCommand.Connection = con;
            con.Open();
            DataTable ExcelDataSet = new DataTable();
            ExcelDataSet = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            DataTable dt = new DataTable();
            if(ExcelDataSet != null && ExcelDataSet.Rows.Count > 0)
            {
                string SheetName = ExcelDataSet.Rows[0]["TABLE_NAME"].ToString(); // get sheetname
                ExcelCommand.CommandText = "SELECT * From [" + SheetName + "]";
                OleDbDataAdapter ExcelAdapter = new OleDbDataAdapter(ExcelCommand);
                ExcelAdapter.SelectCommand = ExcelCommand;
                ExcelAdapter.Fill(dt);
                ip_dt_src = dt;
            }
            con.Close();
        }
        private static void format_data_header(DataTable dt)
        {
            foreach (DataColumn item in dt.Columns)
            {
                if (item.ColumnName.StartsWith("4"))
                {
                    var v_name_value = int.Parse(item.ColumnName.Trim());
                    var v_str_name = (new DateTime(1899, 12, 31).AddDays(v_name_value)).ToString("MM/dd/yyyy");
                    item.ColumnName = v_str_name;
                }
            }
        }

        public static DateTime FormatPostingDate(string txtdate)
        {
            int date;
            if (txtdate != null && txtdate != string.Empty)
            {
                if (int.TryParse(txtdate, out date))
                {
                    return DateTime.FromOADate(date);
                }
                DateTime postingDate = Convert.ToDateTime(txtdate);
                return postingDate;
            }
            return Convert.ToDateTime(txtdate);
        }

        #region Report
        static GridView m_grv;
        public static void m_grv_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                int rowHandle = e.HitInfo.RowHandle;
                e.Menu.Items.Clear();
                e.Menu.Items.Add(WinFormControls.CreateRowSubMenu(view, rowHandle));
            }
        }

        public static DXMenuItem CreateRowSubMenu(GridView view, int rowHandle)
        {
            m_grv = view;
            DXSubMenuItem subMenu = new DXSubMenuItem("Báo cáo");
            DXMenuItem menuItemReportXLS = new DXMenuItem("&Báo cáo XLS", new EventHandler(ExportXLSClick));
            DXMenuItem menuItemReportPDF = new DXMenuItem("&Báo cáo PDF", new EventHandler(ExportPDFClick));
            DXMenuItem menuItemReportHTML = new DXMenuItem("&Báo cáo HTML", new EventHandler(ExportHTMLClick));
            DXMenuItem menuItemReportDOC = new DXMenuItem("&Báo cáo TXT", new EventHandler(ExportDOCClick));
            subMenu.Items.Add(menuItemReportXLS);
            subMenu.Items.Add(menuItemReportPDF);
            subMenu.Items.Add(menuItemReportHTML);
            subMenu.Items.Add(menuItemReportDOC);
            return subMenu;
        }

        private static void ExportPDFClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv.ExportToPdf(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu báo cáo thành công");
            }
        }

        private static void ExportHTMLClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "html files (*.html)|*.html|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv.ExportToHtml(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu báo cáo thành công");
            }
        }

        private static void ExportDOCClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv.ExportToText(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu báo cáo thành công");
            }
        }

        private static void ExportXLSClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv.ExportToXls(saveFileDialog1.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("Lưu báo cáo thành công");
            }
        }
        #endregion

        #region openFileDialog
        public static string openFileDialog() {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Set filter options and filter index.
            openFileDialog1.Filter = "xls Files|*.xls|xlsx Files|*.xlsx|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            var userClickedOK = openFileDialog1.ShowDialog();
            if (userClickedOK == System.Windows.Forms.DialogResult.OK)
            {
                return openFileDialog1.FileName;
            }
            return "";
        } 
        #endregion

        #region saveFileDialog
        public static string saveFileDialog(string ip_file_name)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = ip_file_name;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog1.FileName;
            }
            return "";
        }
        #endregion

        #region copy & open Template
        public static void openTemplate(string ip_file_name) {
            string sourcePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"Template";//Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Template\");
            string targetPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string sourceFile = System.IO.Path.Combine(sourcePath, ip_file_name);
            string destFile = System.IO.Path.Combine(targetPath, ip_file_name);
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
            System.IO.File.Copy(sourceFile, destFile, true);

            string newpath = targetPath + "\\" + ip_file_name;

            var excel = new Excel.Application();
            excel.Visible = true;
            Excel.Workbooks books = excel.Workbooks;
            Excel.Workbook openexcel = books.Open(newpath);
        }

        public static void openTemplate_v2(string ip_file_name)
        {
            string sourcePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"Template";//Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Template\");
            string targetPath = saveFileDialog(ip_file_name);
            if (targetPath !="")
            {
                string sourceFile = System.IO.Path.Combine(sourcePath, ip_file_name);
                System.IO.File.Copy(sourceFile, targetPath, true);
                XtraMessageBox.Show("Đã lưu file mẫu tại " + targetPath +".\nFile sẽ tự động mở ngay sau đây!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var excel = new Excel.Application();
                excel.Visible = true;
                Excel.Workbooks books = excel.Workbooks;
                Excel.Workbook openexcel = books.Open(targetPath);
            }           
        }
        #endregion

        #region Drag Control
        private static bool isDragging = false;
        static Point move;

        public static void allowDragControl(Control ip_c) {
            ip_c.MouseDown += new MouseEventHandler(c_MouseDown);
            ip_c.MouseMove += new MouseEventHandler(c_MouseMove);
            ip_c.MouseUp += new MouseEventHandler(c_MouseUp);
        }

        static void c_MouseDown(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            isDragging = true;
            move = e.Location;
        }

        static void c_MouseMove(object sender, MouseEventArgs e)
        {

            if (isDragging == true)
            {
                Control c = sender as Control;
                c.Left += e.X - move.X;
                c.Top += e.Y - move.Y;
            }
        }

        static void c_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        #endregion
    }

    public class US_DUNG_CHUNG : US_Object
    {

        public void FillDatasetWithProc(DataSet op_ds, string ip_str_table_name, string ip_str_column_name)
        {
            CStoredProc v_cstore = new CStoredProc("get_data_to_dataset_with_table_name_and_column_name");
            v_cstore.addNVarcharInputParam("@TABLE_NAME", ip_str_table_name);
            v_cstore.addNVarcharInputParam("@COLUMN_NAME", ip_str_column_name);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }


        internal void FillDatasetCBO(DataSet op_ds, string ip_str_table_name, string ip_str_value_field, string ip_str_display_field, string ip_str_condition)
        {
            CStoredProc v_cstore = new CStoredProc("get_data_for_cbo");
            v_cstore.addNVarcharInputParam("@TABLE_NAME", ip_str_table_name);
            v_cstore.addNVarcharInputParam("@COLUMN_VALUE", ip_str_value_field);
            v_cstore.addNVarcharInputParam("@COLUMN_DISPLAY", ip_str_display_field);
            v_cstore.addNVarcharInputParam("@CONDITION", ip_str_condition);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        internal void FillDatasetWithTableName(DataSet op_ds, string ip_str_table_name)
        {
            CStoredProc v_cstore = new CStoredProc("get_data_from_table");
            v_cstore.addNVarcharInputParam("@TABLE_NAME", ip_str_table_name);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        internal void FillDatasetWithQuery(DataSet op_ds, string ip_query)
        {
            CStoredProc v_cstore = new CStoredProc("pr_fill_ds_with_query");
            v_cstore.addNVarcharInputParam("@SQL_QUERY", ip_query);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }





        internal void FillDatasetGDChamCong(DataSet v_ds, DateTime v_dat)
        {
            CStoredProc v_cstore = new CStoredProc("pr_gd_cham_cong");
            v_cstore.addDatetimeInputParam("@ngay_cham_cong", v_dat);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }


        internal void active_hinh_thuc_tinh_luong(decimal m_id_nhan_vien, decimal v_id_hinh_thuc)
        {
            DataSet v_ds= new DataSet();
            v_ds.Tables.Add(new DataTable());
            CStoredProc v_cstore = new CStoredProc("pr_active_hinh_thuc_tinh_luong");
            v_cstore.addDecimalInputParam("@ID_NHAN_VIEN", m_id_nhan_vien);
            v_cstore.addDecimalInputParam("@ID_HINH_THUC_TINH_LUONG", v_id_hinh_thuc);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void non_active_hinh_thuc_tinh_luong(decimal m_id_nhan_vien)
        {
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            CStoredProc v_cstore = new CStoredProc("pr_non_active_hinh_thuc_tinh_luong");
            v_cstore.addDecimalInputParam("@ID_NHAN_VIEN", m_id_nhan_vien);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void UpdateLoaiNhanVien(decimal m_id_nhan_vien, decimal id_loai_nhan_vien)
        {
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            CStoredProc v_cstore = new CStoredProc("pr_update_loai_nhan_vien");
            v_cstore.addDecimalInputParam("@ID_NHAN_VIEN", m_id_nhan_vien);
            v_cstore.addDecimalInputParam("@ID_LOAI_NHAN_VIEN", id_loai_nhan_vien);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void UpdatePhaiDongDoanPhi(decimal m_id_nhan_vien)
        {
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            CStoredProc v_cstore = new CStoredProc("pr_update_phai_dong_doan_phi");
            v_cstore.addDecimalInputParam("@ID_NHAN_VIEN", m_id_nhan_vien);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void InsertSoLuongPhuThuoc(decimal m_id_nhan_vien, decimal p)
        {

            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            CStoredProc v_cstore = new CStoredProc("pr_update_phai_dong_doan_phi");
            v_cstore.addDecimalInputParam("@ID_NHAN_VIEN", m_id_nhan_vien);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void active_hinh_thuc_tinh_luong_cho_cong_ty(decimal v_id_hinh_thuc)
        {
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            CStoredProc v_cstore = new CStoredProc("pr_active_hinh_thuc_tinh_luong_cho_cong_ty");          
            v_cstore.addDecimalInputParam("@ID_HINH_THUC_TINH_LUONG", v_id_hinh_thuc);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void non_active_hinh_thuc_tinh_luong_cua_cong_ty()
        {
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            CStoredProc v_cstore = new CStoredProc("pr_non_active_hinh_thuc_tinh_luong_cua_cong_ty");
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void UpdateThamSoKhac(decimal Giam_tru_gia_canh, decimal Giam_tru_phu_thuoc, decimal Luong_toi_thieu_quy_dinh, decimal Luong_toi_thieu_vung, decimal So_thang_tinh_bhxh)
        {
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            CStoredProc v_cstore = new CStoredProc("pr_update_tham_so_khac");
            v_cstore.addDecimalInputParam("@Giam_tru_gia_canh", Giam_tru_gia_canh);
            v_cstore.addDecimalInputParam("@Giam_tru_phu_thuoc", Giam_tru_phu_thuoc);
            v_cstore.addDecimalInputParam("@Luong_toi_thieu_quy_dinh", Luong_toi_thieu_quy_dinh);
            v_cstore.addDecimalInputParam("@Luong_toi_thieu_vung", Luong_toi_thieu_vung);
            v_cstore.addDecimalInputParam("@So_thang_tinh_bhxh", So_thang_tinh_bhxh);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }
    } 
}
