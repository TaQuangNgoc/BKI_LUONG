using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BKI_DichVuMatDat.NghiepVu;
using BKI_DichVuMatDat.NghiepVu.ChamCongSanPham;
using BKI_DichVuMatDat.NghiepVu.THEOTHOIGIAN;
using BKI_DichVuMatDat.NghiepVu.THEONGAY;
using BKI_DichVuMatDat.NghiepVu.ThongTinNhanVien;
using DevExpress.XtraEditors;
using BKI_DichVuMatDat.CAI_DAT;
using MaterialSkin;


namespace BKI_DichVuMatDat
{
    
    public partial class FORM_MENU : MaterialSkin.Controls.MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        TreeNode CAI_DAT_THAM_SO = new TreeNode("Cài đặt tham số");
        TreeNode NHAP_LIEU = new TreeNode("Nhập liệu");
        TreeNode BAO_CAO = new TreeNode("Báo cáo");
        //NODE CỦA CỦA CÀI ĐẶT THAM SỐ
        TreeNode CAC_HINH_THUC_TINH_LUONG = new TreeNode("Các hình thức tính lương");
       
        TreeNode CHAM_CONG_THEO_TG = new TreeNode("Chấm công theo thời gian");
        TreeNode SO_NGAY_CONG_TIEU_CHUAN = new TreeNode("Số ngày công tiêu chuẩn");
        TreeNode DANH_MUC = new TreeNode("Danh Mục");
        TreeNode THAM_SO_KHAC = new TreeNode("Tham số khác");
        TreeNode DANH_MUC_SAN_PHAM = new TreeNode("Chấm công theo sản phẩm");
        TreeNode DANG_NHAP_HE_THONG = new TreeNode("Đăng nhập hệ thống");
        //NODE CON CỦA NHẬP LIỆU
        TreeNode THONG_TIN_NHAN_VIEN = new TreeNode("Thông tin nhân viên");    
        TreeNode CHAM_CONG_TU_EXCEL = new TreeNode("Chấm công từ excel");
        //NODE CON CỦA thông tin nhân viên

        TreeNode THEM_MOI_NHAN_VIEN = new TreeNode("Thêm mới nhân viên");
        TreeNode SUA_NHAN_VIEN = new TreeNode("Sửa thông tin nhân viên");
        TreeNode XOA_NHAN_VIEN = new TreeNode("Xóa bỏ nhân viên");

        //NODE CON CỦA CHẤM CÔNG TỪ EXCEL
        TreeNode THEO_THOI_GIAN = new TreeNode("Theo thời gian");
        TreeNode LAM_THEM_THEO_THOI_GIAN = new TreeNode("Làm thêm theo thời gian");
        TreeNode THEO_NGAY = new TreeNode("Theo ngày");
        TreeNode CAC_LOAI_TIEN_KHAC = new TreeNode("Các loại tiền khác");

        //NODE CON CỦA THEO SẢN PHẨM
        
        TreeNode CHAM_CONG_SAN_PHAM = new TreeNode(" Theo sản phẩm");
        TreeNode CHAM_CONG_LAM_THEM_SAN_PHAM = new TreeNode("Làm thêm theo sản phẩm");

        //NODE CON CỦA BÁO CÁO
        TreeNode BANG_LUONG = new TreeNode("Bảng lương");
        TreeNode PHIEU_LUONG = new TreeNode("Phiếu lương");


        public FORM_MENU()
        {
            InitializeComponent();
            Init_tree_view();
            this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
        }

