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
using PBL3.BLL;
using PBL3.Model;
using PBL3.Model.Context;
using PBL3.OnViewContext;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using PBL3.DTO;

namespace PBL3
{
    public partial class AdminModForm : Form
    {
        public delegate void CloseGate();
        public CloseGate close;

        private USERS USER;

        private ChatForm chatForm;
        private OrderGettingForm orderGettingForm;

        public AdminModForm(USERS user)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.USER = user;
            this.chatForm = new ChatForm();
            this.orderGettingForm = new OrderGettingForm();

            InitializeComponent();

            lUserName.Text = USER.UserName;
            timer.Enabled = true;

            ReloadView();
            SetupServer();
        }

        public void ReloadView()
        {
            dgvPC.DataSource = NetBLL.Instance.getViewPC();
            dgvAccount.DataSource = NetBLL.Instance.getViewUsers();
        }

        public void SwitchUser(USERS user)
        {
            if (USER == user) return;

            NetBLL.Instance.onLogout(USER);
            USER = user;
            NetBLL.Instance.onLogin(USER);
            lUserName.Text = USER.UserName;
        }

        private void AdminModForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NetBLL.Instance.onLogout(USER);
            Disconnect();
            this.close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lDateTime.Text = DateTime.Now.ToString();
        }

        private void bAddUser_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm(USER.RoleID);
            af.Reload = new AddForm.ReloadGate(ReloadView);
            af.Show();
        }

        private void bProfile_Click(object sender, EventArgs e)
        {
            ProfileForm pf = new ProfileForm(USER);
            pf.uSwitch = new ProfileForm.USwitchGate(SwitchUser);
            pf.Show();
        }

        private void bMsg_Click(object sender, EventArgs e)
        {
            chatForm.Show();
        }

        private void bReceipt_Click(object sender, EventArgs e)
        { 
            orderGettingForm.Show();
        }

        private void Charge_Click(object sender, EventArgs e)
        {
            ChargeForm cf = new ChargeForm(dgvAccount.SelectedRows[0].Cells[0].Value.ToString());
            cf.Reload = new ChargeForm.ReloadGate(this.ReloadView);
            cf.Show();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadView();
        }

        private void ResetPWD_Click(object sender, EventArgs e)
        {
            USERS u = NetBLL.Instance.getUserbyUserName(dgvAccount.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult r = MessageBox.Show(String.Format("Reset mật khẩu của tài khoản {0} ? (Mật khẩu mặc định là \"1\")", u.UserName), "Xác nhận reset", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                NetBLL.Instance.ResetPWD(u);
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            USERS u = NetBLL.Instance.getUserbyUserName(dgvAccount.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult r = MessageBox.Show(String.Format("Xóa tài khoản {0} ?", u.UserName), "Xóa tài khoản", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                NetBLL.Instance.DelUser(u);
                ReloadView();
            }
        }

        private void dgvAccount_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dgvAccount.SelectedRows.Count > 0)
            {
                cmsAccount.Show(dgvAccount, new Point(e.X, e.Y));
            }
        }

        private void txtSearchPC_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchPC.Text == "") dgvPC.DataSource = NetBLL.Instance.getViewPC();
            else
            {
                dgvPC.DataSource = NetBLL.Instance.getViewPCbySearch(txtSearchPC.Text);
            }
        }

        private void txtSearchAcc_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchAcc.Text == "") dgvAccount.DataSource = NetBLL.Instance.getViewUsers();
            else
            {
                dgvAccount.DataSource = NetBLL.Instance.getViewUserbySearch(txtSearchAcc.Text);
            }
        }

        private void refreshUserListView()
        {
            chatForm.lwConnection.Items.Clear();
            orderGettingForm.lwConnection.Items.Clear();
            foreach (string s in listUserName)
            {
                chatForm.lwConnection.Items.Add(s);
            }
            foreach (string s in listUserName)
            {
                orderGettingForm.lwConnection.Items.Add(s);
            }
        }

        ///*************SOCKET SECTION***************///

        List<Socket> ConnectionList = new List<Socket>();

        List<string> listUserName = new List<string>();
        List<string> ChatContext = new List<string>();

        Socket ServerSocket;
        IPEndPoint IP;

        private void SetupServer()
        {
            IP = new IPEndPoint(IPAddress.Any, 9999);
            ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            ServerSocket.Bind(IP);

            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        ServerSocket.Listen(20);
                        Socket cnn = ServerSocket.Accept();

                        byte[] data = new byte[1024];
                        cnn.Send(Serialize(new MSGviaSocket { Title = "GetUserName", Message = "" }));
                        cnn.Receive(data);
                        listUserName.Add((string)Deserialize(data));
                        orderGettingForm.OrderList.Add(new Order());
                        refreshUserListView();
                        ConnectionList.Add(cnn);

                        Thread receive = new Thread(() => Receive(cnn));
                        receive.IsBackground = true;
                        receive.Start();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }

        private void Send(Socket Dest, object obj)
        {
            Dest.Send(Serialize(obj));
        }

        private void Receive(object obj)
        {
            Socket src = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];
                    src.Receive(data);

                    MSGviaSocket msg = (MSGviaSocket)Deserialize(data);
                    msgHandle(msg);
                }
            }
            catch
            {
                listUserName.RemoveAt(ConnectionList.IndexOf(src));
                orderGettingForm.OrderList.RemoveAt(ConnectionList.IndexOf(src));
                ConnectionList.Remove(src);
                src.Close();
            }
        }

        private byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        private object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void Disconnect()
        {
            foreach(Socket client in ConnectionList)
            {
                client.Close();
            }
        }

        ///*******************SOCKET MESSAGE HANDLER**********************///
        
        private void msgHandle(MSGviaSocket msg)
        {
            switch (msg.Title)
            {
                case "CHAT":
                    break;
                case "RECEIPT":
                    ReceiptHandle(msg.Message);
                    break;
            }
        }

        private void ReceiptHandle(string msg)
        {
            string[] msg_split = msg.Split(',');
            int index = listUserName.IndexOf(msg_split[0]);
            orderGettingForm.OrderList.ElementAt(index).items.Add(new RECEIPT_ITEM
            {
                ReceiptID = Convert.ToInt32(msg_split[1]),
                ServiceID = msg_split[2],
                Amount = Convert.ToInt32(msg_split[3])
            });
        }
    }
}
