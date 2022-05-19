using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.Model.Context;

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
