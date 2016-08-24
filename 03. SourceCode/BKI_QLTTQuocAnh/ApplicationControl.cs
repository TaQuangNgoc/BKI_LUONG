using System;
using System.Diagnostics;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using IP.Core.IPUserService;
using BKI_DichVuMatDat;

using BKI_DichVuMatDat.CONFIRM;
using System.Data;


namespace BKI_DichVuMatDat
{
    #region Nhiệm vụ của Class
    //*********************************************************************************
    //*  Là khởi động và điều khiển dăng nhập mới vào  Hệ thống
    //*  - hiện thị form login
    //*  - nếu OK thì tạo context và hiện thị form main, User không muốn vào thì thoát ra
    //*  - nếu trở lại từ main theo kiểu login mới thì lại hiện thị form login
    //*  - nếu trở lại từ main theo kiểu "exit from system" thì thoát
    //*********************************************************************************
    #endregion


    public class ApplicationControl
    {
        [STAThread]
        static void Main()
        {

            try
            {
                DevExpress.Skins.SkinManager.Default.RegisterAssembly(
                    typeof(DevExpress.UserSkins.MetropolisDark).Assembly
                    );

                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(
                    "Metropolis Dark 4 Touch"
                );

                DevExpress.Skins.SkinManager.EnableFormSkins();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Form1 v_f = new Form1();
                v_f.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