        private void Init_tree_view()
        {
            //NODE 0
            treeView1.Nodes.Add(CAI_DAT_THAM_SO);
            //NODE 1
            treeView1.Nodes.Add(NHAP_LIEU);
            //NODE 2
            treeView1.Nodes.Add(BAO_CAO);

            //node Cài đặt tham số
            //ADD CÁC HÌNH THỨC TÍNH LƯƠNG
            treeView1.Nodes[0].Nodes.Add(CAC_HINH_THUC_TINH_LUONG);
           
            //ADD CHẤM CÔNG THEO THỜI GIAN
            treeView1.Nodes[0].Nodes.Add(CHAM_CONG_THEO_TG);
            treeView1.Nodes[0].Nodes[1].Nodes.Add(DANH_MUC);
            treeView1.Nodes[0].Nodes[1].Nodes.Add(SO_NGAY_CONG_TIEU_CHUAN);
            treeView1.Nodes[0].Nodes[1].Nodes.Add(THAM_SO_KHAC);
          //  treeView1.Nodes[0].Nodes.Add(DANH_MUC_SAN_PHAM);
            treeView1.Nodes[0].Nodes.Add(DANG_NHAP_HE_THONG);
            treeView1.ItemHeight = 35;

            //node Nhập liệu
            treeView1.Nodes[1].Nodes.Add(THONG_TIN_NHAN_VIEN);
            treeView1.Nodes[1].Nodes.Add(CHAM_CONG_TU_EXCEL);
          

            //node thông tin nhân viên
            treeView1.Nodes[1].Nodes[0].Nodes.Add(THEM_MOI_NHAN_VIEN);
            treeView1.Nodes[1].Nodes[0].Nodes.Add(SUA_NHAN_VIEN);
          //  treeView1.Nodes[1].Nodes[0].Nodes.Add(XOA_NHAN_VIEN);

            //NODE CHAM CÔNG TỪ EXCEL

            treeView1.Nodes[1].Nodes[1].Nodes.Add(THEO_THOI_GIAN);
            treeView1.Nodes[1].Nodes[1].Nodes.Add(LAM_THEM_THEO_THOI_GIAN);
            treeView1.Nodes[1].Nodes[1].Nodes.Add(THEO_NGAY);
         //   treeView1.Nodes[1].Nodes[1].Nodes.Add(CHAM_CONG_SAN_PHAM);
         //   treeView1.Nodes[1].Nodes[1].Nodes.Add(CHAM_CONG_LAM_THEM_SAN_PHAM);
            treeView1.Nodes[1].Nodes[1].Nodes.Add(CAC_LOAI_TIEN_KHAC);

            //NODE CON CỦA THEO SẢN PHẨM
           // treeView1.Nodes[1].Nodes[1].Nodes[3].Nodes.Add(DANH_MUC_SAN_PHAM);

            //NODE CON CỦA BÁO CÁO
            treeView1.Nodes[2].Nodes.Add(BANG_LUONG);
            treeView1.Nodes[2].Nodes.Add(PHIEU_LUONG);

            treeView1.ImageList = m_img_list;

            CAI_DAT_THAM_SO.ImageIndex = 4;
            CAI_DAT_THAM_SO.SelectedImageIndex = 4;
            BAO_CAO.ImageIndex = 3;
            BAO_CAO.SelectedImageIndex = 3;
            NHAP_LIEU.ImageIndex = 5;
            NHAP_LIEU.SelectedImageIndex = 5;

            
            
        }

