using System;
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
        public singleChat(uint userID)
        {
            InitializeComponent();
            foreach(user i in publicClass.onlineUserList)
            {
                if(i.id==userID)
                {
                    targetUserName = i.userName;
                }
            }
            Text = "单人聊天【To：" + targetUserName + "】";
            targetUserID = userID;
            userName.Text = targetUserName;
            int avatarNum = 0;
            foreach(user i in publicClass.recentChatList)
            {
                if(i.id==targetUserID)
                {
                    avatarNum = i.avatar;
                }
            }
            userAvatar.Image= System.Drawing.Image.FromFile("../..//src/img/avatar" + avatarNum + ".png");
            DrawMessage();
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
                    singleChatMessageBox.SelectionFont = new Font("黑体", 9, FontStyle.Bold);
                    singleChatMessageBox.SelectionColor = System.Drawing.Color.Purple;
                    singleChatMessageBox.SelectionIndent = 2;
                    singleChatMessageBox.SelectionBullet = true;
                    singleChatMessageBox.AppendText(publicClass.onlineUserList.Find(s=>s.id ==i.sendUser).userName + "  [" + i.sendTime + "]\r\n");

                    singleChatMessageBox.SelectionFont = new Font("宋体", 9, FontStyle.Regular);
                    singleChatMessageBox.SelectionColor = System.Drawing.Color.Black;
                    singleChatMessageBox.SelectionIndent = 19;
                    singleChatMessageBox.SelectionBullet = false;
                    singleChatMessageBox.AppendText(((textMessage)i).content+ "\r\n");
                }
                else if (i.GetType() == typeof(imageFileMessage))
                {
                    singleChatMessageBox.SelectionFont = new Font("黑体", 9, FontStyle.Bold);
                    singleChatMessageBox.SelectionColor = System.Drawing.Color.Purple;
                    singleChatMessageBox.SelectionIndent = 2;
                    singleChatMessageBox.SelectionBullet = true;
                    singleChatMessageBox.AppendText(publicClass.onlineUserList.Find(s => s.id == i.sendUser).userName + "  [" + i.sendTime + "]\r\n");

                    singleChatMessageBox.SelectionFont = new Font("宋体", 9, FontStyle.Regular);
                    singleChatMessageBox.SelectionColor = System.Drawing.Color.Blue;
                    singleChatMessageBox.SelectionIndent = 19;
                    singleChatMessageBox.SelectionBullet = false;
                    singleChatMessageBox.Text = singleChatMessageBox.Text + "\r\n" + "【图片/文件消息  点击查看】";
                }
            }
        }

        public void AddMessage(textMessage message)
        {
                singleChatMessageBox.SelectionFont = new Font("黑体", 9, FontStyle.Bold);
                singleChatMessageBox.SelectionColor = System.Drawing.Color.Purple;
                singleChatMessageBox.SelectionIndent = 2;
                singleChatMessageBox.SelectionBullet = true;
                singleChatMessageBox.AppendText(publicClass.onlineUserList.Find(s => s.id == message.sendUser).userName + "  [" + message.sendTime + "]\r\n");

                singleChatMessageBox.SelectionFont = new Font("宋体", 9, FontStyle.Regular);
                singleChatMessageBox.SelectionColor = System.Drawing.Color.Black;
                singleChatMessageBox.SelectionIndent = 19;
                singleChatMessageBox.SelectionBullet = false;
                singleChatMessageBox.AppendText(((textMessage)message).content+"\r\n");
        }

        public void showImageFileMessage(imageFileMessage message)
        {
            singleChatMessageBox.SelectionFont = new Font("黑体", 9, FontStyle.Bold);
            singleChatMessageBox.SelectionColor = System.Drawing.Color.Purple;
            singleChatMessageBox.SelectionIndent = 2;
            singleChatMessageBox.SelectionBullet = true;
            singleChatMessageBox.AppendText(publicClass.onlineUserList.Find(s => s.id == message.sendUser).userName + "  [" + message.sendTime + "]\r\n");

            singleChatMessageBox.SelectionFont = new Font("宋体", 9, FontStyle.Regular);
            singleChatMessageBox.SelectionColor = System.Drawing.Color.Blue;
            singleChatMessageBox.SelectionIndent = 19;
            singleChatMessageBox.SelectionBullet = false;
            Clipboard.Clear();   //清空剪贴板
            Bitmap bmp = new Bitmap(message.fileName);  //创建Bitmap类对象
            Clipboard.SetImage(bmp);  //将Bitmap类对象写入剪贴板
            singleChatMessageBox.Paste();   //将剪贴板中的对象粘贴到RichTextBox1
            Clipboard.Clear();
            singleChatMessageBox.AppendText("\r\n");
        }

        public void AddMessage(imageFileMessage message)
        {
            singleChatMessageBox.SelectionFont = new Font("黑体", 9, FontStyle.Bold);
            singleChatMessageBox.SelectionColor = System.Drawing.Color.Purple;
            singleChatMessageBox.SelectionIndent = 2;
            singleChatMessageBox.SelectionBullet = true;
            singleChatMessageBox.AppendText( publicClass.onlineUserList.Find(s => s.id == message.sendUser).userName + "  [" + message.sendTime + "]\r\n");

            singleChatMessageBox.SelectionFont = new Font("宋体", 9, FontStyle.Regular);
            singleChatMessageBox.SelectionColor = System.Drawing.Color.Blue;
            singleChatMessageBox.SelectionIndent = 19;
            singleChatMessageBox.SelectionBullet = false;
            //singleChatMessageBox.AppendText("【图片/文件消息  点击查看】\r\n" );
            //LinkLabel l1 = new LinkLabel();
            //l1.Text = "333";
            //singleChatMessageBox.Controls.Add(l1);
            Clipboard.Clear();   //清空剪贴板
            Bitmap bmp = new Bitmap(Application.StartupPath+"\\src\\"+message.fileName);  //创建Bitmap类对象
            Clipboard.SetImage(bmp);  //将Bitmap类对象写入剪贴板
            singleChatMessageBox.Paste();   //将剪贴板中的对象粘贴到RichTextBox1
            Clipboard.Clear();
            singleChatMessageBox.AppendText("\r\n");
        }

        private void SingleUserBox1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择要传的文件";
            ofd.InitialDirectory = @"C:";
            ofd.Filter = "图片文件|*.jpg";
            ofd.ShowDialog();
            //得到选择文件的路径
            publicClass.sendFileName = ofd.FileName;
            inputBox.Text = ofd.FileName;
            publicClass.sendMsgStatus = 1;
        }

        public void sendMsg()
        {
            if (inputBox.ForeColor != Color.Gray || inputBox.Text != "")
            {
                textMessage message = new textMessage();
                message.content = inputBox.Text;
                message.target = (int)targetUserID;
                message.sendUser = publicClass.mainUser.id;
                message.sendTime = DateTime.Now;
                AddMessage(message);
                if(publicClass.myChat.ContainsKey(message.target))
                {
                    publicClass.myChat[message.target].addMessage(message);
                }
                else
                {
                    singleChatSession chatSession = new singleChatSession(message.target);
                    chatSession.addMessage(message);
                    publicClass.myChat.Add(message.target, chatSession);
                }
                string sendMessage = JsonConvert.SerializeObject(new command() { data = message, type = 1, subType = "singleChatTextMessage", res = "" });//序列化
                publicClass.cSocket.sendSysMsg(sendMessage,0);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (publicClass.sendMsgStatus == 0)
            {
                sendMsg();
            }
            else if(publicClass.sendMsgStatus == 1)
            {
                List<int> l1= new List<int>() { (int)targetUserID };
                publicClass.cSocket.SendBigFile(publicClass.sendFileName,publicClass.mainUser.id,l1,"singleChatImageFileMsg");
            }
            publicClass.sendMsgStatus = 0;
            inputBox.Clear();
        }

        private void SingleChat_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                sendMsg();
            }
        }

        private void FileSelectBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择要传的文件";
            ofd.InitialDirectory = @"C:";
            ofd.Filter = "文本文件|*.txt|图片文件|*.jpg|视频文件|*.avi|所有文件|*.*";
            ofd.ShowDialog();
            //得到选择文件的路径
            publicClass.sendFileName = ofd.FileName;
            inputBox.Text = ofd.FileName;
            publicClass.sendMsgStatus = 1;
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void singleChat_Load(object sender, EventArgs e)
        {

        }
    }
}
