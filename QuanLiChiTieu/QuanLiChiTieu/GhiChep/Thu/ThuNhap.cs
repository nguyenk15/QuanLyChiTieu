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
    public partial class ThuNhap : UserControl
    {
        private DataClasses1DataContext tn = new DataClasses1DataContext();
        public ThuNhap()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            //dataGridView1.Rows.Clear();
            // lay toan bo du lieu trong dtb
            var list = from a in tn.Thunhaps
                       where a.ID == a.ID
                       select a;
            dataGridView1.DataSource = list;
        }
        private void ThuNhap_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            txtBoxNgay.Text = dt.ToShortDateString();
            cBoxMucChi.SelectedIndex= 0;
            txtTaikhoan.SelectedIndex = 1;
            refresh();
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            txtBoxNgay.Text = dateTimePicker2.Value.ToShortDateString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxSoTien.Text != "")
                {
                    Thunhap a = new Thunhap();
                    a.Số_Tiền = Convert.ToInt32(txtBoxSoTien.Text);
                    a.Mục_Đích = cBoxMucChi.Text;
                    a.Ngày = dateTimePicker2.Value;
                    a.Tài_Khoản = txtTaikhoan.Text;
                    if (rtxtBoxDienGiai.Text == "")
                        a.Diễn_Giải = "";
                    a.Diễn_Giải = rtxtBoxDienGiai.Text;
                    tn.Thunhaps.InsertOnSubmit(a);
                    tn.SubmitChanges();
                    MessageBox.Show("Đã Lưu", "Thông báo");
                    refresh();
                }
                else
                {
                    MessageBox.Show("Xin nhập số tiền của bạn","Thông báo");
                }
            }
            catch (Exception ex){
                MessageBox.Show(""+ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var xoa = tn.Thunhaps.Single(a => a.ID.ToString() == dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                tn.Thunhaps.DeleteOnSubmit(xoa);
                tn.SubmitChanges();
                MessageBox.Show("deleted", "Thông báo");
                refresh();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Thunhap b = tn.Thunhaps.Single(a => dataGridView1.CurrentRow.Cells["ID"].Value.ToString() == a.ID.ToString());
                b.Diễn_Giải = dataGridView1.CurrentRow.Cells["Diễn_Giải"].Value.ToString();
                b.Mục_Đích = dataGridView1.CurrentRow.Cells["Mục"].Value.ToString();
                b.Số_Tiền = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Số_Tiền"].Value.ToString());
                b.Ngày = dateTimePicker2.Value;
                b.Tài_Khoản = dataGridView1.CurrentRow.Cells["Tài_Khoản"].Value.ToString();
                tn.SubmitChanges();
                MessageBox.Show("Updated", "Thông báo");
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex.Message);
            }
            
        }

    
    }
}
