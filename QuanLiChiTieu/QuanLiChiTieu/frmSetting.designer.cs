namespace QuanLiChiTieu
{
    partial class frmSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gBKhoiDong = new System.Windows.Forms.GroupBox();
            this.ButtonSkinMaskColor1 = new System.Windows.Forms.Button();
            this.gBGiaoDien = new System.Windows.Forms.GroupBox();
            this.txtBoxSkinMaskColor2 = new System.Windows.Forms.TextBox();
            this.txtBoxSkinMaskColor1 = new System.Windows.Forms.TextBox();
            this.buttonSkinMaskColor2 = new System.Windows.Forms.Button();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gBGiaoDien.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(45, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Khởi động cùng Windows";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // gBKhoiDong
            // 
            this.gBKhoiDong.Location = new System.Drawing.Point(25, 39);
            this.gBKhoiDong.Name = "gBKhoiDong";
            this.gBKhoiDong.Size = new System.Drawing.Size(200, 44);
            this.gBKhoiDong.TabIndex = 2;
            this.gBKhoiDong.TabStop = false;
            this.gBKhoiDong.Text = "Khởi động";
            // 
            // ButtonSkinMaskColor1
            // 
            this.ButtonSkinMaskColor1.Location = new System.Drawing.Point(20, 20);
            this.ButtonSkinMaskColor1.Name = "ButtonSkinMaskColor1";
            this.ButtonSkinMaskColor1.Size = new System.Drawing.Size(109, 23);
            this.ButtonSkinMaskColor1.TabIndex = 3;
            this.ButtonSkinMaskColor1.Text = "Skin Mask Color 1";
            this.ButtonSkinMaskColor1.UseVisualStyleBackColor = true;
            this.ButtonSkinMaskColor1.Click += new System.EventHandler(this.ButtonChangeColor_Click);
            // 
            // gBGiaoDien
            // 
            this.gBGiaoDien.Controls.Add(this.txtBoxSkinMaskColor2);
            this.gBGiaoDien.Controls.Add(this.txtBoxSkinMaskColor1);
            this.gBGiaoDien.Controls.Add(this.buttonSkinMaskColor2);
            this.gBGiaoDien.Controls.Add(this.ButtonSkinMaskColor1);
            this.gBGiaoDien.Location = new System.Drawing.Point(25, 101);
            this.gBGiaoDien.Name = "gBGiaoDien";
            this.gBGiaoDien.Size = new System.Drawing.Size(200, 88);
            this.gBGiaoDien.TabIndex = 4;
            this.gBGiaoDien.TabStop = false;
            this.gBGiaoDien.Text = "Giao diện";
            // 
            // txtBoxSkinMaskColor2
            // 
            this.txtBoxSkinMaskColor2.Location = new System.Drawing.Point(149, 49);
            this.txtBoxSkinMaskColor2.Name = "txtBoxSkinMaskColor2";
            this.txtBoxSkinMaskColor2.Size = new System.Drawing.Size(35, 21);
            this.txtBoxSkinMaskColor2.TabIndex = 6;
            // 
            // txtBoxSkinMaskColor1
            // 
            this.txtBoxSkinMaskColor1.Location = new System.Drawing.Point(149, 22);
            this.txtBoxSkinMaskColor1.Name = "txtBoxSkinMaskColor1";
            this.txtBoxSkinMaskColor1.Size = new System.Drawing.Size(35, 21);
            this.txtBoxSkinMaskColor1.TabIndex = 5;
            // 
            // buttonSkinMaskColor2
            // 
            this.buttonSkinMaskColor2.Location = new System.Drawing.Point(20, 49);
            this.buttonSkinMaskColor2.Name = "buttonSkinMaskColor2";
            this.buttonSkinMaskColor2.Size = new System.Drawing.Size(109, 23);
            this.buttonSkinMaskColor2.TabIndex = 4;
            this.buttonSkinMaskColor2.Text = "Skin Mask Color 2";
            this.buttonSkinMaskColor2.UseVisualStyleBackColor = true;
            this.buttonSkinMaskColor2.Click += new System.EventHandler(this.buttonSkinMaskColor2_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.defaultLookAndFeel1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Black;
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Black";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(25, 214);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(150, 214);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmSetting
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 261);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.gBKhoiDong);
            this.Controls.Add(this.gBGiaoDien);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSetting_FormClosing);
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.gBGiaoDien.ResumeLayout(false);
            this.gBGiaoDien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox gBKhoiDong;
        private System.Windows.Forms.Button ButtonSkinMaskColor1;
        private System.Windows.Forms.GroupBox gBGiaoDien;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Button buttonSkinMaskColor2;
        private System.Windows.Forms.TextBox txtBoxSkinMaskColor2;
        private System.Windows.Forms.TextBox txtBoxSkinMaskColor1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnReset;
    }
}