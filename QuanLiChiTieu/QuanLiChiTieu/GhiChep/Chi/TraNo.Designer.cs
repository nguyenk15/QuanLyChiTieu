namespace QuanLiChiTieu.GhiChep.Chi
{
    partial class TraNo
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
            this.txtTaikhoan = new System.Windows.Forms.ComboBox();
            this.buttonSua = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxMucDich = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.rtxtBoxDienGiai = new System.Windows.Forms.RichTextBox();
            this.txtBoxNgay = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNguoiVay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxSoTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.txtTaikhoan.Location = new System.Drawing.Point(106, 134);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(97, 21);
            this.txtTaikhoan.TabIndex = 46;
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(13, 280);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 23);
            this.buttonSua.TabIndex = 45;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Tình hình trả nợ";
            // 
            // txtBoxMucDich
            // 
            this.txtBoxMucDich.Location = new System.Drawing.Point(273, 134);
            this.txtBoxMucDich.Name = "txtBoxMucDich";
            this.txtBoxMucDich.ReadOnly = true;
            this.txtBoxMucDich.Size = new System.Drawing.Size(53, 20);
            this.txtBoxMucDich.TabIndex = 43;
            this.txtBoxMucDich.Text = "Trả nợ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Mục Đích";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(13, 233);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(132, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(538, 197);
            this.dataGridView1.TabIndex = 40;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(13, 182);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rtxtBoxDienGiai
            // 
            this.rtxtBoxDienGiai.Location = new System.Drawing.Point(398, 58);
            this.rtxtBoxDienGiai.Name = "rtxtBoxDienGiai";
            this.rtxtBoxDienGiai.Size = new System.Drawing.Size(272, 96);
            this.rtxtBoxDienGiai.TabIndex = 38;
            this.rtxtBoxDienGiai.Text = "";
            // 
            // txtBoxNgay
            // 
            this.txtBoxNgay.Location = new System.Drawing.Point(250, 93);
            this.txtBoxNgay.Name = "txtBoxNgay";
            this.txtBoxNgay.ReadOnly = true;
            this.txtBoxNgay.Size = new System.Drawing.Size(57, 20);
            this.txtBoxNgay.TabIndex = 37;
            this.txtBoxNgay.Text = "__/__/___";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(303, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(23, 20);
            this.dateTimePicker1.TabIndex = 36;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Từ Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Diễn giải";
            // 
            // txtBoxNguoiVay
            // 
            this.txtBoxNguoiVay.Location = new System.Drawing.Point(106, 59);
            this.txtBoxNguoiVay.Name = "txtBoxNguoiVay";
            this.txtBoxNguoiVay.Size = new System.Drawing.Size(220, 20);
            this.txtBoxNguoiVay.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Người cho vay";
            // 
            // txtBoxSoTien
            // 
            this.txtBoxSoTien.Location = new System.Drawing.Point(78, 93);
            this.txtBoxSoTien.Name = "txtBoxSoTien";
            this.txtBoxSoTien.Size = new System.Drawing.Size(125, 20);
            this.txtBoxSoTien.TabIndex = 30;
            this.txtBoxSoTien.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Số Tiền";
            // 
            // TraNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxNguoiVay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxSoTien);
            this.Controls.Add(this.label1);
            this.Name = "TraNo";
            this.Size = new System.Drawing.Size(705, 363);
            this.Load += new System.EventHandler(this.ChoVay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtTaikhoan;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxMucDich;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RichTextBox rtxtBoxDienGiai;
        private System.Windows.Forms.TextBox txtBoxNgay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNguoiVay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxSoTien;
        private System.Windows.Forms.Label label1;



    }
}
