using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                AdminModForm admForm = new AdminModForm();
                admForm.close += this.Close;
                admForm.Show();
            }
            else 
            { 
                PlayerForm plForm = new PlayerForm();
                plForm.close += this.Close;
                plForm.Show();
            }
            this.Hide();
        }
    }
}
