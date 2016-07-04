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
    public partial class Vi : UserControl
    {
        public Vi()
        {
            InitializeComponent();
        }
        private DataClasses1DataContext vi = new DataClasses1DataContext();
        private void refresh()
        {
            try
            {
                var chi =
                           from c in
                               (from a in vi.Chitieus
                                where a.Tài_Khoản == "Ví"
                                select new { a.Tài_Khoản, a.Số_Tiền, a.Ngày }
                               ).Union(
                               from b in vi.Chovays
                               where b.Tài_Khoản == "Ví"
                               select new { b.Tài_Khoản, b.Số_Tiền, b.Ngày }
                               ).Union(
                               from d in vi.Tranos
                               where d.Tài_Khoản == "Ví"
                               select new { d.Tài_Khoản, d.Số_Tiền, d.Ngày }
                               )
                           group c by new { c.Ngày, c.Tài_Khoản } into g
                           select new { Ngay = g.Key.Ngày, Tàikhoản = g.Key.Tài_Khoản, SốTien = g.Sum(x => x.Số_Tiền) };
                dataGridView1.DataSource = chi;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh1()
        {
            try
            {
                var chi =
                       from c in
                           (from a in vi.Divays
                            where a.Tài_Khoản == "Ví"
                            select new { a.Tài_Khoản, a.Số_Tiền, a.Ngày }
                           ).Union(
                           from b in vi.Thunos
                           where b.Tài_Khoản == "Ví"
                           select new { b.Tài_Khoản, b.Số_Tiền, b.Ngày }
                           ).Union(
                           from d in vi.Thunhaps
                           where d.Tài_Khoản == "Ví"
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
        private void button2_Click(object sender, EventArgs e)
        {
            refresh1();
        }

        private void Vi_Load(object sender, EventArgs e)
        {
            try
            {
                var chi = from c in
                              (from a in vi.Chitieus
                               where a.Tài_Khoản == "Ví"
                               select new { a.Số_Tiền, a.Tài_Khoản }
                                   ).Union(
                                   from b in vi.Chovays
                                   where b.Tài_Khoản == "Ví"
                                   select new
                                   {
                                       b.Số_Tiền,
                                       b.Tài_Khoản
                                   }
                                   ).Union(from d in vi.Tranos
                                           where d.Tài_Khoản == "Ví"
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
                              (from a in vi.Thunos
                               where a.Tài_Khoản == "Ví"
                               select new { a.Số_Tiền, a.Tài_Khoản }
                                   ).Union(
                                   from b in vi.Divays
                                   where b.Tài_Khoản == "Ví"
                                   select new { b.Số_Tiền, b.Tài_Khoản }
                                   ).Union(from d in vi.Thunhaps
                                           where d.Tài_Khoản == "Ví"
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
                MessageBox.Show(""+ex.Message);
            }
            
        }
    }
}
