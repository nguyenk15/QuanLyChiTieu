namespace QuanLiChiTieu.GhiChep.Thu
{
    partial class ThuNo
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
            this.label = new System.Windows.Forms.Label();
            this.txtBoxNguoiVay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rtxtBoxDienGiai = new System.Windows.Forms.RichTextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxMucDich = new System.Windows.Forms.TextBox();
            this.txtBoxNgay = new System.Windows.Forms.TextBox();
            this.txtTaikhoan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Số Tiền";
            // 
            // txtBoxSoTien
            // 
            this.txtBoxSoTien.Location = new System.Drawing.Point(85, 95);
            this.txtBoxSoTien.Name = "txtBoxSoTien";
            this.txtBoxSoTien.Size = new System.Drawing.Size(125, 20);
            this.txtBoxSoTien.TabIndex = 48;
            this.txtBoxSoTien.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 62);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 13);
            this.label.TabIndex = 49;
            this.label.Text = "Người vay";
            // 
            // txtBoxNguoiVay
            // 
            this.txtBoxNguoiVay.Location = new System.Drawing.Point(85, 59);
            this.txtBoxNguoiVay.Name = "txtBoxNguoiVay";
            this.txtBoxNguoiVay.Size = new System.Drawing.Size(253, 20);
            this.txtBoxNguoiVay.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Diễn giải";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Từ Tài Khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Ngày";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(315, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(23, 20);
            this.dateTimePicker1.TabIndex = 55;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // rtxtBoxDienGiai
            // 
            this.rtxtBoxDienGiai.Location = new System.Drawing.Point(443, 59);
            this.rtxtBoxDienGiai.Name = "rtxtBoxDienGiai";
            this.rtxtBoxDienGiai.Size = new System.Drawing.Size(230, 96);
            this.rtxtBoxDienGiai.TabIndex = 59;
            this.rtxtBoxDienGiai.Text = "";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(20, 177);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 60;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(117, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 187);
            this.dataGridView1.TabIndex = 61;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(20, 228);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 62;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(20, 279);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 63;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Mục Thu";
            // 
            // txtBoxMucDich
            // 
            this.txtBoxMucDich.Location = new System.Drawing.Point(285, 129);
            this.txtBoxMucDich.Name = "txtBoxMucDich";
            this.txtBoxMucDich.ReadOnly = true;
            this.txtBoxMucDich.Size = new System.Drawing.Size(53, 20);
            this.txtBoxMucDich.TabIndex = 67;
            this.txtBoxMucDich.Text = "Thu Nợ";
            // 
            // txtBoxNgay
            // 
            this.txtBoxNgay.Location = new System.Drawing.Point(261, 94);
            this.txtBoxNgay.Name = "txtBoxNgay";
            this.txtBoxNgay.ReadOnly = true;
            this.txtBoxNgay.Size = new System.Drawing.Size(57, 20);
            this.txtBoxNgay.TabIndex = 68;
            this.txtBoxNgay.Text = "__/__/___";
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
            this.txtTaikhoan.Location = new System.Drawing.Point(113, 128);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(97, 21);
            this.txtTaikhoan.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Tình hình thu nợ";
            // 
            // ThuNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.txtBoxNgay);
            this.Controls.Add(this.txtBoxMucDich);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.rtxtBoxDienGiai);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxNguoiVay);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtBoxSoTien);
            this.Controls.Add(this.label1);
            this.Name = "ThuNo";
            this.Size = new System.Drawing.Size(705, 363);
            this.Load += new System.EventHandler(this.ThuNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSoTien;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtBoxNguoiVay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox rtxtBoxDienGiai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxMucDich;
        private System.Windows.Forms.TextBox txtBoxNgay;
        private System.Windows.Forms.ComboBox txtTaikhoan;
        private System.Windows.Forms.Label label2;


    }
}
