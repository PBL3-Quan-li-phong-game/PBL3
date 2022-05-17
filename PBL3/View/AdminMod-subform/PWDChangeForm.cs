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
    public partial class PWDChangeForm : Form
    {
        public USERS user;
        public PWDChangeForm(USERS user)
        {
            this.user = user;
            InitializeComponent();
            lUserName.Text = user.UserName;
            lNotify.Visible = false;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (!TextValidate())
            {
                lNotify.Visible = true;
            }
            else
            if (!ConfirmPWD())
            {
                lNotify.Text = "     Mật khẩu cũ sai!      ";
                lNotify.Visible = true;
            }
            else
            if(txtNewPWD.Text != txtConfirmPWD.Text)
            {
                lNotify.Text = "  Xác nhận mật khẩu sai!   ";
                lNotify.Visible = true;
            }
            else
            {
                NetBLL.Instance.ChangePWD(user, txtNewPWD.Text);
                this.Close();
            }
        }

        private bool ConfirmPWD()
        {
            if (txtOldPWD.Text == user.PWD) return true;
            return false;
        }

        private bool TextValidate()
        {
            if (txtOldPWD.Text.Length == 0)
            {
                lNotify.Text = "  Cần xác nhận mật khẩu cũ!   ";
                return false;
            }
            if (txtNewPWD.Text.Length == 0)
            {
                lNotify.Text = "     Mật khẩu mới trống!      ";
                return false;
            }
            if (txtNewPWD.Text.Length > 18)
            {
                lNotify.Text = "Mật khẩu mới tối đa 18 kí tự! ";
                return false;
            }
            foreach (char c in txtNewPWD.Text)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')) continue;
                else
                {
                    lNotify.Text = "Mật khẩu mới không hợp lệ! ";
                    return false;
                }
            }
            return true;
        }

        private void txtOldPWD_TextChanged(object sender, EventArgs e)
        {
            lNotify.Visible = false;
        }

        private void txtNewPWD_TextChanged(object sender, EventArgs e)
        {
            lNotify.Visible = false;
        }

        private void txtConfirmPWD_TextChanged(object sender, EventArgs e)
        {
            lNotify.Visible = false;
        }
    }
}
