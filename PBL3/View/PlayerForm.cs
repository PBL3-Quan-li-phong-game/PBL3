﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.Model.Context;
using PBL3.BLL;
using PBL3.View.Player_subform;

namespace PBL3
{
    public partial class PlayerForm : Form
    {
        public delegate void closeDel();
        public closeDel close;
        public USERS USER;
        public PC PC;
        public PlayerForm(USERS user, PC pc)
        {
            this.USER = user;
            this.PC = pc;
            InitializeComponent();
            lPCID.Text = PC.ID;
            lUserName.Text = USER.UserName;
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            NetBLL.Instance.onLogout(USER, PC);
            this.close();
        }

        private void bAccMNG_Click(object sender, EventArgs e)
        {
            ProfileForm pf = new ProfileForm();

            pf.Show();
        }

        private void bMSG_Click(object sender, EventArgs e)
        {
            ChatForm cf = new ChatForm();

            cf.Show();
        }
    }
}
