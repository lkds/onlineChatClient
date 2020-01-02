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
            DrawMessage();
            drawList();
        }

        public void DrawMessage()
        {
            ArrayList messages=null;
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
                    groupChatMessageBox.Text = groupChatMessageBox.Text + "\r\n" + i.sendUser + "  [" + i.sendTime + "]";

                    groupChatMessageBox.SelectionFont = new Font("宋体", 9, FontStyle.Regular);
                    groupChatMessageBox.SelectionColor = System.Drawing.Color.Black;
                    groupChatMessageBox.SelectionIndent = 19;
                    groupChatMessageBox.SelectionBullet = false;
                    groupChatMessageBox.Text = groupChatMessageBox.Text + "\r\n" + ((textMessage)i).content;
                }
                else if (i.GetType() == typeof(imageFileMessage))
                {
                    groupChatMessageBox.SelectionFont = new Font("黑体", 9, FontStyle.Bold);
                    groupChatMessageBox.SelectionColor = System.Drawing.Color.Purple;
                    groupChatMessageBox.SelectionIndent = 2;
                    groupChatMessageBox.SelectionBullet = true;
                    groupChatMessageBox.Text = groupChatMessageBox.Text + "\r\n" + i.sendUser + "  [" + i.sendTime + "]";

                    groupChatMessageBox.SelectionFont = new Font("宋体", 9, FontStyle.Regular);
                    groupChatMessageBox.SelectionColor = System.Drawing.Color.Blue;
                    groupChatMessageBox.SelectionIndent = 19;
                    groupChatMessageBox.SelectionBullet = false;
                    groupChatMessageBox.Text = groupChatMessageBox.Text + "\r\n" + "【图片/文件消息  点击查看】";
                }
            }
        }

        public void AddMessage(textMessage message)
        {
            groupChatMessageBox.SelectionFont = new Font("黑体", 9, FontStyle.Bold);
            groupChatMessageBox.SelectionColor = System.Drawing.Color.Purple;
            groupChatMessageBox.SelectionIndent = 2;
            groupChatMessageBox.SelectionBullet = true;
            groupChatMessageBox.Text = groupChatMessageBox.Text + "\r\n" + message.sendUser + "  [" + message.sendTime + "]";

            groupChatMessageBox.SelectionFont = new Font("宋体", 9, FontStyle.Regular);
            groupChatMessageBox.SelectionColor = System.Drawing.Color.Black;
            groupChatMessageBox.SelectionIndent = 19;
            groupChatMessageBox.SelectionBullet = false;
            groupChatMessageBox.Text = groupChatMessageBox.Text + "\r\n" + ((textMessage)message).content;
        }

        public void AddMessage(imageFileMessage message)
        {
            groupChatMessageBox.SelectionFont = new Font("黑体", 9, FontStyle.Bold);
            groupChatMessageBox.SelectionColor = System.Drawing.Color.Purple;
            groupChatMessageBox.SelectionIndent = 2;
            groupChatMessageBox.SelectionBullet = true;
            groupChatMessageBox.Text = groupChatMessageBox.Text + "\r\n" + message.sendUser + "  [" + message.sendTime + "]";

            groupChatMessageBox.SelectionFont = new Font("宋体", 9, FontStyle.Regular);
            groupChatMessageBox.SelectionColor = System.Drawing.Color.Blue;
            groupChatMessageBox.SelectionIndent = 19;
            groupChatMessageBox.SelectionBullet = false;
            groupChatMessageBox.Text = groupChatMessageBox.Text + "\r\n" + "【图片/文件消息  点击查看】";
        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void chatSendBtn_Click(object sender, EventArgs e)
        {
            if (inputBox.ForeColor != Color.Gray && inputBox.Text != "")
            {
                textMessage message = new textMessage();
                message.content = inputBox.Text;
                message.target = (int)groupID;
                message.sendUser = publicClass.mainUser.id;
                AddMessage(message);
                foreach(group i in publicClass.groupList)
                {
                    if(i.id==groupID)
                    {
                        i.addMessage(message);
                        break;
                    }
                }
                string sendMessage = JsonConvert.SerializeObject(new command() { data = message, type = 0, subType = "groupChatTextMessage", res = "" });//序列化
                publicClass.cSocket.sendSysMsg(sendMessage,0);
            }
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

    }
}
