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
    public partial class ChiTieu : UserControl
    {
        private DataClasses1DataContext linq = new DataClasses1DataContext();
        private DateTime dt;
        public ChiTieu()
        {
            InitializeComponent();
        }
        
        private void refresh ()
        {
            //dataGridView1.Rows.Clear();
            // lay toan bo du lieu trong dtb
            var list = from a in linq.Chitieus
                       where a.ID == a.ID
                       select a;
            dataGridView1.DataSource = list;
          //  dataGridView1.ReadOnly = true;
        }

        private void BangChi_Load(object sender, EventArgs e)
        {
            try
            {
                dt = DateTime.Now;
                txtSoLuong.Text = "1";
                txtGiaTien.Text = "0";
                txtTaikhoan.SelectedIndex = 0;
                txtMucDich.SelectedIndex = 0;
                txtBoxNgayMua.Text = dt.ToShortDateString();
                txtMucDich.SelectedIndex = 0;
                txtTaikhoan.SelectedIndex = 0;
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtBoxNgayMua.Text = dateTimePicker1.Value.ToShortDateString();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var xoa = linq.Chitieus.Single(a => a.ID.ToString() == dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                linq.Chitieus.DeleteOnSubmit(xoa);
                linq.SubmitChanges();
                MessageBox.Show("Đã xóa", "Thông báo");
                refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Không còn cột nào để xóa");
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Chitieu b = linq.Chitieus.Single(a => dataGridView1.CurrentRow.Cells["ID"].Value.ToString() == a.ID.ToString());
                b.Tên_SP = dataGridView1.CurrentRow.Cells["Tên_SP"].Value.ToString();
                //b.Tài_Khoản = dataGridView1.CurrentRow.Cells["Tài_khoản"].Value.ToString();
               // dataGridView1.CurrentRow.Cells["Tài_khoản"].Value.ToString() = b.Tài_Khoản;
                b.Số_Lượng = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Số_Lượng"].Value);
                b.Ngày = dateTimePicker1.Value;
                b.Mục_Đích = dataGridView1.CurrentRow.Cells["Mục_Đích"].Value.ToString();
                b.Số_Tiền = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Giá_Tiền"].Value);
                
                linq.SubmitChanges();
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxTenSP.Text != "")
                {
                    Chitieu a = new Chitieu();
                    if (txtBoxTenSP.Text == "")
                        a.Tên_SP = "";
                    a.Tên_SP = txtBoxTenSP.Text;
                    a.Số_Tiền = Convert.ToInt32(txtGiaTien.Text);
                    a.Mục_Đích = txtMucDich.Text;
                    a.Ngày = dateTimePicker1.Value;
                    a.Tài_Khoản = txtTaikhoan.Text;
                    a.Số_Lượng = Convert.ToInt32(txtSoLuong.Text);
                    linq.Chitieus.InsertOnSubmit(a);
                    linq.SubmitChanges();
                    MessageBox.Show("Saved", "Thông báo");
                    refresh();
                }
                else
                {
                    MessageBox.Show("Xin vui lòng nhập tên sản phẩm", "Thông báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string temp = dataGridView1.CurrentRow.Cells["Tài_khoản"].Value.ToString() ;
                if (temp != txtTaikhoan.SelectedText.ToString())
                {
                    MessageBox.Show("Error");
                    refresh();
                }
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }







    }
}
