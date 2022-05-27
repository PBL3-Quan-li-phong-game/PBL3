using PBL3.Model.Context;
using System;
using System.Windows.Forms;

namespace PBL3.View.Player_subform
{
    public partial class ProfileForm : Form
    {
        public USERS user;
        public ProfileForm(USERS user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void bPWDChange_Click(object sender, EventArgs e)
        {
            PWDChangeForm pf = new PWDChangeForm(user);
            pf.Show();
            this.Close();
        }

        private void bLog_Click(object sender, EventArgs e)
        {
            LoginHistoryForm lh = new LoginHistoryForm(user);
            lh.Show();
            this.Close();
        }
    }
}
