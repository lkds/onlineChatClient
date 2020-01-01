﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace onlineChat
{
    public partial class singleChat : Form
    {
        public string targetUserName;
        public uint targetUserID;
        public singleChat(uint userID,string name)
        {
            InitializeComponent();
            targetUserName = name;
            targetUserID = userID;
            userName.Text = name;
            DrawMessage();
            inputBox.ForeColor = Color.Gray;
            inputBox.Text = "此处输入文字消息......";
            inputBox.LostFocus += new EventHandler(this.inputTip);  //消息输入框失焦
            inputBox.Enter += new EventHandler(this.inputTipCancel);  //消息输入框得到焦点
        }


        private void inputTipCancel(object sender, EventArgs e)  //消息框得到焦点取消文字提示
        {
            if (inputBox.ForeColor == Color.Gray)
            {
                inputBox.ForeColor = Color.Black;
                inputBox.Text = "";
            }
        }

        private void inputTip(object sender, EventArgs e)  //消息框失焦提示文字
        {
            if (inputBox.Text == "")
            {
                inputBox.ForeColor = Color.Gray;
                inputBox.Text = "此处输入文字消息......";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            login l1 = new login();
            l1.Show();
        }

        public void DrawMessage()
        {
            if (!publicClass.myChat.ContainsKey((int)targetUserID))
            {
                singleChatSession chatSession = new singleChatSession((int)targetUserID);
                publicClass.myChat.Add((int)targetUserID, chatSession);
            }
            ArrayList messages = publicClass.myChat[(int)targetUserID].messageList;
            singleChatMessageBox.Text = "";
            foreach(baseMessage i in messages)
            {
                if(i.GetType() == typeof(textMessage))
                {
                    singleChatMessageBox.SelectionFont = new Font("黑体", 7, FontStyle.Bold);
                    singleChatMessageBox.SelectionColor = System.Drawing.Color.Purple;
                    singleChatMessageBox.SelectionIndent = 2;
                    singleChatMessageBox.SelectionBullet = true;
                    singleChatMessageBox.Text = singleChatMessageBox.Text + "\r\n" + i.sendUser + "  [" + i.sendTime + "]";

                    singleChatMessageBox.SelectionFont = new Font("宋体", 7, FontStyle.Regular);
                    singleChatMessageBox.SelectionColor = System.Drawing.Color.Black;
                    singleChatMessageBox.SelectionIndent = 52;
                    singleChatMessageBox.SelectionBullet = false;
                    singleChatMessageBox.Text = singleChatMessageBox.Text + "\r\n" + ((textMessage)i).content;
                }
                else if (i.GetType() == typeof(imageFileMessage))
                {
                    singleChatMessageBox.SelectionFont = new Font("黑体", 7, FontStyle.Bold);
                    singleChatMessageBox.SelectionColor = System.Drawing.Color.Purple;
                    singleChatMessageBox.SelectionIndent = 2;
                    singleChatMessageBox.SelectionBullet = true;
                    singleChatMessageBox.Text = singleChatMessageBox.Text + "\r\n" + i.sendUser + "  [" + i.sendTime + "]";

                    singleChatMessageBox.SelectionFont = new Font("宋体", 7, FontStyle.Regular);
                    singleChatMessageBox.SelectionColor = System.Drawing.Color.Blue;
                    singleChatMessageBox.SelectionIndent = 52;
                    singleChatMessageBox.SelectionBullet = false;
                    singleChatMessageBox.Text = singleChatMessageBox.Text + "\r\n" + "【图片/文件消息  点击查看】";
                }
            }
        }

        public void AddMessage(textMessage message)
        {
                singleChatMessageBox.SelectionFont = new Font("黑体", 7, FontStyle.Bold);
                singleChatMessageBox.SelectionColor = System.Drawing.Color.Purple;
                singleChatMessageBox.SelectionIndent = 2;
                singleChatMessageBox.SelectionBullet = true;
                singleChatMessageBox.Text = singleChatMessageBox.Text + "\r\n" + message.sendUser + "  [" + message.sendTime + "]";

                singleChatMessageBox.SelectionFont = new Font("宋体", 7, FontStyle.Regular);
                singleChatMessageBox.SelectionColor = System.Drawing.Color.Black;
                singleChatMessageBox.SelectionIndent = 52;
                singleChatMessageBox.SelectionBullet = false;
                singleChatMessageBox.Text = singleChatMessageBox.Text + "\r\n" + ((textMessage)message).content;
        }

        public void AddMessage(imageFileMessage message)
        {
            singleChatMessageBox.SelectionFont = new Font("黑体", 7, FontStyle.Bold);
            singleChatMessageBox.SelectionColor = System.Drawing.Color.Purple;
            singleChatMessageBox.SelectionIndent = 2;
            singleChatMessageBox.SelectionBullet = true;
            singleChatMessageBox.Text = singleChatMessageBox.Text + "\r\n" + message.sendUser + "  [" + message.sendTime + "]";

            singleChatMessageBox.SelectionFont = new Font("宋体", 7, FontStyle.Regular);
            singleChatMessageBox.SelectionColor = System.Drawing.Color.Blue;
            singleChatMessageBox.SelectionIndent = 52;
            singleChatMessageBox.SelectionBullet = false;
            singleChatMessageBox.Text = singleChatMessageBox.Text + "\r\n" + "【图片/文件消息  点击查看】";
        }

        private void SingleUserBox1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputBox.ForeColor != Color.Gray || inputBox.Text!="")
            {
                textMessage message = new textMessage();
                message.content = inputBox.Text;
                message.target = (int)targetUserID;
                message.sendUser = publicClass.mainUser.id;
                string sendMessage = JsonConvert.SerializeObject(new command() { data = message, type = 0, subType = "singleChatTextMessage", res = "" });//序列化
                publicClass.cSocket.sendSysMsg(sendMessage);
            }
        }
    }
}
