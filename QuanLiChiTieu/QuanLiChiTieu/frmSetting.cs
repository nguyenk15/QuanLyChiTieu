using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Win32;

namespace QuanLiChiTieu
{
    public partial class frmSetting : DevExpress.XtraEditors.XtraForm
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                RegisterInStartup(true);
                MessageBox.Show("Đã khởi động cùng windows");
                Properties.Settings.Default.KhoiDong = true;
            }
            else
            {
                RegisterInStartup(false);
                MessageBox.Show("Đã tắt khởi động cùng windows");
                Properties.Settings.Default.KhoiDong = true;
            }
        }
        private void RegisterInStartup(bool isChecked)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (isChecked)
            {
                registryKey.SetValue("ApplicationName", Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue("ApplicationName");
            }
        }

        private void ButtonChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            DialogResult result = color.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                defaultLookAndFeel1.LookAndFeel.SkinMaskColor = color.Color;
                txtBoxSkinMaskColor1.BackColor = color.Color;          
            }
        }

        private void frmSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void buttonSkinMaskColor2_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            DialogResult result = color.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                defaultLookAndFeel1.LookAndFeel.SkinMaskColor2 = color.Color;
                txtBoxSkinMaskColor2.BackColor = color.Color;
            }
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            defaultLookAndFeel1.LookAndFeel.SkinMaskColor = Properties.Settings.Default.SkinMaskColor1;
            defaultLookAndFeel1.LookAndFeel.SkinMaskColor2 = Properties.Settings.Default.SkinMaskColor2;
            txtBoxSkinMaskColor2.BackColor = defaultLookAndFeel1.LookAndFeel.SkinMaskColor2;
            txtBoxSkinMaskColor1.BackColor = defaultLookAndFeel1.LookAndFeel.SkinMaskColor;
            checkBox1.Checked = Properties.Settings.Default.KhoiDong;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SkinMaskColor1 = defaultLookAndFeel1.LookAndFeel.SkinMaskColor;
            Properties.Settings.Default.SkinMaskColor2 = defaultLookAndFeel1.LookAndFeel.SkinMaskColor2;
            txtBoxSkinMaskColor2.BackColor = defaultLookAndFeel1.LookAndFeel.SkinMaskColor2;
            txtBoxSkinMaskColor1.BackColor = defaultLookAndFeel1.LookAndFeel.SkinMaskColor;
            Properties.Settings.Default.KhoiDong = checkBox1.Checked;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxSkinMaskColor1.BackColor = Color.Green;
            txtBoxSkinMaskColor2.BackColor = Color.White;
            defaultLookAndFeel1.LookAndFeel.SkinMaskColor = txtBoxSkinMaskColor1.BackColor;
            defaultLookAndFeel1.LookAndFeel.SkinMaskColor2 = txtBoxSkinMaskColor2.BackColor;
            checkBox1.Checked = false;
        }
    }
}