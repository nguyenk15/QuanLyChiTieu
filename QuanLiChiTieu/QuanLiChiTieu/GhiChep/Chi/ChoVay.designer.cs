namespace QuanLiChiTieu.GhiChep.Chi
{
    partial class ChoVay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxSoTien = new System.Windows.Forms.TextBox();
            this.txtBoxNguoiVay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBoxNgay = new System.Windows.Forms.TextBox();
            this.rtxtBoxDienGiai = new System.Windows.Forms.RichTextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtBoxMucDich = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSua = new System.Windows.Forms.Button();
            this.txtTaikhoan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Tiền";
            // 
            // txtBoxSoTien
            // 
            this.txtBoxSoTien.Location = new System.Drawing.Point(75, 92);
            this.txtBoxSoTien.Name = "txtBoxSoTien";
            this.txtBoxSoTien.Size = new System.Drawing.Size(125, 20);
            this.txtBoxSoTien.TabIndex = 1;
            // 
            // txtBoxNguoiVay
            // 
            this.txtBoxNguoiVay.Location = new System.Drawing.Point(75, 58);
            this.txtBoxNguoiVay.Name = "txtBoxNguoiVay";
            this.txtBoxNguoiVay.Size = new System.Drawing.Size(248, 20);
            this.txtBoxNguoiVay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Người vay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Diễn giải";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Từ Tài Khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(300, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(23, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtBoxNgay
            // 
            this.txtBoxNgay.Location = new System.Drawing.Point(244, 92);
            this.txtBoxNgay.Name = "txtBoxNgay";
            this.txtBoxNgay.ReadOnly = true;
            this.txtBoxNgay.Size = new System.Drawing.Size(69, 20);
            this.txtBoxNgay.TabIndex = 10;
            this.txtBoxNgay.Text = "__/__/___";
            // 
            // rtxtBoxDienGiai
            // 
            this.rtxtBoxDienGiai.Location = new System.Drawing.Point(395, 57);
            this.rtxtBoxDienGiai.Name = "rtxtBoxDienGiai";
            this.rtxtBoxDienGiai.Size = new System.Drawing.Size(272, 96);
            this.rtxtBoxDienGiai.TabIndex = 13;
            this.rtxtBoxDienGiai.Text = "";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(10, 232);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(129, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(538, 197);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(10, 181);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtBoxMucDich
            // 
            this.txtBoxMucDich.Location = new System.Drawing.Point(270, 133);
            this.txtBoxMucDich.Name = "txtBoxMucDich";
            this.txtBoxMucDich.ReadOnly = true;
            this.txtBoxMucDich.Size = new System.Drawing.Size(53, 20);
            this.txtBoxMucDich.TabIndex = 25;
            this.txtBoxMucDich.Text = "Cho Vay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Mục Đích";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tình hình cho vay";
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(10, 279);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 23);
            this.buttonSua.TabIndex = 27;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTaikhoan.FormattingEnabled = true;
            this.txtTaikhoan.Items.AddRange(new object[] {
            "Ví",
            "ATM",
            "Sổ Tiết Kiệm",
            "Khác"});
            this.txtTaikhoan.Location = new System.Drawing.Point(103, 133);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(97, 21);
            this.txtTaikhoan.TabIndex = 28;
            // 
            // ChoVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxMucDich);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.rtxtBoxDienGiai);
            this.Controls.Add(this.txtBoxNgay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxNguoiVay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxSoTien);
            this.Controls.Add(this.label1);
            this.Name = "ChoVay";
            this.Size = new System.Drawing.Size(705, 363);
            this.Load += new System.EventHandler(this.ChoVay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSoTien;
        private System.Windows.Forms.TextBox txtBoxNguoiVay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBoxNgay;
        private System.Windows.Forms.RichTextBox rtxtBoxDienGiai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtBoxMucDich;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.ComboBox txtTaikhoan;
    }
}
