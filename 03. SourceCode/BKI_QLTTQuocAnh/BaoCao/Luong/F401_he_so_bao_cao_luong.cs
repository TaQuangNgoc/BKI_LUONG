﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using BKI_DichVuMatDat.DS.CDBNames;
using DevExpress.XtraSplashScreen;

namespace BKI_DichVuMatDat.BaoCao
{
    public partial class F401_he_so_bao_cao_luong : MaterialSkin.Controls.MaterialForm
    {
        public F401_he_so_bao_cao_luong()
        {
            InitializeComponent();
            format_controls();
            WinFormControls.formatGridView(m_grv);
        }
        public void hien_thi_ra_soat_tinh_luong(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            load_data_2_grid(ip_dc_thang, ip_dc_nam);
            m_txt_thang.Text = ip_dc_thang.ToString();
            m_txt_nam.Text = ip_dc_nam.ToString();         
            ShowDialog();
        }
        #region Members
        
        int soLuongThieuDVCT;
        int soluongChuaChamCong;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            //FormatControl.SetVisibleSimpleButton(this);
            set_define_events();
            format_grid();
            this.KeyPreview = true;
        }

        private void format_grid()
        {
            m_grv.ColumnPanelRowHeight = 35;
            m_grv.RowHeight = 30;
        }
       
        private void load_data_2_grid(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            try
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.GetThamSoBangLuongThang(v_ds, ip_dc_thang, ip_dc_nam);
                m_gd_tham_so_bang_luong_thang.DataSource = v_ds.Tables[0];
                WinFormControls.make_stt_indicator(m_grv);
                format_grid_columns_width();
            }
            catch(Exception)
            {
                throw;
            }
        }

        private void format_grid_columns_width()
        {
            for (int i = 0; i < m_grv.Columns.Count; i++)
            {
                m_grv.Columns[i].Width = 120;
            }
          
        }
        private void set_initial_form_load()
        {
            //m_txt_thang.Text = DateTime.Now.Month.ToString();
            //m_txt_nam.Text = DateTime.Now.Year.ToString();
        }
        private void set_define_events()
        {
            this.Load += F401_he_so_bao_cao_luong_Load;
        }
        
        #endregion

        #region Events
        void F401_he_so_bao_cao_luong_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }      
        #endregion Events        

        private void m_btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
