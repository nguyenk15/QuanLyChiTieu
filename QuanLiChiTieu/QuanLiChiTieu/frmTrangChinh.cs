using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace QuanLiChiTieu
{
    public partial class frmTrangChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private WMPLib.WindowsMediaPlayer choose = new WMPLib.WindowsMediaPlayer();
        public frmTrangChinh()
        {
            InitializeComponent();
        }
        

        public void ChangeVisible(object sender, EventArgs e)
        {
            if (((Control)sender).Visible == true)
            {
                foreach (var item in panel1.Controls)
                {
                    if (item != (Control)sender)
                        ((Control)item).Visible = false;
                        
                }
            }
        }

        private void barButtonGCTongQuan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choose.controls.play();
            home1.Visible = true;
            home1.Show();
        }

        private void barButtonTongChi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choose.controls.play();
            tongChi1.Visible = true;
            tongChi1.Show();
        }

        private void barButtonGCChi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choose.controls.play();
            choose.controls.play();
            chiTieu1.Visible = true;
            chiTieu1.Show();

        }

        private void barButtonGCChoVay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choose.controls.play();
            choVay1.Visible = true;
            choVay1.Show();
        }
        private void barButtonGCDiVay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choose.controls.play();
            diVay1.Visible = true;
            diVay1.Show();
        }

        private void barButtonGCTraNo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choose.controls.play();
            traNo1.Visible = true;
            traNo1.Show();
        }


        private void barButtonGCTongThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choose.controls.play();
            tongThu1.Visible = true;
            tongThu1.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choose.controls.play();
            thuNhap1.Visible = true;
            thuNhap1.Show();
        }

        private void barButtonGCThuNo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choose.controls.play();
            thuNo1.Visible = true;
            thuNo1.Show();
        }

        private void barButtonTKSoTietKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choose.controls.play();
            soTietKiem1.Visible = true;
            soTietKiem1.Show();
        }
        private Icon ico;
        private void Main_Load(object sender, EventArgs e)
        {
            home1.Visible = true;
            home1.Show();
            defaultLookAndFeel1.LookAndFeel.SkinMaskColor = Properties.Settings.Default.SkinMaskColor1;
            defaultLookAndFeel1.LookAndFeel.SkinMaskColor2 = Properties.Settings.Default.SkinMaskColor2;
            ico = notifyIcon1.Icon;
            this.Hide();
            choose.URL = @"D:\CLOUDS\OneDrive\STUDY\SEMESTER 4\Visual Programming\Do AN\New folder\Quan ly chi tieu ca nhan\Quan ly chi tieu ca nhan\DXApplication6\Sound\choose.mp3";
        }



        private void frmTrangChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonThietLap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSetting _frmSetting = new frmSetting();
            _frmSetting.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            choose.controls.play();
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choose.controls.play();
            this.Show();
        }

        private void barButtonAn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void barButtonHide_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choose.controls.play();
            frmSetting _frmSetting = new frmSetting();
            _frmSetting.ShowDialog();
        }

        private void frmTrangChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SkinMaskColor1 = defaultLookAndFeel1.LookAndFeel.SkinMaskColor;
            Properties.Settings.Default.Save();
        }

        private void barButtonExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void barButtonTKVi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choose.controls.play();
            vi1.Visible = true;
            vi1.Show();
        }

        private void barButtonTKATM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choose.controls.play();
            atm1.Visible = true;
            atm1.Show();
        }

        private void bBTKKhac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choose.controls.play();
            khac1.Visible = true;
            khac1.Show();
        }

        private void barButtonBCHienTai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choose.controls.play();
            ngay1.Visible = true;
            ngay1.Show();
        }

        private void barButtonBCTrongKhoang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choose.controls.play();
            trongKhoang1.Visible = true;
            trongKhoang1.Show();
        }


        private void barButtonThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choose.controls.play();
            frmThongTin _frmThongTin = new frmThongTin();
            _frmThongTin.ShowDialog();
        }

        private void barButtonTroGiup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choose.controls.play();
            frmTroGiup _frmTroGiup = new frmTroGiup();
            _frmTroGiup.ShowDialog();
        }

        private void barButtonGCTongQuan_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            choose.controls.play();
            home1.Visible = true;
            home1.Show();
        }












        










      


    }
}
