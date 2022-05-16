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

        private void AdminModForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NetBLL.Instance.onLogout(USER);
            this.close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lDateTime.Text = DateTime.Now.ToString();
        }

        private void dgvAccount_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right && dgvAccount.SelectedRows.Count > 0)
            {
                cmsAccount.Show(dgvAccount, new Point(e.X + 50, e.Y + 40));
            }
        }

        private void bAddUser_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm(USER.RoleID);
            af.Reload = new AddForm.ReloadGate(ReloadView);
            af.Show();
        }

        private void bProfile_Click(object sender, EventArgs e)
        {
            ProfileForm pf = new ProfileForm();

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
    }
}
