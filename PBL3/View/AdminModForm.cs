using PBL3.BLL;
using PBL3.DTO;
using PBL3.Model.Context;
using PBL3.View.AdminMod_subform;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

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
            this.chatForm = new ChatForm(USER);
            this.chatForm.socketSend = new ChatForm.SocketSend(this.SendAtIndex);
            this.orderGettingForm = new OrderGettingForm();

            InitializeComponent();

            lUserName.Text = USER.UserName;
            timer.Enabled = true;

            ReloadView();
            GUI();
            SetupServer();
        }

        private void GUI()
        {
            dgvPC.Columns[0].HeaderText = "Mã PC";
            dgvPC.Columns[0].Width = 240;
            dgvPC.Columns[1].HeaderText = "Tình trạng máy";
            dgvPC.Columns[1].Width = 250;
            dgvPC.Columns[2].HeaderText = "Tài khoản người dùng";
            dgvPC.Columns[2].Width = 250;
            dgvPC.Columns[3].HeaderText = "Tiền trong tài khoản";
            dgvPC.Columns[3].Width = 250;
            ///
            dgvAccount.Columns[0].HeaderText = "Tên tài khoản";
            dgvAccount.Columns[0].Width = 100;
            dgvAccount.Columns[1].HeaderText = "Mã vai trò";
            dgvAccount.Columns[1].Width = 100;
            dgvAccount.Columns[2].HeaderText = "Máy đang sử dụng";
            dgvAccount.Columns[2].Width = 150;
            dgvAccount.Columns[3].HeaderText = "Tiền trong tài khoản";
            dgvAccount.Columns[3].Width = 130;
            dgvAccount.Columns[4].HeaderText = "Ngày đăng ký";
            dgvAccount.Columns[4].Width = 190;
            dgvAccount.Columns[5].HeaderText = "Lần đăng nhập cuối";
            dgvAccount.Columns[5].Width = 190;
            dgvAccount.Columns[6].HeaderText = "Tình trạng Online";
            dgvAccount.Columns[6].Width = 130;
            ///
            dgvReceiptHistory.Columns[0].HeaderText = "Mã hóa đơn";
            dgvReceiptHistory.Columns[0].Width = 110;
            dgvReceiptHistory.Columns[1].HeaderText = "Ngày lập hóa đơn";
            dgvReceiptHistory.Columns[1].Width = 160;
        }

        public void ReloadView()
        {
            dgvPC.DataSource = NetBLL.Instance.getViewPC();
            dgvAccount.DataSource = NetBLL.Instance.getViewUsers();
            dgvReceiptHistory.DataSource = NetBLL.Instance.getViewReceiptofUser(dgvAccount.Rows[0].Cells[0].Value.ToString());
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
            chatForm.Hide();
            foreach (ChatContext c in chatForm.chatContexts)
            {
                if (c.isRead == false)
                {
                    chatForm.lvConnection.Items[chatForm.chatContexts.IndexOf(c)].Selected = true;
                    break;
                }
            }
            chatForm.Show();
        }

        private void bReceipt_Click(object sender, EventArgs e)
        {
            orderGettingForm.Hide();
            foreach (Order o in orderGettingForm.OrderList)
            {
                if (o.items.Count > 0)
                {
                    orderGettingForm.lvConnection.Items[orderGettingForm.OrderList.IndexOf(o)].Selected = true;
                    break;
                }
            }
            orderGettingForm.Show();
        }

        private void Charge_Click(object sender, EventArgs e)
        {
            ChargeForm cf = new ChargeForm(dgvAccount.SelectedRows[0].Cells[0].Value.ToString());
            cf.Reload = new ChargeForm.ReloadGate(this.ReloadView);
            cf.send = new ChargeForm.SendGate(this.SendToUser);
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
            if (dgvAccount.SelectedRows.Count == 1)
                dgvReceiptHistory.DataSource = NetBLL.Instance.getViewReceiptofUser(dgvAccount.SelectedRows[0].Cells[0].Value.ToString());
            else dgvReceiptHistory.DataSource = null;
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

        private void dgvReceiptHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bStat_Click(object sender, EventArgs e)
        {
            StatiticForm sf = new StatiticForm();
            sf.Show();
        }

        ////*************SOCKET SECTION***************////
        //////////////////////////////////////////////////


        List<Socket> ConnectionList = new List<Socket>();

        List<string> listUserName = new List<string>();

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
                        chatForm.chatContexts.Add(new ChatContext());
                        reloadConnectionView();
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

        private void reloadConnectionView()
        {
            orderGettingForm.lvConnection.Items.Clear();
            chatForm.lvConnection.Items.Clear();
            foreach (string n in listUserName)
            {
                orderGettingForm.lvConnection.Items.Add(n);
                chatForm.lvConnection.Items.Add(n);
            }
        }

        private void reloadContextView()
        {
            orderGettingForm.reloadOrderList();
            chatForm.reloadChatContext();
        }

        private void Send(Socket Dest, object obj)
        {
            Dest.Send(Serialize(obj));
        }

        private void SendAtIndex(int IndexOfSocket, object obj)
        {
            Send(ConnectionList.ElementAt(IndexOfSocket), obj);
        }

        private void SendToUser(string UserName, object obj)
        {
            int index = listUserName.IndexOf(UserName);
            if (index == -1) return;
            Send(ConnectionList.ElementAt(index), obj);
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
                onSocketRemove(src);
                reloadConnectionView();
                reloadContextView();
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
            foreach (Socket client in ConnectionList)
            {
                client.Close();
            }
        }

        private void onSocketRemove(Socket src)
        {
            listUserName.RemoveAt(ConnectionList.IndexOf(src));
            orderGettingForm.OrderList.RemoveAt(ConnectionList.IndexOf(src));
            chatForm.chatContexts.RemoveAt(ConnectionList.IndexOf(src));
        }

        ///*******************SOCKET MESSAGE HANDLER**********************///

        private void msgHandle(MSGviaSocket msg)
        {
            switch (msg.Title)
            {
                case "CHAT":
                    ChatHandle(msg.Message);
                    break;
                case "RECEIPT":
                    ReceiptHandle(msg.Message);
                    break;
                case "RELOAD":
                    ReloadView();
                    break;
            }
        }

        private void ChatHandle(string msg)
        {
            string[] msg_split = msg.Split('|');
            int index = listUserName.IndexOf(msg_split[0]);
            chatForm.chatContexts.ElementAt(index).isRead = false;
            for (int i = 1; i < msg_split.Length; i++)
            {
                chatForm.chatContexts.ElementAt(index).Message += msg_split[i];
            }
            chatForm.reloadChatContext();
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
            orderGettingForm.reloadOrderList();
        }
    }
}
