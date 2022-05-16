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
    public partial class AddForm : Form
    {
        public delegate void ReloadGate();
        public ReloadGate Reload;
        public AddForm(int RoleID)
        {
            InitializeComponent();
            cbMOD.Checked = false;
            if (RoleID == 2) cbMOD.Visible = false;
            lNotify.Visible = false;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (!CheckValidate())
            {
                lNotify.Visible = true;
            }
            else
            {
                USERS user = new USERS
                {
                    UserName = txtUserName.Text,
                    PWD = txtPWD.Text,
                    RoleID = cbMOD.Checked ? 2 : 3,
                    RemainingMoney = Convert.ToInt32(txtMoney.Text),
                    UsingPC = null,
                    OnlineStatus = false,
                    RegisterDate = DateTime.Now,
                    LastLogin = DateTime.Now
                };
                NetBLL.Instance.addUser(user);
                Reload();
                this.Close();
            }
        }
        private bool CheckValidate()
        {
            if (emptyCheck())
            {
                lNotify.Visible = true;
                return false;
            }
            foreach (char c in txtUserName.Text)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')) continue;
                else
                {
                    lNotify.Text = "Tài khoản không hợp lệ!";
                    return false;
                }
            }
            foreach (char c in txtPWD.Text)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')) continue;
                else
                {
                    lNotify.Text = "Mật khẩu không hợp lệ!";
                    return false; 
                }
            }
            foreach (char c in txtMoney.Text)
            {
                if (c < '0' && c > '9')
                { 
                    lNotify.Text = "Số tiền không hợp lệ!";
                    return false;
                }
            }
            return true;
        }
        private bool emptyCheck()
        {
            if (txtUserName.Text.Length == 0)
            {
                lNotify.Text = "Tên đăng nhập trống!";
                return true;
            }
            if (txtPWD.Text.Length == 0)
            {
                lNotify.Text = "Mật khẩu trống!     ";
                return true;
            }
            if (txtMoney.Text.Length == 0)
            {
                lNotify.Text = "Số tiền trống!      ";
                return true;
            }
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

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            lNotify.Visible = false;
        }

        private void cbMOD_CheckedChanged(object sender, EventArgs e)
        {
            if(cbMOD.Checked == true)
            {
                txtMoney.Text = "0";
                txtMoney.Enabled = false;
            }
            else
            {
                txtMoney.Enabled = true;
            }
        }
    }
}
