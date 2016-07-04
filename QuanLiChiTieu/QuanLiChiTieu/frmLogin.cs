using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using Microsoft.Win32;
using QuanLiChiTieu.Properties;
using System.Threading;



namespace QuanLiChiTieu
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public bool _hide = false;
        private bool _open = true;
        private int _count;
        private WMPLib.WindowsMediaPlayer truePlayer = new WMPLib.WindowsMediaPlayer();
        private WMPLib.WindowsMediaPlayer falsePlayer = new WMPLib.WindowsMediaPlayer();
        private bool IsvalidUser(string userName, string password)
        {

            DataClasses1DataContext context = new DataClasses1DataContext();
            var q = from p in context.DangNhaps
                    where p.tendangnhap == loginUC1.UserName
                    && p.matkhau == loginUC1.PassWord
                    select p;


            if (q.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public frmLogin()
        {
            InitializeComponent();
            loginUC1.OnLoginControlOkButtonClicked += new LoginUC.OkButtonClickedEventHandler(OnLGOkButtonClicked);
            loginUC1.OnLoginControlCancelButtonClicked += new LoginUC.CancelButtonClickedEventHandler(loginUC1_OnLoginControlCancelButtonClicked);
        }

        void loginUC1_OnLoginControlCancelButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }



        public void OnLGOkButtonClicked(object sender, EventArgs e)
        {
            if (_open == true)
            {
                if (IsvalidUser(loginUC1.UserName, loginUC1.PassWord))
                {
                    truePlayer.controls.play();
                    Hide();
                    _open = false;
                    frmTrangChinh _frmTrangChinh = new frmTrangChinh();
                    Thread.Sleep(2000);
                    _frmTrangChinh.Show();
                    
                }
                else
                {
                    if (_count > 3)
                    {
                        falsePlayer.controls.play();
                        MessageBox.Show("Bạn đã đăng nhập sai quá 3 lần cho phép. Phần mềm sẽ tự đóng lại", "Error");
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã đăng nhập sai. Xin vui lòng đăng nhập lại", "Error");
                        _count++;
                    }
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _count = 0;
            loginUC1.UserName = "admin";
            truePlayer.URL = @"D:\CLOUDS\OneDrive\STUDY\SEMESTER 4\Visual Programming\Do AN\New folder\Quan ly chi tieu ca nhan\Quan ly chi tieu ca nhan\DXApplication6\Sound\choose.mp3";
            falsePlayer.URL = @"D:\CLOUDS\OneDrive\STUDY\SEMESTER 4\Visual Programming\Do AN\New folder\Quan ly chi tieu ca nhan\Quan ly chi tieu ca nhan\DXApplication6\Sound\false.mp3";
            falsePlayer.controls.stop();
            truePlayer.controls.stop();
        }
    }
}