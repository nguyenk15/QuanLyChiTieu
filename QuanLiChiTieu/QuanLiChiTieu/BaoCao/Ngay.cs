using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiChiTieu.BaoCao
{
    public partial class Ngay : UserControl
    {
        public Ngay()
        {
            InitializeComponent();
        }
        DataClasses1DataContext ngay = new DataClasses1DataContext();
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtBoxNgay.Text = dateTimePicker1.Value.ToShortDateString();
        }
        private void refreshchi()
        {
            var chi = from c in
                          (from a in ngay.Chitieus
                           //where a.Ngày.ToString() == textBox1.Text
                           select new { a.Số_Tiền, a.Tài_Khoản, a.Ngày, a.Mục_Đích }
                          ).Union(
                          from b in ngay.Tranos
                          //where b.Ngày.ToString() == textBox1.Text
                          select new { b.Số_Tiền, b.Tài_Khoản, b.Ngày, b.Mục_Đích }
                          ).Union(
                          from d in ngay.Chovays
                          //where d.Ngày.ToString() == textBox1.Text
                          select new { d.Số_Tiền, d.Tài_Khoản, d.Ngày, d.Mục_Đích }
                          )
                      //select new { c.Số_Tiền, c.Tài_Khoản, c.Ngày, c.Mục_Đích };
                      where c.Ngày == DateTime.Parse( txtBoxNgay.Text)
                      select new
                      {
                          Sotien = c.Số_Tiền,
                          TaiKhoan = c.Tài_Khoản,
                          MucDich = c.Mục_Đích
                      };

            dataGridView2.DataSource = chi;
        }
        private void refeshthu()
        {
            var thu = from c in
                          (from a in ngay.Thunos
                           //where a.Ngày.ToString() == textBox1.Text
                           select new { a.Số_Tiền, a.Tài_Khoản, a.Ngày, a.Mục_Đích }
                          ).Union(
                          from b in ngay.Thunhaps
                          //where b.Ngày.ToString() == textBox1.Text
                          select new { b.Số_Tiền, b.Tài_Khoản, b.Ngày, b.Mục_Đích }
                          ).Union(
                          from d in ngay.Divays
                          //where d.Ngày.ToString() == textBox1.Text
                          select new { d.Số_Tiền, d.Tài_Khoản, d.Ngày, d.Mục_Đích }
                          )
                      //select new { c.Số_Tiền, c.Tài_Khoản, c.Ngày, c.Mục_Đích };
                      where c.Ngày == DateTime.Parse(txtBoxNgay.Text)
                      select new
                      {
                          Sotien = c.Số_Tiền,
                          TaiKhoan = c.Tài_Khoản,
                          MucDich = c.Mục_Đích,
                      };

            dataGridView1.DataSource = thu;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            refreshchi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refeshthu();
        }

        private void Ngay_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            txtBoxNgay.Text = dt.ToShortDateString();

        }


    }
}
