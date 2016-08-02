using BKI_DichVuMatDat.COMMON;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.DS.CDBNames;
using BKI_DichVuMatDat.DTO;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.NghiepVu.Luong
{
    public class TinhLuongQL
    {
        #region Singleton
        private static TinhLuongQL _instance;
        public static TinhLuongQL Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new TinhLuongQL();
                return _instance;
            }
        }
        #endregion

       
        public DTO_THONG_TIN_BANG_LUONG LayThongTinBangLuong(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            return new DTO_THONG_TIN_BANG_LUONG(ip_dc_thang, ip_dc_nam);
        }
        public DataSet LayDanhSachNhanVienCanTinhLuong(ENUM_CONFIRM_TINH_BANG_LUONG ip_confirm_cach_tinh, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds_danh_sach_nhan_vien;
            if (ip_confirm_cach_tinh == ENUM_CONFIRM_TINH_BANG_LUONG.TINH_NHAN_VIEN_CHUA_CO)
            {
                v_us.LayDanhSachNhanVienIDChuaTinhLuong(
                                 out v_ds_danh_sach_nhan_vien
                                 , ip_dc_thang
                                 , ip_dc_nam);
            }
            else if (ip_confirm_cach_tinh == ENUM_CONFIRM_TINH_BANG_LUONG.TINH_LAI_TOAN_BO)
            {
                v_us.LayToanBoNhanVienIDTinhLuong(
                                 out v_ds_danh_sach_nhan_vien
                                 , ip_dc_thang
                                 , ip_dc_nam);
            }
            else
            {
                v_ds_danh_sach_nhan_vien = new DS_RPT_LUONG();
            }
            return v_ds_danh_sach_nhan_vien;
        }
        public DTO_BANG_LUONG_V2 TinhToanBangLuongNhanVien(decimal ip_dc_id_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            DataRow v_dr_luong_nv = get_luong_1_nhan_vien_v2(ip_dc_id_nhan_vien, ip_dc_thang, ip_dc_nam);
            return transfer_data_row_db_luong_2_object(ip_dc_id_nhan_vien,v_dr_luong_nv, ip_dc_thang, ip_dc_nam);
        }

        public DTO_BANG_LUONG_V2 transfer_data_row_db_luong_2_object(decimal ip_dc_id_nhan_vien,DataRow v_dr_luong_nv,decimal ip_dc_thang,decimal ip_dc_nam)
        {
 	         DTO_BANG_LUONG_V2 v_dto_luong = new DTO_BANG_LUONG_V2();
            v_dto_luong.ID_NHAN_VIEN = ip_dc_id_nhan_vien;
            v_dto_luong.THANG = ip_dc_thang;
            v_dto_luong.NAM = ip_dc_nam;
            v_dto_luong.MA_NV= v_dr_luong_nv["MA_NV"].ToString();
            v_dto_luong.HO_DEM= v_dr_luong_nv["HO_DEM"].ToString();
            v_dto_luong.TEN= v_dr_luong_nv["TEN"].ToString();
            v_dto_luong.LUONG_NS= decimal.Parse(v_dr_luong_nv["LUONG_NS"].ToString());
            v_dto_luong.LUONG_CD= decimal.Parse(v_dr_luong_nv["LUONG_CD"].ToString());
            v_dto_luong.LUONG_NGAY= decimal.Parse(v_dr_luong_nv["LUONG_NGAY"].ToString());
            v_dto_luong.LUONG_SAN_PHAM= decimal.Parse(v_dr_luong_nv["LUONG_SAN_PHAM"].ToString());
            v_dto_luong.LAM_THEM= decimal.Parse(v_dr_luong_nv["LAM_THEM"].ToString());
            v_dto_luong.LUONG_LAM_THEM_SAN_PHAM= decimal.Parse(v_dr_luong_nv["LUONG_LAM_THEM_SAN_PHAM"].ToString());
            v_dto_luong.PHU_CAP= decimal.Parse(v_dr_luong_nv["PHU_CAP"].ToString());
            v_dto_luong.TRUY_LINH= decimal.Parse(v_dr_luong_nv["TRUY_LINH"].ToString());
            v_dto_luong.THU_NHAP = decimal.Parse(v_dr_luong_nv["THU_NHAP_KHAC"].ToString());
            v_dto_luong.THU_NHAP= decimal.Parse(v_dr_luong_nv["THU_NHAP"].ToString());
            v_dto_luong.BHXH= decimal.Parse(v_dr_luong_nv["BHXH"].ToString());
            v_dto_luong.BHYT= decimal.Parse(v_dr_luong_nv["BHYT"].ToString());
            v_dto_luong.BHTN= decimal.Parse(v_dr_luong_nv["BHTN"].ToString());
            v_dto_luong.PHU_THUOC= decimal.Parse(v_dr_luong_nv["PHU_THUOC"].ToString());
            v_dto_luong.GIA_CANH= decimal.Parse(v_dr_luong_nv["GIA_CANH"].ToString());
            v_dto_luong.PC_GIAM_TRU_THUE= decimal.Parse(v_dr_luong_nv["PC_GIAM_TRU_THUE"].ToString());
            v_dto_luong.LAM_THEM_GIAM_TRU_THUE= decimal.Parse(v_dr_luong_nv["LAM_THEM_GIAM_TRU_THUE"].ToString());
            v_dto_luong.LAM_THEM_SAN_PHAM_GIAM_TRU_THUE= decimal.Parse(v_dr_luong_nv["LAM_THEM_SAN_PHAM_GIAM_TRU_THUE"].ToString());
            v_dto_luong.CAC_LOAI_TIEN_KHAC_GIAM_TRU_THUE= decimal.Parse(v_dr_luong_nv["CAC_LOAI_TIEN_KHAC_GIAM_TRU_THUE"].ToString());
            v_dto_luong.GIAM_TRU= decimal.Parse(v_dr_luong_nv["GIAM_TRU"].ToString());
            v_dto_luong.DOAN_PHI_CD= decimal.Parse(v_dr_luong_nv["DOAN_PHI_CD"].ToString());
            v_dto_luong.THUE= decimal.Parse(v_dr_luong_nv["THUE"].ToString());
            v_dto_luong.TRUY_THU= decimal.Parse(v_dr_luong_nv["TRUY_THU"].ToString());
            v_dto_luong.PHAI_NOP = decimal.Parse(v_dr_luong_nv["PHAI_NOP_KHAC"].ToString());
            v_dto_luong.PHAI_NOP= decimal.Parse(v_dr_luong_nv["PHAI_NOP"].ToString());
            v_dto_luong.THUC_LINH= decimal.Parse(v_dr_luong_nv["THUC_LINH"].ToString());
            return v_dto_luong;
        }
        public void InsertBanGhiLuongNhanVien(DTO_BANG_LUONG_V2 ip_dto_bang_luong)
        {
            ip_dto_bang_luong.ID_NHAN_VIEN = ExecuteFuntion.LayNhanVienID(ip_dto_bang_luong.MA_NV);
            US_RPT_LUONG v_us_rpt_luong = transfer_dto_2_us_object(ip_dto_bang_luong);

            v_us_rpt_luong.BeginTransaction();
            v_us_rpt_luong.Insert();
            v_us_rpt_luong.CommitTransaction();
        }
        public void ReplaceBanGhiLuongNhanVien(DTO_BANG_LUONG_V2 ip_dto_bang_luong)
        {
            US_RPT_LUONG v_us_rpt_luong = transfer_dto_2_us_object(ip_dto_bang_luong);

            ip_dto_bang_luong.ID_NHAN_VIEN = ExecuteFuntion.LayNhanVienID(ip_dto_bang_luong.MA_NV);
            v_us_rpt_luong.BeginTransaction();
            v_us_rpt_luong.XoaBangLuongNhanVien(ip_dto_bang_luong.ID_NHAN_VIEN, ip_dto_bang_luong.THANG, ip_dto_bang_luong.NAM);
            v_us_rpt_luong.Insert();
            v_us_rpt_luong.CommitTransaction();
        }
        public void ReplaceBanGhiLuongNhanVien(decimal ip_dc_id_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            //var v_dr_luong_nv = get_luong_1_nhan_vien_v2(ip_dc_id_nhan_vien, ip_dc_thang, ip_dc_nam);
            //var v_dto_luong_nv = transfer_data_row_db_luong_2_object(v_dr_luong_nv, ip_dc_thang, ip_dc_nam);
            //US_RPT_LUONG_V2 v_us_rpt_luong_v2 = transfer_dto_2_us_object(v_dto_luong_nv);

            //DataRow v_dr_thong_tin_tong_hop_nv = get_thong_tin_tong_hop_1_nhan_vien_v2(ExecuteFuntion.LayMaNhanVien(ip_dc_id_nhan_vien), ip_dc_thang, ip_dc_nam);
            //US_RPT_THONG_TIN_TONG_HOP_V2 v_us_rpt_tong_hop_v2 = DataRow2USThongTinTongHopV2(v_dr_thong_tin_tong_hop_nv);

            //v_us_rpt_luong_v2.BeginTransaction();
            //v_us_rpt_luong_v2.XoaBangLuongNhanVien(ip_dc_id_nhan_vien, ip_dc_thang, ip_dc_nam);
            //v_us_rpt_luong_v2.Insert();
            //v_us_rpt_tong_hop_v2.UseTransOfUSObject(v_us_rpt_luong_v2);
            //v_us_rpt_tong_hop_v2.XoaDuLieuTongHopNhanVien(ip_dc_id_nhan_vien, ip_dc_thang, ip_dc_nam);
            //v_us_rpt_tong_hop_v2.Insert();
            //v_us_rpt_luong_v2.CommitTransaction();
        }

        public void XoaBanGhiLuongNhanVien(decimal ip_dc_id_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            //US_RPT_LUONG_V2 v_us_rpt_luong_v2 = new US_RPT_LUONG_V2();
            //US_RPT_THONG_TIN_TONG_HOP_V2 v_us_rpt_tong_hop_v2 = new US_RPT_THONG_TIN_TONG_HOP_V2();
            //v_us_rpt_luong_v2.BeginTransaction();
            //v_us_rpt_luong_v2.XoaBangLuongNhanVien(ip_dc_id_nhan_vien, ip_dc_thang, ip_dc_nam);
            //v_us_rpt_tong_hop_v2.UseTransOfUSObject(v_us_rpt_luong_v2);
            //v_us_rpt_tong_hop_v2.XoaDuLieuTongHopNhanVien(ip_dc_id_nhan_vien, ip_dc_thang, ip_dc_nam);
            //v_us_rpt_luong_v2.CommitTransaction();
        }


        public bool KiemTraNhanVienCoTrongBangLuongChua(DTO_BANG_LUONG_V2 ip_dto_bang_luong)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM RPT_LUONG WHERE MA_NV=N'" + ip_dto_bang_luong.MA_NV + "' AND THANG= " + ip_dto_bang_luong.THANG.ToString() + " AND NAM=" + ip_dto_bang_luong.NAM.ToString());
            if (v_ds.Tables[0].Rows.Count > 0)
                return true;
            return false;
          //  return ExecuteFuntion.KiemTraNhanVienCoTrongBangLuongChua(ip_dto_bang_luong.MA_NV.ToString(), ip_dto_bang_luong.THANG, ip_dto_bang_luong.NAM);
        }
        
        public void ChotBangLuongThang(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            US_RPT_CHOT_BANG_LUONG v_us_rpt_chot_bang_luong = new US_RPT_CHOT_BANG_LUONG();
            if (v_us_rpt_chot_bang_luong.IsLockBangLuong(ip_dc_thang, ip_dc_nam))
            {
                XtraMessageBox.Show("Bảng lương đã được chốt!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            v_us_rpt_chot_bang_luong.LockBangLuongThang(ip_dc_thang, ip_dc_nam);
            XtraMessageBox.Show("Đã chốt bảng lương tháng thành công! ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void XoaToanBoBangLuong(decimal ip_dc_thang, decimal ip_dc_nam)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_us.XoaToanBoBangLuong(ip_dc_thang, ip_dc_nam);
        }
        private bool isNull(Object ip_obj)
        {
            if(ip_obj == DBNull.Value)
            {
                return true;
            }
            return false;
        }

       // #region Private Method
       //// private bool kiem_tra_nhan_vien_co_trong_danh_sach_tinh_luong_thang(decimal ip_dc_id_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam)
       // //{
       // //    US_RPT_LUONG_V2 v_us = new US_RPT_LUONG_V2();
       // //    return v_us.kiem_tra_nhan_vien_co_duoc_tinh_luong_thang(ip_dc_id_nhan_vien, ip_dc_thang, ip_dc_nam);
       // //}

        private DataRow get_luong_1_nhan_vien_v2(decimal ip_dc_id_nhan_vien, decimal ip_dc_thang, decimal ip_dc_nam)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.TaoBangLuongNhanVien(v_ds, ip_dc_id_nhan_vien, ip_dc_thang, ip_dc_nam);
            DataRow v_dr = v_ds.Tables[0].Rows[0];
            return v_dr;
        }

        private US_RPT_LUONG transfer_dto_2_us_object(DTO_BANG_LUONG_V2 ip_dto_luong)
        {
            US_RPT_LUONG v_us_luong = new US_RPT_LUONG();
            v_us_luong.dcID_NHAN_VIEN = ExecuteFuntion.LayNhanVienID(ip_dto_luong.MA_NV);
            v_us_luong.dcTHANG = ip_dto_luong.THANG;
            v_us_luong.dcNAM = ip_dto_luong.NAM;
            v_us_luong.strMA_NV = ip_dto_luong.MA_NV;
            v_us_luong.strHO_DEM = ip_dto_luong.HO_DEM;
            v_us_luong.strTEN = ip_dto_luong.TEN;
            v_us_luong.dcLUONG_NS = ip_dto_luong.LUONG_NS;
            v_us_luong.dcLUONG_CD = ip_dto_luong.LUONG_CD;
            v_us_luong.dcLUONG_NGAY = ip_dto_luong.LUONG_NGAY;
            v_us_luong.dcLUONG_SAN_PHAM = ip_dto_luong.LUONG_SAN_PHAM;
            v_us_luong.dcLAM_THEM = ip_dto_luong.LAM_THEM;
            v_us_luong.dcLUONG_LAM_THEM_SAN_PHAM = ip_dto_luong.LUONG_LAM_THEM_SAN_PHAM;
            v_us_luong.dcPHU_CAP = ip_dto_luong.PHU_CAP;
            v_us_luong.dcTRUY_LINH = ip_dto_luong.TRUY_LINH;
            v_us_luong.dcTHU_NHAP_KHAC = ip_dto_luong.THU_NHAP_KHAC;
            v_us_luong.dcTHU_NHAP = ip_dto_luong.THU_NHAP;
            v_us_luong.dcBHXH = ip_dto_luong.BHXH;
            v_us_luong.dcBHYT = ip_dto_luong.BHYT;
            v_us_luong.dcBHTN = ip_dto_luong.BHTN;
            v_us_luong.dcPHU_THUOC = ip_dto_luong.PHU_THUOC;
            v_us_luong.dcGIA_CANH = ip_dto_luong.GIA_CANH;
            v_us_luong.dcPC_GIAM_TRU_THUE = ip_dto_luong.PC_GIAM_TRU_THUE;
            v_us_luong.dcLAM_THEM_GIAM_TRU_THUE = ip_dto_luong.LAM_THEM_GIAM_TRU_THUE;
            v_us_luong.dcLAM_THEM_SAN_PHAM_GIAM_TRU_THUE = ip_dto_luong.LAM_THEM_SAN_PHAM_GIAM_TRU_THUE;
            v_us_luong.dcCAC_LOAI_TIEN_KHAC_GIAM_TRU_THUE = ip_dto_luong.CAC_LOAI_TIEN_KHAC_GIAM_TRU_THUE;
            v_us_luong.dcGIAM_TRU = ip_dto_luong.GIAM_TRU;
            v_us_luong.dcDOAN_PHI_CD = ip_dto_luong.DOAN_PHI_CD;
            v_us_luong.dcTHUE = ip_dto_luong.THUE;
            v_us_luong.dcTRUY_THU = ip_dto_luong.TRUY_THU;
            v_us_luong.dcPHAI_NOP_KHAC = ip_dto_luong.PHAI_NOP_KHAC;
            v_us_luong.dcPHAI_NOP = ip_dto_luong.PHAI_NOP;
            v_us_luong.dcTHUC_LINH = ip_dto_luong.THUC_LINH;
            
            return v_us_luong;
        }
       


      

      //  #endregion
        
    }
}
