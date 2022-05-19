using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.View.AdminMod_subform;
using PBL3.BLL;
using PBL3.Model;
using PBL3.Model.Context;
using PBL3.OnViewContext;

namespace PBL3
{
    public partial class AdminModForm : Form
    {
        public delegate void CloseGate();
        public CloseGate close;
        public Model_Net NetModel;
        private USERS USER;
        public AdminModForm(USERS user)
        {
            this.USER = user;
            InitializeComponent();
            lUserName.Text = USER.UserName;
            ReloadView();
            this.timer.Enabled = true;
        }

        public void ReloadView()
        {
            dgvPC.DataSource = NetBLL.Instance.getViewPC();
            dgvAccount.DataSource = NetBLL.Instance.getViewUsers();
        }

        public void SwitchUser(USERS user)
        {
            if (USER == user) return;

            NetBLL.Instance.onLogout(USER);
            USER = user;
            NetBLL.Instance.onLogin(USER);
            lUserName.Text = USER.UserName;
        }

        private void AdminModForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NetBLL.Instance.onLogout(USER);
            this.close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lDateTime.Text = DateTime.Now.ToString();
        }

        private void bAddUser_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm(USER.RoleID);
            af.Reload = new AddForm.ReloadGate(ReloadView);
            af.Show();
        }

        private void bProfile_Click(object sender, EventArgs e)
        {
            ProfileForm pf = new ProfileForm(USER);
            pf.uSwitch = new ProfileForm.USwitchGate(SwitchUser);
            pf.Show();
        }

        private void bMsg_Click(object sender, EventArgs e)
        {
            ChatForm cf = new ChatForm();

            cf.Show();
        }

        private void Charge_Click(object sender, EventArgs e)
        {
            ChargeForm cf = new ChargeForm(dgvAccount.SelectedRows[0].Cells[0].Value.ToString());
            cf.Reload = new ChargeForm.ReloadGate(this.ReloadView);
            cf.Show();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadView();
        }

        private void ResetPWD_Click(object sender, EventArgs e)
        {
            USERS u = NetBLL.Instance.getUserbyUserName(dgvAccount.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult r = MessageBox.Show(String.Format("Reset mật khẩu của tài khoản {0} ? (Mật khẩu mặc định là \"1\")", u.UserName), "Xác nhận reset", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                NetBLL.Instance.ResetPWD(u);
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            USERS u = NetBLL.Instance.getUserbyUserName(dgvAccount.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult r = MessageBox.Show(String.Format("Xóa tài khoản {0} ?", u.UserName), "Xóa tài khoản", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                NetBLL.Instance.DelUser(u);
                ReloadView();
            }
        }

        private void dgvAccount_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dgvAccount.SelectedRows.Count > 0)
            {
                cmsAccount.Show(dgvAccount, new Point(e.X, e.Y));
            }
        }

        private void txtSearchPC_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchPC.Text == "") dgvPC.DataSource = NetBLL.Instance.getViewPC();
            else
            {
                dgvPC.DataSource = NetBLL.Instance.getViewPCbySearch(txtSearchPC.Text);
            }
        }

        private void txtSearchAcc_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchAcc.Text == "") dgvAccount.DataSource = NetBLL.Instance.getViewUsers();
            else
            {
                dgvAccount.DataSource = NetBLL.Instance.getViewUserbySearch(txtSearchAcc.Text);
            }
        }
    }
}
