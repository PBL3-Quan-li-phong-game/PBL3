using PBL3.BLL;
using PBL3.DTO;
using PBL3.Model.Context;
using System;
using System.Windows.Forms;


namespace PBL3.View.Player_subform
{
    public partial class ChatForm : Form
    {
        public delegate void SocketSend(object obj);
        public SocketSend socketSend;

        public USERS user;

        public ChatForm(USERS user)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.user = user;
            InitializeComponent();
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            if (rtbSend.Text != string.Empty)
            {
                DateTime SendTime = DateTime.Now;
                string onlineADMOD_Name = NetBLL.Instance.getOnlineADMOD().UserName;
                CHAT_LOG log = new CHAT_LOG
                {
                    sender = user.UserName,
                    receiver = onlineADMOD_Name,
                    SendTime = SendTime,
                    msg = rtbSend.Text.Length > 100 ? rtbSend.Text.Substring(0, 100) : rtbSend.Text
                };
                NetBLL.Instance.addChatLog(log);
                string Context =
                    user.UserName + "|(" + SendTime + ") " + user.UserName + ":\n" +
                    log.msg + "\n\n";
                socketSend(new MSGviaSocket
                {
                    Title = "CHAT",
                    Message = Context
                });
                AddMSG(Context);
                rtbSend.Clear();
            }
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void AddMSG(string msg)
        {
            rtbDisplay.Text += msg;
        }
    }
}
