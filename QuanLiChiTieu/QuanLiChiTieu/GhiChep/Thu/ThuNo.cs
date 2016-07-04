using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiChiTieu.GhiChep.Thu
{
    public partial class ThuNo : UserControl
    {
        public ThuNo()
        {
            InitializeComponent();
        }
        DataClasses1DataContext tn = new DataClasses1DataContext();
        private void refresh()
        {
            //dataGridView1.Rows.Clear();
            // lay toan bo du lieu trong dtb
            var list = from a in tn.Thunos
                       where a.ID == a.ID
                       select a;
            dataGridView1.DataSource = list;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNguoiVay.Text != "")
                {
                    Thuno a = new Thuno();
                    a.Người_Vay = txtBoxNguoiVay.Text;
                    a.Số_Tiền = Convert.ToInt32(txtBoxSoTien.Text);
                    a.Mục_Đích = txtBoxMucDich.Text;
                    a.Ngày = dateTimePicker1.Value;
                    a.Tài_Khoản = txtTaikhoan.Text;
                    if (rtxtBoxDienGiai.Text == "")
                        a.Diễn_Giải = "";
                    a.Diễn_Giải = rtxtBoxDienGiai.Text;
                    tn.Thunos.InsertOnSubmit(a);
                    tn.SubmitChanges();
                    MessageBox.Show("Đã Lưu", "Thông báo");
                    refresh();
                }
                else
                {
                    MessageBox.Show("Xin nhập người vay tiền của bạn", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var xoa = tn.Thunos.Single(a => a.ID.ToString() == dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                tn.Thunos.DeleteOnSubmit(xoa);
                tn.SubmitChanges();
                MessageBox.Show("Đã xóa", "Thông báo");
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Thuno b = tn.Thunos.Single(a => dataGridView1.CurrentRow.Cells["ID"].Value.ToString() == a.ID.ToString());
                b.Diễn_Giải = dataGridView1.CurrentRow.Cells["Diễn_Giải"].Value.ToString();
                b.Mục_Đích = dataGridView1.CurrentRow.Cells["Mục"].Value.ToString();
                b.Số_Tiền = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Số_Tiền"].Value.ToString());
                b.Ngày = dateTimePicker1.Value;
                b.Tài_Khoản = dataGridView1.CurrentRow.Cells["Tài_Khoản"].Value.ToString();
                tn.SubmitChanges();
                MessageBox.Show("Updated", "Thông báo");
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }

        }

        private void ThuNo_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            txtBoxNgay.Text = dt.ToShortDateString();
            txtTaikhoan.SelectedIndex = 1;
            refresh();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtBoxNgay.Text = dateTimePicker1.Value.ToShortDateString();
        }
    }
}
