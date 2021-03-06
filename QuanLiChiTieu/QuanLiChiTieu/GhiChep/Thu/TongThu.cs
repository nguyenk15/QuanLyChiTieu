﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiChiTieu.GhiChep.Thu
{
    public partial class TongThu : UserControl
    {
        public TongThu()
        {
            InitializeComponent();
        }
        private DataClasses1DataContext linq = new DataClasses1DataContext();
        private void refresh()
        {
            var tongthu =
                            from c in
                                (from a in linq.Thunhaps
                                 select new { a.Số_Tiền, a.Tài_Khoản, a.Ngày }
                                ).Union(
                                from b in linq.Thunos
                                select new { b.Số_Tiền, b.Tài_Khoản, b.Ngày }
                                ).Union(
                                from d in linq.Divays
                                select new { d.Số_Tiền, d.Tài_Khoản, d.Ngày }
                                )
                            group c by new { c.Tài_Khoản, c.Ngày } into g
                            select new { Ngay = g.Key.Ngày, Tàikhoản = g.Key.Tài_Khoản, SốTien = g.Sum(x => x.Số_Tiền) };

            dataGridView1.DataSource = tongthu;
        }

        private void TongThu_Load(object sender, EventArgs e)
        {
            refresh();
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
                    txtBoxVi.Text = t.ToString();
                else
                    txtBoxVi.Text = "0";
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
                    txtBoxATM.Text = t.ToString();
                else
                    txtBoxATM.Text = "0";
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
                    txtBoxSoTietKiem.Text = t.ToString();
                else
                    txtBoxSoTietKiem.Text = "0";
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
                    txtKhac.Text = t.ToString();
                else
                    txtKhac.Text = "0";
            }
            try
            {
                textBox3.Text = (Int32.Parse(txtBoxVi.Text) + Int32.Parse(txtBoxATM.Text) + Int32.Parse(txtBoxSoTietKiem.Text) + Int32.Parse(txtKhac.Text)).ToString();
            }
            catch (Exception)
            {

            }

        }
    }
}
