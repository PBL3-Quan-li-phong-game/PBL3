﻿using PBL3.BLL;
using PBL3.DTO;
using PBL3.Model.Context;
using System;
using System.Windows.Forms;

namespace PBL3.View.AdminMod_subform
{
    public partial class ChargeForm : Form
    {
        public delegate void ReloadGate();
        public ReloadGate Reload;
        public delegate void SendGate(string username, object obj);
        public SendGate send;
        public USERS user;
        public ChargeForm(string username)
        {
            this.user = NetBLL.Instance.getUserbyUserName(username);
            InitializeComponent();
            lNotify.Visible = false;
            lUserName.Text = username;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (emptyCheck())
            {
                lNotify.Text = "Số tiền bỏ trống!";
                lNotify.Visible = true;
            }
            else
            if (!TextValidate())
            {
                lNotify.Text = "Chỉ được nhập số!";
                lNotify.Visible = true;
            }
            else
            {
                NetBLL.Instance.MoneyCharge(user, Convert.ToInt32(txtMoney.Text));
                Reload();
                send(user.UserName, new MSGviaSocket
                {
                    Title = "CHARGE",
                    Message = ""
                });
                this.Close();
            }
        }

        private bool TextValidate()
        {
            foreach (char c in txtMoney.Text)
            {
                if (c < '0' || c > '9') return false;
            }
            return true;
        }

        private bool emptyCheck()
        {
            if (txtMoney.Text.Length == 0) return true;
            return false;
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            lNotify.Visible = false;
        }
    }
}
