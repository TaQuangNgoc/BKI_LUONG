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
    public partial class FORM_MENU : Form
    {
        TreeNode CAI_DAT_THAM_SO = new TreeNode("Cài đặt tham số");
        TreeNode NHAP_LIEU = new TreeNode("Nhập liệu");
        TreeNode BAO_CAO = new TreeNode("Báo cáo");
        //NODE CỦA CỦA CÀI ĐẶT THAM SỐ
        TreeNode CAC_HINH_THUC_TINH_LUONG = new TreeNode("Các hình thức tính lương");
        TreeNode MA_NHAN_VIEN = new TreeNode("Mã nhân viên");
        TreeNode CHAM_CONG_THEO_TG = new TreeNode("Chấm công theo thời gian");
        TreeNode SO_NGAY_CONG_TIEU_CHUAN = new TreeNode("Số ngày công tiêu chuẩn");
        TreeNode DANH_MUC = new TreeNode("Danh Mục");
        TreeNode THAM_SO_KHAC = new TreeNode("Tham số khác");

        //NODE CON CỦA NHẬP LIỆU
        TreeNode THONG_TIN_NHAN_VIEN = new TreeNode("Thông tin nhân viên");    
        TreeNode CHAM_CONG_TU_EXCEL = new TreeNode("Chấm công từ excel");
        //NODE CON CỦA thông tin nhân viên

        TreeNode THEM_MOI_NHAN_VIEN = new TreeNode("Thêm mới nhân viên");
        TreeNode SUA_NHAN_VIEN = new TreeNode("Sửa thông tin nhân viên");
        TreeNode XOA_NHAN_VIEN = new TreeNode("Xóa bỏ nhân viên");

        //NODE CON CỦA CHẤM CÔNG TỪ EXCEL
        TreeNode THEO_THOI_GIAN = new TreeNode("Theo thời gian");
        TreeNode THEO_NGAY = new TreeNode("Theo ngày");

        public FORM_MENU()
        {
            InitializeComponent();
            Init_tree_view();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
           
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
            treeView1.Nodes[0].Nodes.Add(MA_NHAN_VIEN);
            //ADD CHẤM CÔNG THEO THỜI GIAN
            treeView1.Nodes[0].Nodes.Add(CHAM_CONG_THEO_TG);
            treeView1.Nodes[0].Nodes[2].Nodes.Add(DANH_MUC);
            treeView1.Nodes[0].Nodes[2].Nodes.Add(SO_NGAY_CONG_TIEU_CHUAN);
            treeView1.Nodes[0].Nodes[2].Nodes.Add(THAM_SO_KHAC);
            treeView1.ItemHeight = 35;

            //node Nhập liệu
            treeView1.Nodes[1].Nodes.Add(THONG_TIN_NHAN_VIEN);
            treeView1.Nodes[1].Nodes.Add(CHAM_CONG_TU_EXCEL);
          

            //node thông tin nhân viên
            treeView1.Nodes[1].Nodes[0].Nodes.Add(THEM_MOI_NHAN_VIEN);
            treeView1.Nodes[1].Nodes[0].Nodes.Add(SUA_NHAN_VIEN);
            treeView1.Nodes[1].Nodes[0].Nodes.Add(XOA_NHAN_VIEN);

            //NODE CHAM CÔNG TỪ EXCEL

            treeView1.Nodes[1].Nodes[1].Nodes.Add(THEO_THOI_GIAN);
            treeView1.Nodes[1].Nodes[1].Nodes.Add(THEO_NGAY);

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
            if (info.Node == CAC_HINH_THUC_TINH_LUONG)
            {     
                CAC_HINH_THUC_TINH_LUONG v_f = new CAC_HINH_THUC_TINH_LUONG();        
                v_f.TopLevel = false;
                panel2.Controls.Add(v_f);
                ShowForm(v_f);
               
            }

            if (info.Node == SO_NGAY_CONG_TIEU_CHUAN)
            {
                SO_NGAY_CONG_TIEU_CHUAN v_f = new SO_NGAY_CONG_TIEU_CHUAN();
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

            if (info.Node == MA_NHAN_VIEN)
            {
                MA_NHAN_VIEN v_f = new MA_NHAN_VIEN();
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
        }

      


    }
}
