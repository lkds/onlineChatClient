using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using CCWin.SkinControl;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace onlineChat
{
    public partial class groupChat : Form
    {
        public string groupName;
        public uint groupID;
        public ChatListItem groupMember = new ChatListItem("群组成员");
        public groupChat(uint ID,string name)
        {
            InitializeComponent();
            groupName = name;
            groupID = ID;
            Text = "群组聊天【In：" + groupName + "】";
            chatGroupName.Text = name;
            groupAvatar.Image = System.Drawing.Image.FromFile("../..//src/img/groupAvatar.png");
            DrawMessage();
            drawList();
        }

        public void DrawMessage()
        {
            try
            {
                ArrayList messages = publicClass.groupList.Find(s => s.id == (int)groupID).messageList;

            foreach(group i in publicClass.groupList)
            {
                if(i.id==groupID)
                {
                    messages = i.messageList;
                }
            }
            groupChatMessageBox.Text = "";
            foreach (baseMessage i in messages)
            {
                if (i.GetType() == typeof(textMessage))
                {
                        groupChatMessageBox.SelectionFont = new Font("黑体", 9, FontStyle.Bold);
                        groupChatMessageBox.SelectionColor = System.Drawing.Color.Purple;
                        groupChatMessageBox.SelectionIndent = 2;
                        groupChatMessageBox.SelectionBullet = true;
                        groupChatMessageBox.AppendText(publicClass.onlineUserList.Find(s => s.id == i.sendUser).userName + "  [" + i.sendTime + "]\r\n");

                        groupChatMessageBox.SelectionFont = new Font("宋体", 9, FontStyle.Regular);
                        groupChatMessageBox.SelectionColor = System.Drawing.Color.Black;
                        groupChatMessageBox.SelectionIndent = 19;
                        groupChatMessageBox.SelectionBullet = false;
                        groupChatMessageBox.AppendText(((textMessage)i).content + "\r\n");
                    }
                else if (i.GetType() == typeof(imageFileMessage))
                {
                        groupChatMessageBox.SelectionFont = new Font("黑体", 9, FontStyle.Bold);
                        groupChatMessageBox.SelectionColor = System.Drawing.Color.Purple;
                        groupChatMessageBox.SelectionIndent = 2;
                        groupChatMessageBox.SelectionBullet = true;
                        groupChatMessageBox.AppendText(publicClass.onlineUserList.Find(s => s.id == i.sendUser).userName + "  [" + i.sendTime + "]\r\n");

                        groupChatMessageBox.SelectionFont = new Font("宋体", 9, FontStyle.Regular);
                        groupChatMessageBox.SelectionColor = System.Drawing.Color.Blue;
                        groupChatMessageBox.SelectionIndent = 19;
                        groupChatMessageBox.SelectionBullet = false;
                        groupChatMessageBox.Text = groupChatMessageBox.Text + "\r\n" + "【图片/文件消息  点击查看】";
                    }
            }
            }
            catch
            {

            }
        }

        public void AddMessage(textMessage message)
        {
            groupChatMessageBox.SelectionFont = new Font("黑体", 9, FontStyle.Bold);
            groupChatMessageBox.SelectionColor = System.Drawing.Color.Purple;
            groupChatMessageBox.SelectionIndent = 2;
            groupChatMessageBox.SelectionBullet = true;
            groupChatMessageBox.AppendText(publicClass.onlineUserList.Find(s => s.id == message.sendUser).userName + "  [" + message.sendTime + "]\r\n");

            groupChatMessageBox.SelectionFont = new Font("宋体", 9, FontStyle.Regular);
            groupChatMessageBox.SelectionColor = System.Drawing.Color.Black;
            groupChatMessageBox.SelectionIndent = 19;
            groupChatMessageBox.SelectionBullet = false;
            groupChatMessageBox.AppendText(((textMessage)message).content + "\r\n");
        }

        public void AddMessage(imageFileMessage message)
        {
            groupChatMessageBox.SelectionFont = new Font("黑体", 9, FontStyle.Bold);
            groupChatMessageBox.SelectionColor = System.Drawing.Color.Purple;
            groupChatMessageBox.SelectionIndent = 2;
            groupChatMessageBox.SelectionBullet = true;
            groupChatMessageBox.AppendText(publicClass.onlineUserList.Find(s => s.id == message.sendUser).userName + "  [" + message.sendTime + "]\r\n");

            groupChatMessageBox.SelectionFont = new Font("宋体", 9, FontStyle.Regular);
            groupChatMessageBox.SelectionColor = System.Drawing.Color.Blue;
            groupChatMessageBox.SelectionIndent = 19;
            groupChatMessageBox.SelectionBullet = false;
            Clipboard.Clear();   //清空剪贴板
            Bitmap bmp = new Bitmap(message.fileName);  //创建Bitmap类对象
            Clipboard.SetImage(bmp);  //将Bitmap类对象写入剪贴板
            groupChatMessageBox.Paste();   //将剪贴板中的对象粘贴到RichTextBox1
            Clipboard.Clear();
            groupChatMessageBox.AppendText("\r\n");
        }

        public void showImageFileMessage(imageFileMessage message)
        {
            groupChatMessageBox.SelectionFont = new Font("黑体", 9, FontStyle.Bold);
            groupChatMessageBox.SelectionColor = System.Drawing.Color.Purple;
            groupChatMessageBox.SelectionIndent = 2;
            groupChatMessageBox.SelectionBullet = true;
            groupChatMessageBox.AppendText(publicClass.onlineUserList.Find(s => s.id == message.sendUser).userName + "  [" + message.sendTime + "]\r\n");

            groupChatMessageBox.SelectionFont = new Font("宋体", 9, FontStyle.Regular);
            groupChatMessageBox.SelectionColor = System.Drawing.Color.Blue;
            groupChatMessageBox.SelectionIndent = 19;
            groupChatMessageBox.SelectionBullet = false;
            Clipboard.Clear();   //清空剪贴板
            Bitmap bmp = new Bitmap(message.fileName);  //创建Bitmap类对象
            Clipboard.SetImage(bmp);  //将Bitmap类对象写入剪贴板
            groupChatMessageBox.Paste();   //将剪贴板中的对象粘贴到RichTextBox1
            Clipboard.Clear();
            groupChatMessageBox.AppendText("\r\n");
        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void sendMsg()
        {
            if (inputBox.ForeColor != Color.Gray && inputBox.Text != "")
            {
                textMessage message = new textMessage();
                message.content = inputBox.Text;
                message.target = (int)groupID;
                message.sendUser = publicClass.mainUser.id;
                AddMessage(message);
                foreach (group i in publicClass.groupList)
                {
                    if (i.id == groupID)
                    {
                        i.addMessage(message);
                        break;
                    }
                }
                string sendMessage = JsonConvert.SerializeObject(new command() { data = message, type = 0, subType = "groupChatTextMessage", res = "" });//序列化
                publicClass.cSocket.sendSysMsg(sendMessage, 0);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void chatSendBtn_Click(object sender, EventArgs e)
        {
            drawList();
            if (publicClass.sendMsgStatus == 0)
            {
                sendMsg();
            }
            else if (publicClass.sendMsgStatus == 1)
            {
                List<int> l1 = new List<int>();
                foreach (var i in publicClass.groupList)
                {
                    if (i.id == groupID)
                    {
                        foreach (var u in i.groupUserList)
                        {
                            l1.Add(u.id);
                        }
                    }
                }
                publicClass.cSocket.SendBigFileG(publicClass.sendFileName, publicClass.mainUser.id, l1, "singleChatImageFileMsg");
            }
            publicClass.sendMsgStatus = 0;
            inputBox.Clear();
        }

        public void drawList()  //绘制成员列表
        {
            List<user> memberList=new List<user>();
            foreach (group i in publicClass.groupList)
            {
                if (i.id == groupID)
                {
                    memberList = i.groupUserList;
                }
            }
            groupMember.SubItems.Clear();
            foreach (user i in memberList)  //绘制在线列表
            {
                ChatListSubItem sub = new ChatListSubItem();
                if (i.isOnline)
                {
                    sub.NicName = "在线";
                    sub.Status = ChatListSubItem.UserStatus.Online;
                }
                else
                {
                    sub.NicName = "下线";
                    sub.Status = ChatListSubItem.UserStatus.OffLine;
                }
                sub.DisplayName = i.userName;
                sub.PersonalMsg = i.IPAddress;
                sub.HeadImage = System.Drawing.Image.FromFile("../..//src/img/avatar" + i.avatar + ".png");
                groupMember.SubItems.Add(sub);
            }
            this.groupMemberListBox.Items.Add(groupMember);
        }

        private void chatQuitGroupBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("点击“确定”将退出此群聊", "退出群聊？", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)==DialogResult.OK)
            {
                foreach(group i in publicClass.groupList)
                {
                    if(i.id==groupID)
                    {
                        List<int> quitMessage = new List<int>() {publicClass.mainUser.id,(int)groupID};
                        string sendMessage = JsonConvert.SerializeObject(new command() { data = quitMessage, type = 1, subType = "quitGroup", res = "" });//序列化
                        publicClass.cSocket.sendSysMsg(sendMessage,0);
                        publicClass.groupList.Remove(i);
                        this.Close();
                        break;
                    }
                }
            }
        }

        private void GroupChat_Load(object sender, EventArgs e)
        {

        }

        private void GroupMemberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ImageSelectBox_Click(object sender, EventArgs e)
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
    }
}
