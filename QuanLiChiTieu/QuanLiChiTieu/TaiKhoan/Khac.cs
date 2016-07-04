using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiChiTieu.TaiKhoan
{
    public partial class Khac : UserControl
    {
        public Khac()
        {
            InitializeComponent();
        }
        private DataClasses1DataContext Khác = new DataClasses1DataContext();
        private void refresh()
        {
            try
            {
                var chi =
                           from c in
                               (from a in Khác.Chitieus
                                where a.Tài_Khoản == "Khác"
                                select new { a.Tài_Khoản, a.Số_Tiền, a.Ngày }
                               ).Union(
                               from b in Khác.Chovays
                               where b.Tài_Khoản == "Khác"
                               select new { b.Tài_Khoản, b.Số_Tiền, b.Ngày }
                               ).Union(
                               from d in Khác.Tranos
                               where d.Tài_Khoản == "Khác"
                               select new { d.Tài_Khoản, d.Số_Tiền, d.Ngày }
                               )
                           group c by new { c.Ngày, c.Tài_Khoản } into g
                           select new { Ngay = g.Key.Ngày, Tàikhoản = g.Key.Tài_Khoản, SốTien = g.Sum(x => x.Số_Tiền) };
                dataGridView1.DataSource = chi;
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex.Message);
            }
            
        }
        private void refresh1()
        {
            try
            {
                var chi =
                       from c in
                           (from a in Khác.Divays
                            where a.Tài_Khoản == "Khác"
                            select new { a.Tài_Khoản, a.Số_Tiền, a.Ngày }
                           ).Union(
                           from b in Khác.Thunos
                           where b.Tài_Khoản == "Khác"
                           select new { b.Tài_Khoản, b.Số_Tiền, b.Ngày }
                           ).Union(
                           from d in Khác.Thunhaps
                           where d.Tài_Khoản == "Khác"
                           select new { d.Tài_Khoản, d.Số_Tiền, d.Ngày }
                           )
                       group c by new { c.Ngày, c.Tài_Khoản } into g
                       select new { Ngay = g.Key.Ngày, Tàikhoản = g.Key.Tài_Khoản, SốTien = g.Sum(x => x.Số_Tiền) };
                dataGridView2.DataSource = chi;
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex.Message);
            }
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            refresh();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            refresh1();
        }

        private void Khác_Load_1(object sender, EventArgs e)
        {
            try
            {
                var chi = from c in
                              (from a in Khác.Chitieus
                               where a.Tài_Khoản == "Khác"
                               select new { a.Số_Tiền, a.Tài_Khoản }
                                   ).Union(
                                   from b in Khác.Chovays
                                   where b.Tài_Khoản == "Khác"
                                   select new
                                   {
                                       b.Số_Tiền,
                                       b.Tài_Khoản
                                   }
                                   ).Union(from d in Khác.Tranos
                                           where d.Tài_Khoản == "Khác"
                                           select new { d.Số_Tiền, d.Tài_Khoản }
                                   )
                          group c by new { c.Tài_Khoản } into g
                          select g.Sum(x => x.Số_Tiền);
                foreach (var t in chi)
                {
                    if (t.ToString() != "0")
                        textBox1.Text = t.ToString();
                    else
                        textBox1.Text = "0";
                }

                var thu = from c in
                              (from a in Khác.Thunos
                               where a.Tài_Khoản == "Khác"
                               select new { a.Số_Tiền, a.Tài_Khoản }
                                   ).Union(
                                   from b in Khác.Divays
                                   where b.Tài_Khoản == "Khác"
                                   select new { b.Số_Tiền, b.Tài_Khoản }
                                   ).Union(from d in Khác.Thunhaps
                                           where d.Tài_Khoản == "Khác"
                                           select new { d.Số_Tiền, d.Tài_Khoản }
                                   )
                          group c by new { c.Tài_Khoản } into g
                          select g.Sum(x => x.Số_Tiền);
                foreach (var t in thu)
                {
                    if (t.ToString() != "0")
                        textBox2.Text = t.ToString();
                    else
                        textBox2.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            
        }
    }
}
