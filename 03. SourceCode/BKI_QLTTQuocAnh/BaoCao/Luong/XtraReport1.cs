using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BKI_DichVuMatDat.BaoCao.Luong
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }


        internal void Display(System.Data.DataRow dataRow, decimal thang, decimal nam)
        {
            m_lbt_ten_nv.Text = dataRow["MA_NV"].ToString() + " - " + dataRow["HO_DEM"].ToString() + " " + dataRow["TEN"].ToString();
            m_lbl_luong_ns.Text =  (decimal.Parse(dataRow["LUONG_NS"].ToString())).ToString("n0");
            m_lbl_luong_cd.Text = (decimal.Parse(dataRow["LUONG_CD"].ToString())).ToString("n0");
            m_lbl_so_ngay_lv.Text = (decimal.Parse(dataRow["SO_NGAY_LAM_VIEC"].ToString())).ToString("n0");
            m_lbl_lam_them.Text = (decimal.Parse(dataRow["LAM_THEM"].ToString())).ToString("n0");
            m_lbl_phu_cap.Text = (decimal.Parse(dataRow["PHU_CAP"].ToString())).ToString("n0");
            m_lbt_cac_khoan_thu_nhap_khac.Text= (decimal.Parse(dataRow["LUONG_LAM_THEM_SAN_PHAM"].ToString())+ decimal.Parse(dataRow["THUONG"].ToString())+decimal.Parse(dataRow["TRUY_LINH"].ToString())+decimal.Parse(dataRow["THU_NHAP_KHAC"].ToString())).ToString("n0");
            m_lbl_tong_tn.Text = (decimal.Parse(dataRow["THU_NHAP"].ToString())).ToString("n0");
            m_lbt_bhxh.Text = (decimal.Parse(dataRow["BHXH"].ToString())).ToString("n0");
            m_lbl_bhyt.Text = (decimal.Parse(dataRow["BHYT"].ToString())).ToString("n0");
            m_lbl_bhtn.Text = (decimal.Parse(dataRow["BHTN"].ToString())).ToString("n0");
             m_lbl_thue.Text = (decimal.Parse(dataRow["THUE"].ToString())).ToString("n0");
             m_lbl_tong_cac_khoan_phai_nop_khac.Text = (decimal.Parse(dataRow["DOAN_PHI_CD"].ToString()) + decimal.Parse(dataRow["TRUY_THU"].ToString()) + decimal.Parse(dataRow["PHAI_NOP_KHAC"].ToString())).ToString("n0");
            m_lbt_phai_nop.Text = (decimal.Parse(dataRow["PHAI_NOP"].ToString())).ToString("n0");
           
            m_lbl_thuc_linh.Text = (decimal.Parse(dataRow["THUC_LINH"].ToString())).ToString("n0");
            m_lbl_thang.Text = thang.ToString();
            m_lbl_date_now.Text = DateTime.Now.Day.ToString();
            m_lbl_month_now.Text = DateTime.Now.Month.ToString();
            m_lbl_year_now.Text = DateTime.Now.Year.ToString();
            this.ShowPreview();
        }
    }
}
