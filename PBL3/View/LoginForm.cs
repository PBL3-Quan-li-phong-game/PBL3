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
            USERS user = bll.Instance.GetUser(txtUserName.Text, txtPWD.Text);
            if(user == null)
            {
                lNotify.Text = "Sai tên đăng nhập hoặc mật khẩu!";
                lNotify.Visible = true;
            }
            else
            {
                if(bll.Instance.CheckOnlineADMOD() == true)
                {
                    if(user.RoleID < 3)
                    {
                        lNotify.Text = "Sai tên đăng nhập hoặc mật khẩu!";
                        lNotify.Visible = true;
                    }
                    else
                    {
                        PlayerForm pf = new PlayerForm(user);
                        pf.close = new PlayerForm.closeDel(this.Close);
                        bll.Instance.onLogin(user);
                        pf.Show();
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
                        bll.Instance.onLogin(user);
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
