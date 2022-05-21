﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.Model.Context;
using PBL3.BLL;
using PBL3.View.Player_subform;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using PBL3.DTO;

namespace PBL3
{
    public partial class PlayerForm : Form
    {
        public delegate void closeDel();
        public closeDel close;

        public USERS USER;
        public PC PC;
        public int ReceiptID;

        public TimeSpan RemainingTime;

        public ChatForm chatForm;
        public PlayerForm(USERS user, PC pc)
        {
            this.USER = NetBLL.Instance.getUserbyUserName(user.UserName);
            this.PC = NetBLL.Instance.getPCbyID(pc.ID);
            this.USER.PC = this.PC;
            this.ReceiptID = NetBLL.Instance.getLastReceiptRecordof(USER.UserName).ID;
            this.chatForm = new ChatForm(USER);
            this.chatForm.socketSend = new ChatForm.SocketSend(this.Send);

            InitializeComponent();

            lPCID.Text = PC.ID;
            lUserName.Text = USER.UserName;
            txtReMoney.Text = USER.RemainingMoney.ToString();
            RemainingTime = TimeSpan.FromHours(USER.RemainingMoney / USER.PC.AREA.Cost);
            txtReTime.Text = RemainingTime.ToString().Remove(RemainingTime.ToString().Length - 3);

            txt1hPrice.Text = PC.AREA.Cost.ToString();
            timer.Enabled = true;

            Connect();
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            NetBLL.Instance.onLogout(USER, PC, ReceiptID);
            Disconnect();
            this.close();
        }

        private void bAccMNG_Click(object sender, EventArgs e)
        {
            ProfileForm pf = new ProfileForm(USER);

            pf.Show();
        }

        private void bMSG_Click(object sender, EventArgs e)
        {
            chatForm.Show();
        }

        private void bService_Click(object sender, EventArgs e)
        {
            ServiceForm sf = new ServiceForm(USER, ReceiptID);
            sf.socketSend = new ServiceForm.SocketSend(Send);
            sf.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        ///***************SOCKET SECTION****************///

        Socket Server;
        IPEndPoint IP;
        
        private void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                Server.Connect(IP);
            }
            catch
            {
                MessageBox.Show("unable to connect", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        private void Send(object obj)
        {
            Server.Send(Serialize(obj));
        }
        private void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];
                    Server.Receive(data);

                    MSGviaSocket msg = (MSGviaSocket)Deserialize(data);
                    msgHandle(msg);
                }
            }
            catch
            {

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
            Server.Close();
        }

        ///*******************SOCKET MESSAGE HANDLER**********************///

        private void msgHandle(MSGviaSocket msg)
        {
            switch (msg.Title)
            {
                case "GetUserName":
                    Send(USER.UserName);
                    break;
                case "CHAT":
                    chatForm.rtbDisplay.Text += msg.Message;
                    break;
            }
        }
    }
}
