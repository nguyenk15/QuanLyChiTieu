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
    public partial class DiVay : UserControl
    {
        public DiVay()
        {
            InitializeComponent();
        }
        DataClasses1DataContext linq = new DataClasses1DataContext();
        private void refresh()
        {
            //dataGridView1.Rows.Clear();
            // lay toan bo du lieu trong dtb
            var list = from a in linq.Divays
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
                    Divay a = new Divay();
                    a.Người_Cho_Vay = txtBoxNguoiVay.Text;
                    a.Số_Tiền = Convert.ToInt32(txtBoxSoTien.Text);
                    a.Mục_Đích = txtBoxMucDich.Text;
                    a.Ngày = dateTimePicker1.Value;
                    a.Tài_Khoản = txtTaikhoan.Text;
                    if (rtxtBoxDienGiai.Text == "")
                        a.Diễn_Giải = "";
                    a.Diễn_Giải = rtxtBoxDienGiai.Text;
                    linq.Divays.InsertOnSubmit(a);
                    linq.SubmitChanges();
                    MessageBox.Show("Đã Lưu", "Thông báo");
                    refresh();
                }
                else
                {
                    MessageBox.Show("Xin nhập người cho vay", "Thông báo");
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
                var xoa = linq.Divays.Single(a => a.ID.ToString() == dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                linq.Divays.DeleteOnSubmit(xoa);
                linq.SubmitChanges();
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

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            txtBoxNgay.Text = dateTimePicker1.Value.ToShortDateString();
        }
    }
}
