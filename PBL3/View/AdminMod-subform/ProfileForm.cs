using PBL3.Model.Context;
using System;
using System.Windows.Forms;

namespace PBL3.View.AdminMod_subform
{
    public partial class ProfileForm : Form
    {
        public delegate void USwitchGate(USERS user);
        public USwitchGate uSwitch;
        public USERS user;
        public ProfileForm(USERS user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void bPWDChange_Click(object sender, EventArgs e)
        {
            PWDChangeForm cf = new PWDChangeForm(user);
            cf.Show();
            this.Close();
        }

        private void bChangeAccount_Click(object sender, EventArgs e)
        {
            SwitchAccountForm sf = new SwitchAccountForm();
            sf.uSwitch = new SwitchAccountForm.USwitchGate(this.uSwitch);
            sf.Show();
            this.Close();
        }
    }
}
