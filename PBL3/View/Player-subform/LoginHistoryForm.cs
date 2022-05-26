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


namespace PBL3.View.Player_subform
{
    public partial class LoginHistoryForm : Form
    {
        public USERS user;
        public LoginHistoryForm(USERS user)
        {
            this.user = user;
            InitializeComponent();
            LoadHistoryListView();
        }

        private void LoadHistoryListView()
        {
            List<LOGIN_HISTORY> data = NetBLL.Instance.getLoginHistory(user);
            foreach(LOGIN_HISTORY lh in data)
            {
                ListViewItem i = new ListViewItem(lh.PCID);
                i.SubItems.Add(lh.LoginTime.ToString());
                i.SubItems.Add(lh.LogoutTime.ToString());
                i.SubItems.Add((lh.LogoutTime - lh.LoginTime).ToString().Substring(0, 8));
                lvLog.Items.Add(i);
            }
        }
    }
}
