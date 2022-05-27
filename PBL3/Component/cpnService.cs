using PBL3.Model.Context;
using System;
using System.Windows.Forms;

namespace PBL3.Component
{
    public partial class cpnService : UserControl
    {
        public SERV service;
        public cpnService()
        {
            InitializeComponent();
            txtAmount.Text = "0";
        }

        private void bPlus1_Click(object sender, EventArgs e)
        {
            txtAmount.Text = (Convert.ToInt32(txtAmount.Text) + 1).ToString();
        }

        private void bMinus1_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "0") return;
            txtAmount.Text = (Convert.ToInt32(txtAmount.Text) - 1).ToString();
        }
    }
}
