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
    public partial class TrongKhoang : UserControl
    {
        public TrongKhoang()
        {
            InitializeComponent();
        }
        private DataClasses1DataContext thang = new DataClasses1DataContext();
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker2.Value.ToShortDateString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToShortDateString();
        }
        private void chi()
        {
            try
            {
                var chi = from c in
                              (from a in thang.Chitieus
                               select new { a.Số_Tiền, a.Tài_Khoản, a.Ngày, a.Mục_Đích }
                              ).Union(
                              from b in thang.Tranos
                              select new { b.Số_Tiền, b.Tài_Khoản, b.Ngày, b.Mục_Đích }
                              ).Union(
                              from d in thang.Chovays
                              select new { d.Số_Tiền, d.Tài_Khoản, d.Ngày, d.Mục_Đích }
                              )
                          where DateTime.Parse(textBox1.Text) <= c.Ngày && c.Ngày <= DateTime.Parse(textBox2.Text)
                          select new
                          {
                              Ngay = c.Ngày,
                              Sotien = c.Số_Tiền,
                              TaiKhoan = c.Tài_Khoản,
                              MucDich = c.Mục_Đích
                          };
                dataGridView1.DataSource = chi;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            
        }
        private void thu()
        {
            try
            {
                var thu = from c in
                          (from a in thang.Thunos
                           select new { a.Số_Tiền, a.Tài_Khoản, a.Ngày, a.Mục_Đích }
                          ).Union(
                          from b in thang.Thunhaps
                          select new { b.Số_Tiền, b.Tài_Khoản, b.Ngày, b.Mục_Đích }
                          ).Union(
                          from d in thang.Divays
                          select new { d.Số_Tiền, d.Tài_Khoản, d.Ngày, d.Mục_Đích }
                          )
                      where c.Ngày >= DateTime.Parse(textBox1.Text) && c.Ngày <= DateTime.Parse(textBox2.Text)
                      select new
                      {
                          Ngay = c.Ngày,
                          Sotien = c.Số_Tiền,
                          TaiKhoan = c.Tài_Khoản,
                          MucDich = c.Mục_Đích,
                      };

            dataGridView2.DataSource = thu;
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            chi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thu();
        }
    }
}
