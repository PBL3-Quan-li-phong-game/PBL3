﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.AdminMod_subform
{
    public partial class ChargeForm : Form
    {
        public ChargeForm()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            //
            this.Close();
        }
    }
}
