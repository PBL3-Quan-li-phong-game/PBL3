using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.BLL;
using PBL3.Model.Context;


namespace PBL3.View.AdminMod_subform
{
    public partial class ChatForm : Form
    {
        public delegate void SocketSend(int IndexOfSocket, object obj);
        public SocketSend socketSend;
        public List<ChatContext> chatContexts { get; set; }

        public USERS user;

        public ChatForm(USERS user)
        {
            CheckForIllegalCrossThreadCalls = false;
            chatContexts = new List<ChatContext>();
            this.user = user;
            InitializeComponent();
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            if (rtbSend.Text != string.Empty && lwConnection.SelectedItems.Count > 0)
            {
                DateTime SendTime = DateTime.Now;
                CHAT_LOG log = new CHAT_LOG
                {
                    sender = user.UserName,
                    receiver = lwConnection.SelectedItems[0].Text,
                    SendTime = SendTime,
                    msg = rtbSend.Text
                };
                NetBLL.Instance.addChatLog(log);
                string Context =
                    "(" + SendTime + ") " + "Admin" + ":\n" +
                    rtbSend.Text + "\n\n";
                socketSend(lwConnection.SelectedIndices[0], new MSGviaSocket
                {
                    Title = "CHAT",
                    Message = Context
                });
                AddMSG(lwConnection.SelectedIndices[0], Context);
                rtbDisplay.Clear();
                rtbSend.Clear();
                rtbDisplay.Text = chatContexts.ElementAt(lwConnection.SelectedIndices[0]).Message;
            }
        }

        private void lwConnection_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadChatContext();
        }

        private void reloadChatContext()
        {
            if (lwConnection.SelectedItems == null || lwConnection.SelectedItems.Count == 0)
            {
                rtbDisplay.Text = "";
                bSend.Enabled = false;
                foreach(ListViewItem i in lwConnection.Items)
                {
                    if(chatContexts.ElementAt(lwConnection.Items.IndexOf(i)).isRead == false)
                    {
                        lwConnection.Items[lwConnection.Items.IndexOf(i)].Selected = true;
                        break;
                    }
                }
            }
            else
            {
                rtbDisplay.Text = chatContexts.ElementAt(lwConnection.SelectedIndices[0]).Message;
                chatContexts.ElementAt(lwConnection.SelectedIndices[0]).isRead = true;
                bSend.Enabled = true;
            }
        }

        private void AddMSG(int Index, string Context)
        {
            chatContexts.ElementAt(Index).Message += Context; 
        }
    }
}
