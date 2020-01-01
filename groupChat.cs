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
        public groupChat(uint ID,string name)
        {
            InitializeComponent();
            groupName = name;
            groupID = ID;
            Text = "群组聊天【In：" + groupName + "】";
            chatGroupName.Text = name;
            DrawMessage();
            drawList();
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
            if (inputBox.ForeColor != Color.Gray || inputBox.Text != "")
            {
                textMessage message = new textMessage();
                message.content = inputBox.Text;
                message.target = (int)groupID;
                message.sendUser = publicClass.mainUser.id;
                AddMessage(message);
                string sendMessage = JsonConvert.SerializeObject(new command() { data = message, type = 0, subType = "groupChatTextMessage", res = "" });//序列化
                publicClass.cSocket.sendSysMsg(sendMessage);
            }
        }

        public void drawList()  //绘制成员列表
        {
            List<user> memberList = null;
            foreach (group i in publicClass.groupList)
            {
                if (i.id == groupID)
                {
                    memberList = i.groupUserList;
                }
            }
            ChatListItem groupMember = new ChatListItem("群组成员");

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
                        publicClass.cSocket.sendSysMsg(sendMessage);
                        publicClass.groupList.Remove(i);
                        this.Close();
                        break;
                    }
                }
            }
        }
    }
}
