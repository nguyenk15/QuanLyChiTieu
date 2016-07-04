using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiChiTieu
{
    public partial class TongQuan : UserControl
    {
        public TongQuan()
        {
            InitializeComponent();
        }
        private DataClasses1DataContext linq = new DataClasses1DataContext();
        private void Home_Load(object sender, EventArgs e)
        {
            TongChiNgay();
            TongThuNgay();
            TaiKhoanATM();
            TaiKhoanSTK();
            TaiKhoanKhac();
            TaiKhoanVi();
            try
            {
                txtBoxTKCon.Text = (Int32.Parse(txtBoxVi.Text) + Int32.Parse(txtBoxATM.Text) + Int32.Parse(txtBoxKhac.Text) + Int32.Parse(txtBoxSoTietKiem.Text)).ToString();
                txtBoxCon.Text = ((Int32.Parse(txtTongThuNgay.Text) - Int32.Parse(txtBoxTongChiNgay.Text)).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            
        }

        private void TongChiNgay()
        {
            int Vi = 0;
            int ATM = 0;
            int SoTietKiem = 0;
            int TKKhac = 0;
            var vi = from c in
                         (from a in linq.Chitieus
                          where a.Tài_Khoản == "Ví"
                          select new { a.Số_Tiền, a.Tài_Khoản }
                              ).Union(
                              from b in linq.Chovays
                              where b.Tài_Khoản == "Ví"
                              select new
                              {
                                  b.Số_Tiền,
                                  b.Tài_Khoản
                              }
                              ).Union(from d in linq.Tranos
                                      where d.Tài_Khoản == "Ví"
                                      select new { d.Số_Tiền, d.Tài_Khoản }
                              )
                     group c by new { c.Tài_Khoản } into g
                     select g.Sum(x => x.Số_Tiền);
            foreach (var t in vi)
            {
                if (t != 0)
                    Vi = Int32.Parse(t.ToString());
                else
                    Vi = 0;
            }
            var atm = from c in
                          (from a in linq.Chitieus
                           where a.Tài_Khoản == "ATM"
                           select new { a.Số_Tiền, a.Tài_Khoản }
                               ).Union(
                               from b in linq.Chovays
                               where b.Tài_Khoản == "ATM"
                               select new
                               {
                                   b.Số_Tiền,
                                   b.Tài_Khoản
                               }
                               ).Union(from d in linq.Tranos
                                       where d.Tài_Khoản == "ATM"
                                       select new { d.Số_Tiền, d.Tài_Khoản }
                               )
                      group c by new { c.Tài_Khoản } into g
                      select g.Sum(x => x.Số_Tiền);
            foreach (var t in atm)
            {
                if (t.ToString() != "0")
                    ATM = Int32.Parse(t.ToString());
                else
                    ATM = 0;
            }
            var STK = from c in
                          (from a in linq.Chitieus
                           where a.Tài_Khoản == "Sổ Tiết Kiệm"
                           select new { a.Số_Tiền, a.Tài_Khoản }
                               ).Union(
                               from b in linq.Chovays
                               where b.Tài_Khoản == "Sổ Tiết Kiệm"
                               select new
                               {
                                   b.Số_Tiền,
                                   b.Tài_Khoản
                               }
                               ).Union(from d in linq.Tranos
                                       where d.Tài_Khoản == "Sổ Tiết Kiệm"
                                       select new { d.Số_Tiền, d.Tài_Khoản }
                               )
                      group c by new { c.Tài_Khoản } into g
                      select g.Sum(x => x.Số_Tiền);
            foreach (var t in STK)
            {
                if (t.ToString() != "0")
                    SoTietKiem = Int32.Parse(t.ToString());
                else
                    SoTietKiem = 0;
            }
            var Khac = from c in
                           (from a in linq.Chitieus
                            where a.Tài_Khoản == "Khác"
                            select new { a.Số_Tiền, a.Tài_Khoản }
                                ).Union(
                                from b in linq.Chovays
                                where b.Tài_Khoản == "Khác"
                                select new
                                {
                                    b.Số_Tiền,
                                    b.Tài_Khoản
                                }
                                ).Union(from d in linq.Tranos
                                        where d.Tài_Khoản == "Khác"
                                        select new { d.Số_Tiền, d.Tài_Khoản }
                                )
                       group c by new { c.Tài_Khoản } into g
                       select g.Sum(x => x.Số_Tiền);
            foreach (var t in Khac)
            {
                if (t.ToString() != "0")
                    TKKhac = Int32.Parse(t.ToString());
                else
                    TKKhac = 0;
            }
            try
            {
                int tong = TKKhac + ATM + SoTietKiem + Vi;
                txtBoxTongChiNgay.Text = tong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex.Message);
            }
        }
        private void TongThuNgay()
        {
            int TKVi = 0;
            int TKATM = 0;
            int TKSoTietKiem = 0;
            int TKKhac = 0;

            var vi = from c in
                         (from a in linq.Divays
                          where a.Tài_Khoản == "Ví"
                          select new { a.Số_Tiền, a.Tài_Khoản }
                              ).Union(
                              from b in linq.Thunhaps
                              where b.Tài_Khoản == "Ví"
                              select new
                              {
                                  b.Số_Tiền,
                                  b.Tài_Khoản
                              }
                              ).Union(from d in linq.Thunos
                                      where d.Tài_Khoản == "Ví"
                                      select new { d.Số_Tiền, d.Tài_Khoản }
                              )
                     group c by new { c.Tài_Khoản } into g
                     select g.Sum(x => x.Số_Tiền);
            foreach (var t in vi)
            {
                if (t.ToString() != "0")
                    TKVi = Int32.Parse(t.ToString());
                else
                    TKVi = 0;
            }
            var atm = from c in
                          (from a in linq.Divays
                           where a.Tài_Khoản == "ATM"
                           select new { a.Số_Tiền, a.Tài_Khoản }
                               ).Union(
                               from b in linq.Thunhaps
                               where b.Tài_Khoản == "ATM"
                               select new
                               {
                                   b.Số_Tiền,
                                   b.Tài_Khoản
                               }
                               ).Union(from d in linq.Thunos
                                       where d.Tài_Khoản == "ATM"
                                       select new { d.Số_Tiền, d.Tài_Khoản }
                               )
                      group c by new { c.Tài_Khoản } into g
                      select g.Sum(x => x.Số_Tiền);
            foreach (var t in atm)
            {
                if (t.ToString() != "0")
                    TKATM = Int32.Parse(t.ToString());
                else
                    TKATM = 0;
            }
            var STK = from c in
                          (from a in linq.Divays
                           where a.Tài_Khoản == "Sổ Tiết Kiệm"
                           select new { a.Số_Tiền, a.Tài_Khoản }
                               ).Union(
                               from b in linq.Thunhaps
                               where b.Tài_Khoản == "Sổ Tiết Kiệm"
                               select new
                               {
                                   b.Số_Tiền,
                                   b.Tài_Khoản
                               }
                               ).Union(from d in linq.Thunos
                                       where d.Tài_Khoản == "Sổ Tiết Kiệm"
                                       select new { d.Số_Tiền, d.Tài_Khoản }
                               )
                      group c by new { c.Tài_Khoản } into g
                      select g.Sum(x => x.Số_Tiền);
            foreach (var t in STK)
            {
                if (t.ToString() != "0")
                    TKSoTietKiem = Int32.Parse(t.ToString());
                else
                    TKSoTietKiem = 0;
            }
            var Khac = from c in
                           (from a in linq.Divays
                            where a.Tài_Khoản == "Khác"
                            select new { a.Số_Tiền, a.Tài_Khoản }
                                ).Union(
                                from b in linq.Thunhaps
                                where b.Tài_Khoản == "Khác"
                                select new
                                {
                                    b.Số_Tiền,
                                    b.Tài_Khoản
                                }
                                ).Union(from d in linq.Thunos
                                        where d.Tài_Khoản == "Khác"
                                        select new { d.Số_Tiền, d.Tài_Khoản }
                                )
                       group c by new { c.Tài_Khoản } into g
                       select g.Sum(x => x.Số_Tiền);
            foreach (var t in Khac)
            {
                if (t.ToString() != "0")
                    TKKhac = Int32.Parse(t.ToString());
                else
                    TKKhac = 0;
            }
            try
            {
                txtTongThuNgay.Text = (TKVi + TKATM + TKKhac + TKSoTietKiem).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex.Message);
            }
        }
        private void TaiKhoanATM()
        {
            int _Chi = 0;
            int _Thu = 0;
            try
            {
                var chi = from c in
                              (from a in linq.Chitieus
                               where a.Tài_Khoản == "ATM"
                               select new { a.Số_Tiền, a.Tài_Khoản }
                                   ).Union(
                                   from b in linq.Chovays
                                   where b.Tài_Khoản == "ATM"
                                   select new
                                   {
                                       b.Số_Tiền,
                                       b.Tài_Khoản
                                   }
                                   ).Union(from d in linq.Tranos
                                           where d.Tài_Khoản == "ATM"
                                           select new { d.Số_Tiền, d.Tài_Khoản }
                                   )
                          group c by new { c.Tài_Khoản } into g
                          select g.Sum(x => x.Số_Tiền);
                foreach (var t in chi)
                {
                    if (t.ToString() != "0")
                        _Chi = Int32.Parse(t.ToString());
                    else
                        _Chi = 0;
                }

                var thu = from c in
                              (from a in linq.Thunos
                               where a.Tài_Khoản == "ATM"
                               select new { a.Số_Tiền, a.Tài_Khoản }
                                   ).Union(
                                   from b in linq.Divays
                                   where b.Tài_Khoản == "ATM"
                                   select new { b.Số_Tiền, b.Tài_Khoản }
                                   ).Union(from d in linq.Thunhaps
                                           where d.Tài_Khoản == "ATM"
                                           select new { d.Số_Tiền, d.Tài_Khoản }
                                   )
                          group c by new { c.Tài_Khoản } into g
                          select g.Sum(x => x.Số_Tiền);
                foreach (var t in thu)
                {
                    if (t.ToString() != "0")
                        _Thu = Int32.Parse(t.ToString());
                    else
                        _Thu = 0;
                }
                txtBoxATM.Text = (-_Chi + _Thu).ToString();
            }
                

            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            
        }
        private void TaiKhoanKhac()
        {
            int _Chi = 0;
            int _Thu = 0;
            try
            {
                var chi = from c in
                              (from a in linq.Chitieus
                               where a.Tài_Khoản == "Khác"
                               select new { a.Số_Tiền, a.Tài_Khoản }
                                   ).Union(
                                   from b in linq.Chovays
                                   where b.Tài_Khoản == "Khác"
                                   select new
                                   {
                                       b.Số_Tiền,
                                       b.Tài_Khoản
                                   }
                                   ).Union(from d in linq.Tranos
                                           where d.Tài_Khoản == "Khác"
                                           select new { d.Số_Tiền, d.Tài_Khoản }
                                   )
                          group c by new { c.Tài_Khoản } into g
                          select g.Sum(x => x.Số_Tiền);
                foreach (var t in chi)
                {
                    if (t.ToString() != "0")
                        _Chi = Int32.Parse(t.ToString());
                    else
                        _Chi = 0;
                }

                var thu = from c in
                              (from a in linq.Thunos
                               where a.Tài_Khoản == "Khác"
                               select new { a.Số_Tiền, a.Tài_Khoản }
                                   ).Union(
                                   from b in linq.Divays
                                   where b.Tài_Khoản == "Khác"
                                   select new { b.Số_Tiền, b.Tài_Khoản }
                                   ).Union(from d in linq.Thunhaps
                                           where d.Tài_Khoản == "Khác"
                                           select new { d.Số_Tiền, d.Tài_Khoản }
                                   )
                          group c by new { c.Tài_Khoản } into g
                          select g.Sum(x => x.Số_Tiền);
                foreach (var t in thu)
                {
                    if (t.ToString() != "0")
                        _Thu = Int32.Parse(t.ToString());
                    else
                        _Thu = 0;
                }
                txtBoxKhac.Text = (-_Chi + _Thu).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }
        private void TaiKhoanSTK()
        {
            int _Thu = 0;
            int _Chi = 0;
            try
            {
                var chi = from c in
                              (from a in linq.Chitieus
                               where a.Tài_Khoản == "Sổ Tiết Kiệm"
                               select new { a.Số_Tiền, a.Tài_Khoản }
                                   ).Union(
                                   from b in linq.Chovays
                                   where b.Tài_Khoản == "Sổ Tiết Kiệm"
                                   select new
                                   {
                                       b.Số_Tiền,
                                       b.Tài_Khoản
                                   }
                                   ).Union(from d in linq.Tranos
                                           where d.Tài_Khoản == "Sổ Tiết Kiệm"
                                           select new { d.Số_Tiền, d.Tài_Khoản }
                                   )
                          group c by new { c.Tài_Khoản } into g
                          select g.Sum(x => x.Số_Tiền);
                foreach (var t in chi)
                {
                    if (t.ToString() != "0")
                        _Chi = Int32.Parse(t.ToString());
                    else
                        _Chi = 0;
                }
                var thu = from c in
                              (from a in linq.Thunos
                               where a.Tài_Khoản == "Sổ Tiết Kiệm"
                               select new { a.Số_Tiền, a.Tài_Khoản }
                                   ).Union(
                                   from b in linq.Divays
                                   where b.Tài_Khoản == "Sổ Tiết Kiệm"
                                   select new { b.Số_Tiền, b.Tài_Khoản }
                                   ).Union(from d in linq.Thunhaps
                                           where d.Tài_Khoản == "Sổ Tiết Kiệm"
                                           select new { d.Số_Tiền, d.Tài_Khoản }
                                   )
                          group c by new { c.Tài_Khoản } into g
                          select g.Sum(x => x.Số_Tiền);
                foreach (var t in thu)
                {
                    if (t.ToString() != "0")
                        _Thu = Int32.Parse(t.ToString());
                    else
                        _Thu = 0;
                }
                txtBoxSoTietKiem.Text = (_Thu-_Chi).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }
        private void TaiKhoanVi()
        {
            int _Thu = 0;
            int _Chi = 0;
            try
            {
                var chi = from c in
                              (from a in linq.Chitieus
                               where a.Tài_Khoản == "Ví"
                               select new { a.Số_Tiền, a.Tài_Khoản }
                                   ).Union(
                                   from b in linq.Chovays
                                   where b.Tài_Khoản == "Ví"
                                   select new
                                   {
                                       b.Số_Tiền,
                                       b.Tài_Khoản
                                   }
                                   ).Union(from d in linq.Tranos
                                           where d.Tài_Khoản == "Ví"
                                           select new { d.Số_Tiền, d.Tài_Khoản }
                                   )
                          group c by new { c.Tài_Khoản } into g
                          select g.Sum(x => x.Số_Tiền);
                foreach (var t in chi)
                {
                    if (t.ToString() != "0")
                        _Chi = Int32.Parse(t.ToString());
                    else
                        _Chi = 0;
                }

                var thu = from c in
                              (from a in linq.Thunos
                               where a.Tài_Khoản == "Ví"
                               select new { a.Số_Tiền, a.Tài_Khoản }
                                   ).Union(
                                   from b in linq.Divays
                                   where b.Tài_Khoản == "Ví"
                                   select new { b.Số_Tiền, b.Tài_Khoản }
                                   ).Union(from d in linq.Thunhaps
                                           where d.Tài_Khoản == "Ví"
                                           select new { d.Số_Tiền, d.Tài_Khoản }
                                   )
                          group c by new { c.Tài_Khoản } into g
                          select g.Sum(x => x.Số_Tiền);
                foreach (var t in thu)
                {
                    if (t.ToString() != "0")
                        _Thu = Int32.Parse(t.ToString());
                    else
                        _Thu = 0;
                }
                txtBoxVi.Text = (_Thu - _Chi).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }


    }
}
