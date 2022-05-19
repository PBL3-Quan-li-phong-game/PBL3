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

namespace PBL3
{
    public partial class PCSelectForm : Form
    {
        public delegate void CloseGate();
        public CloseGate close;
        private USERS user;
        public PCSelectForm(USERS user)
        {
            InitializeComponent();
            this.user = user;
            lUserName.Text = user.UserName;
            lNotify.Visible = false;
            foreach (PC PC in NetBLL.Instance.GetAllPC())
            {
                cbbPC.Items.Add(PC.ID);
            }
            cbbPC.SelectedIndex = 0;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            PC pc = NetBLL.Instance.getPCbyID(cbbPC.SelectedItem.ToString());
            switch (pc.StatusID)
            {
                case 1:
                    PlayerForm pf = new PlayerForm(user, pc);
                    pf.close = new PlayerForm.closeDel(this.close);
                    NetBLL.Instance.onLogin(user, pc);
                    pf.Show();
                    this.Hide();
                    break;
                case 2:
                    lNotify.Text = "Máy đang hoạt động!";
                    lNotify.Visible = true;
                    break;
                default:
                    lNotify.Text = "Máy không dùng được!";
                    lNotify.Visible = true;
                    break;
            }
        }
        private void cbbPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            lNotify.Visible = false;
        }

        private void PCSelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
