using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.View.AdminMod_subform;

namespace PBL3
{
    public partial class AdminModForm : Form
    {
        public delegate void CloseGate();
        public CloseGate close;
        public AdminModForm()
        {
            InitializeComponent();
            this.timer.Enabled = true;
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]{
                new DataColumn { ColumnName = "Tên tài khoản", DataType = typeof(string) },
                new DataColumn { ColumnName = "Số tiền còn lại", DataType = typeof(int) },
                new DataColumn { ColumnName = "Thời gian còn lại", DataType = typeof(string) }
            });
            dt.Rows.Add("user1", 30000, "5:00:00");
            dgvAccount.DataSource = dt;
        }

        private void AdminModForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lDateTime.Text = DateTime.Now.ToString();
        }

        private void dgvAccount_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right && dgvAccount.SelectedRows.Count > 0)
            {
                cmsAccount.Show(dgvAccount, new Point(e.X + 50, e.Y + 40));
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChargeForm cf = new ChargeForm();

            cf.Show();
        }

        private void bAddUser_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();

            af.Show();
        }

        private void bProfile_Click(object sender, EventArgs e)
        {
            ProfileForm pf = new ProfileForm();

            pf.Show();
        }

        private void bMsg_Click(object sender, EventArgs e)
        {
            ChatForm cf = new ChatForm();

            cf.Show();
        }
    }
}
