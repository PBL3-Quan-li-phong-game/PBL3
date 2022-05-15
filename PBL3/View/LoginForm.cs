using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.Model;
using PBL3.Model.obj;
using PBL3.BLL;

namespace PBL3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.lNotify.Visible = false;
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            USERS user = NetBLL.Instance.GetUser(txtUserName.Text, txtPWD.Text);
            if(user == null)
            {
                lNotify.Text = "Sai tên đăng nhập hoặc mật khẩu!";
                lNotify.Visible = true;
            }
            else
            {
                if(NetBLL.Instance.CheckOnlineADMOD() == true)
                {
                    if(user.RoleID < 3)
                    {
                        lNotify.Text = "Sai tên đăng nhập hoặc mật khẩu!";
                        lNotify.Visible = true;
                    }
                    else
                    {
                        PCSelectForm sf = new PCSelectForm(user);
                        sf.close = new PCSelectForm.CloseGate(this.Close);
                        sf.Show();
                        this.Hide();
                    }
                }
                else
                {
                    if(user.RoleID == 3)
                    {
                        lNotify.Text = "Chưa thể đăng nhập lúc này!";
                        lNotify.Visible = true;
                    }
                    else
                    {
                        AdminModForm amf = new AdminModForm(user);
                        amf.close = new AdminModForm.CloseGate(this.Close);
                        NetBLL.Instance.onLogin(user);
                        amf.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void txtPWD_TextChanged(object sender, EventArgs e)
        {
            this.lNotify.Visible = false;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            this.lNotify.Visible = false;
        }
    }
}
