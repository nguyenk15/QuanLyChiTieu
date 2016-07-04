using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiChiTieu.GhiChep.Chi
{
    public partial class ChoVay : UserControl
    {
        public ChoVay()
        {
            InitializeComponent();
        }
        private DataClasses1DataContext cv = new DataClasses1DataContext();
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           txtBoxNgay.Text = dateTimePicker1.Value.ToShortDateString();
        }
        private void refresh()
        {
            //dataGridView1.Rows.Clear();
            // lay toan bo du lieu trong dtb
            var list = from a in cv.Chovays
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
                    Chovay a = new Chovay();
                    if (txtBoxNguoiVay.Text == "")
                        a.Người_Vay = "";
                    a.Người_Vay = txtBoxNguoiVay.Text;
                    if (txtBoxSoTien.Text == "")
                        a.Số_Tiền = 0;
                    a.Số_Tiền = Convert.ToInt32(txtBoxSoTien.Text);
                    if (rtxtBoxDienGiai.Text == "")
                        a.Diễn_Giải = "";
                    a.Diễn_Giải = rtxtBoxDienGiai.Text;
                    a.Ngày = dateTimePicker1.Value;
                    a.Mục_Đích = txtBoxMucDich.Text;
                    a.Tài_Khoản = txtTaikhoan.Text;
                    cv.Chovays.InsertOnSubmit(a);
                    cv.SubmitChanges();
                    MessageBox.Show("Saved", "Thông báo");
                    refresh();
                }
            }
            catch (Exception ex){
                MessageBox.Show(""+ex.Message);
            }
        }

        private void ChoVay_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Now;
                txtBoxNgay.Text = dt.ToShortDateString();
                txtBoxSoTien.Text = "0";
                txtTaikhoan.SelectedIndex = 0;
                refresh();
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
                var xoa = cv.Chovays.Single(a => a.ID.ToString() == dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                cv.Chovays.DeleteOnSubmit(xoa);
                cv.SubmitChanges();
                MessageBox.Show("Deleted", "Thông báo");
                refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Không có dữ liệu nào để xóa");
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Chovay b = cv.Chovays.Single(a => dataGridView1.CurrentRow.Cells["ID"].Value.ToString() == a.ID.ToString());
                b.Diễn_Giải = dataGridView1.CurrentRow.Cells["Diễn_Giải"].Value.ToString();
                b.Mục_Đích = dataGridView1.CurrentRow.Cells["Mục_Đích"].Value.ToString();
                b.Người_Vay = dataGridView1.CurrentRow.Cells["Người_Vay"].Value.ToString();
                b.Số_Tiền = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Số_Tiền"].Value.ToString());
                b.Ngày = dateTimePicker1.Value;
                b.Tài_Khoản = dataGridView1.CurrentRow.Cells["Tài_Khoản"].Value.ToString();
                cv.SubmitChanges();
                MessageBox.Show("Updated", "Thông báo");
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            
        }

   

    }
}
