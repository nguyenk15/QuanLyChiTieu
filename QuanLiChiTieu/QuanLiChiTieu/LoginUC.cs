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
    public partial class LoginUC : UserControl
    {
        public LoginUC()
        {
            InitializeComponent();
            OkButton.Click +=new EventHandler(OkButton_Click);
            
        }
        [Category("Data"), Description("Nhập tên tài khoản của bạn")]
        public string UserName
        {
            get { return this.txtUserName.Text; }
            set { this.txtUserName.Text = value; }
        }
        [Category("Data"), Description("Nhập mật khẩu tài khoản của bạn")]
        public string PassWord
        {
            get { return this.txtPassword.Text; }
            set { this.txtPassword.Text = value; }
        }

        //OkButton
        public delegate void OkButtonClickedEventHandler (object sender, EventArgs e);
        public event OkButtonClickedEventHandler OnLoginControlOkButtonClicked;

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(OnLoginControlOkButtonClicked != null)
                OnLoginControlOkButtonClicked(this, e);
        }

        //CancelButton
        public delegate void CancelButtonClickedEventHandler(object sender, EventArgs e);
        public event CancelButtonClickedEventHandler OnLoginControlCancelButtonClicked;

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (OnLoginControlCancelButtonClicked != null)
                OnLoginControlCancelButtonClicked(this, e);
        }



    }
}