        private void ShowForm(Form v_f)
        {
            v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            v_f.Dock = DockStyle.Fill;
            v_f.Show();
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            foreach (Form form in panel2.Controls.OfType<Form>().ToArray())
            {
                form.Close();
            }
            TreeViewHitTestInfo info = treeView1.HitTest(treeView1.PointToClient(Cursor.Position));


           
          
            if (info.Node == DANG_NHAP_HE_THONG)
            {
                BKI_DichVuMatDat.CAI_DAT.DANG_NHAP_HE_THONG v_f = new BKI_DichVuMatDat.CAI_DAT.DANG_NHAP_HE_THONG();
                v_f.TopLevel = false;
                panel2.Controls.Add(v_f);
                ShowForm(v_f);
            }
            if (info.Node == CAC_HINH_THUC_TINH_LUONG)
            {     
                CAC_HINH_THUC_TINH_LUONG v_f = new CAC_HINH_THUC_TINH_LUONG();        
                v_f.TopLevel = false;
                panel2.Controls.Add(v_f);
                ShowForm(v_f);
               
            }

            if (info.Node == SO_NGAY_CONG_TIEU_CHUAN)
            {
                F100_NgayCongTieuChuan v_f = new F100_NgayCongTieuChuan();
                v_f.TopLevel = false;
                panel2.Controls.Add(v_f);
                ShowForm(v_f);
               
            }

            if (info.Node == DANH_MUC)
            {
                THAM_SO_CHAM_CONG_THOI_GIAN v_f = new THAM_SO_CHAM_CONG_THOI_GIAN();
                v_f.TopLevel = false;
                panel2.Controls.Add(v_f);
                ShowForm(v_f);
            }

            if (info.Node == THAM_SO_KHAC)
            {
                THAM_SO_KHAC v_f = new THAM_SO_KHAC();
                v_f.TopLevel = false;
                panel2.Controls.Add(v_f);
                ShowForm(v_f);
            }

            if (info.Node == THEM_MOI_NHAN_VIEN)
            {
                THEM_MOI_NHAN_VIEN v_f = new THEM_MOI_NHAN_VIEN();
                v_f.TopLevel = false;
                panel2.Controls.Add(v_f);
                ShowForm(v_f);
            }

            if (info.Node == SUA_NHAN_VIEN)
            {
                SEARCH_NHAN_VIEN v_f = new SEARCH_NHAN_VIEN();
                decimal m_open_form_thong_tin=-1;
                decimal m_id_nhan_vien = -1;
                //-1 là đóng, 1 là mở
                v_f.Show_for_search(ref m_open_form_thong_tin, ref m_id_nhan_vien);
                if (m_open_form_thong_tin == 1)
                {
                    THEM_MOI_NHAN_VIEN v_form = new THEM_MOI_NHAN_VIEN();
                    v_form.TopLevel = false;
                    panel2.Controls.Add(v_form);
                    ShowForUpdateForm(v_form, m_id_nhan_vien);
                }
            }


            if (info.Node == THEO_THOI_GIAN)
            {
                F696_Cham_cong_xls v_f = new F696_Cham_cong_xls();
                v_f.TopLevel = false;
                panel2.Controls.Add(v_f);
                ShowForm(v_f);
            }

            if (info.Node == LAM_THEM_THEO_THOI_GIAN)
            {
                BKI_DichVuMatDat.NghiepVu.THEOTHOIGIAN.LAM_THEM_THEO_THOI_GIAN v_f = new BKI_DichVuMatDat.NghiepVu.THEOTHOIGIAN.LAM_THEM_THEO_THOI_GIAN();
                v_f.TopLevel = false;
                panel2.Controls.Add(v_f);
                 ShowForm(v_f);
            }

            if (info.Node == THEO_NGAY)
            {
                CHAM_CONG_THEO_NGAY v_f = new CHAM_CONG_THEO_NGAY();
                v_f.TopLevel = false;
                panel2.Controls.Add(v_f);
                ShowForm(v_f);
            }

            if (info.Node == CHAM_CONG_SAN_PHAM)
            {
                BKI_DichVuMatDat.NghiepVu.ChamCongSanPham.CHAM_CONG_THEO_SAN_PHAM v_f = new CHAM_CONG_THEO_SAN_PHAM();
                v_f.TopLevel = false;
                panel2.Controls.Add(v_f);
                ShowForm(v_f);
            }

            if (info.Node == DANH_MUC_SAN_PHAM)
            {
                BKI_DichVuMatDat.NghiepVu.ChamCongSanPham.DANH_MUC_SAN_PHAM v_f = new DANH_MUC_SAN_PHAM();
                v_f.TopLevel = false;
                panel2.Controls.Add(v_f);
                ShowForm(v_f);
            }

            if (info.Node == CAC_LOAI_TIEN_KHAC)
            {
                BKI_DichVuMatDat.NghiepVu.CAC_LOAI_TIEN_KHAC v_f = new NghiepVu.CAC_LOAI_TIEN_KHAC();
                v_f.TopLevel = false;
                panel2.Controls.Add(v_f);
                ShowForm(v_f);
            }

            if (info.Node == BANG_LUONG)
            {
                panel1.Visible = false;
                BKI_DichVuMatDat.BaoCao.f412_rpt_tong_hop_tt_v2 v_f= new BaoCao.f412_rpt_tong_hop_tt_v2();
                //v_f.TopLevel = false;
                //panel2.Controls.Add(v_f);
                //v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                //v_f.Dock = DockStyle.Fill;
                //v_f.Show();
              //  v_f.TopMost = true;
                v_f.FormBorderStyle = FormBorderStyle.None;
                v_f.WindowState = FormWindowState.Maximized;
                v_f.ShowDialog();
               // ShowForm(v_f);
                panel1.Visible = true;
            }

            if (info.Node == PHIEU_LUONG)
            {
                BKI_DichVuMatDat.BaoCao.Luong.PHIEU_LUONG v_f = new BaoCao.Luong.PHIEU_LUONG();
                v_f.TopLevel = false;
                panel2.Controls.Add(v_f);
                ShowForm(v_f);
            }

        }

        private void ShowForm(FORM_CHO_CHAM_CONG_THEO_THOI_GIAN v_f)
        {
            throw new NotImplementedException();
        }

        private void ShowForUpdateForm(BKI_DichVuMatDat.THEM_MOI_NHAN_VIEN v_f, decimal m_id_nhan_vien)
        {
            v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            v_f.Dock = DockStyle.Fill;
            v_f.ShowForUpdateInform(m_id_nhan_vien);
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                var v_result = XtraMessageBox.Show("Bạn có muốn đăng xuất khỏi phần mềm tính lương?", "Thông báo", MessageBoxButtons.OKCancel);
                if (v_result == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                XtraMessageBox.Show(v_e.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == CAI_DAT_THAM_SO || e.Node == NHAP_LIEU || e.Node == BAO_CAO)
            {
                return;
            }
            e.Node.SelectedImageIndex = 6;
        }
    }
}
