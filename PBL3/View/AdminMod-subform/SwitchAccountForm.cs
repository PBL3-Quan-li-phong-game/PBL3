using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.Model.Context;


namespace PBL3.View.AdminMod_subform
{
    public partial class SwitchAccountForm : Form
    {
        public delegate void USwitchGate(USERS user);
        public USwitchGate uSwitch;
        public SwitchAccountForm()
        {
            InitializeComponent();
            lNotify.Visible = false;
        }

        private void bSwitch_Click(object sender, EventArgs e)
        {
            USERS user = NetBLL.Instance.GetUser(txtUserName.Text, txtPWD.Text);
            if (emptyCheck())
            {
                lNotify.Text = "Tên đăng nhập/mật khẩu bỏ trống";
                lNotify.Visible = true;
            }
            else
            if (TextValidate() == false)
            {
                lNotify.Text = "Chỉ được nhập từ 0->9, a->z, A->Z";
                lNotify.Visible = true;
            }
            else
            if (user == null)
            {
                lNotify.Text = "Sai tên đăng nhập hoặc mật khẩu!";
                lNotify.Visible = true;
            }
            else
            {
                if(user.RoleID == 3)
                {
                    lNotify.Text = "Không được dùng tài khoản này! ";
                    lNotify.Visible = true;
                }
                else
                {
                    uSwitch(user);
                    this.Close();
                }
            }
        }
        private bool TextValidate()
        {
            foreach (char c in txtUserName.Text)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')) continue;
                else return false;
            }
            foreach (char c in txtPWD.Text)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')) continue;
                else return false;
            }
            return true;
        }
        private bool emptyCheck()
        {
            if (txtPWD.Text.Length == 0 || txtUserName.Text.Length == 0) return true;
            return false;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            lNotify.Visible = false;
        }

        private void txtPWD_TextChanged(object sender, EventArgs e)
        {
            lNotify.Visible = false;
        }
    }
}
