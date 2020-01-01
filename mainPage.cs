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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace onlineChat
{
    public partial class mainPage : Form
    {
        public bool ifNew;
        public ChatListItem onlineUser = new ChatListItem("在线用户");
        public ChatListItem recentChat = new ChatListItem("最近聊天用户");
        public ChatListItem groupChat = new ChatListItem("群组聊天");
        public mainPage()
        {
            InitializeComponent();
            ifNew = true;
            mainUserIPLabel.Text = publicClass.mainUser.IPAddress;
            mainUserNameLabel.Text = publicClass.mainUser.userName;

        }

        private void MainStartGroupBtn_Click(object sender, EventArgs e)
        {

        }

        private void MainUserAvatarBox_Click(object sender, EventArgs e)
        {

        }

        private void startNewGroupBtn_Click(object sender, EventArgs e)
        {
            startNewGroup startNewGroup1 = new startNewGroup();
            startNewGroup1.Show();
        }

        public void drawList()  //绘制三个列表
        {
            List<user> onlineUserList = publicClass.onlineUserList;  //在线用户
            List<user> recentChatList = publicClass.recentChatList; //最近聊
            List<group> groupChatList = publicClass.groupList;   //群聊

            foreach (user i in onlineUserList)  //绘制在线列表
            {
                ChatListSubItem sub = new ChatListSubItem();
                if(i.isOnline)
                {
                    sub.NicName = "在线";
                    sub.Status = ChatListSubItem.UserStatus.Online;
                }
                else
                {
                    sub.NicName = "下线";
                    sub.Status = ChatListSubItem.UserStatus.OffLine;
                }
                sub.ID = (uint)i.id;
                sub.DisplayName = i.userName;
                sub.PersonalMsg = i.IPAddress;
                onlineUser.SubItems.Add(sub);
            }
            this.onlineUserListBox.Items.Add(onlineUser);

            foreach (user i in recentChatList)  //绘制最近聊列表
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
                sub.ID = (uint)i.id;
                sub.DisplayName = i.userName;
                sub.PersonalMsg = i.IPAddress;
                recentChat.SubItems.Add(sub);
            }
            this.recentChatListBox.Items.Add(recentChat);

            foreach (group i in groupChatList)  //绘制群列表
            {
                ChatListSubItem sub = new ChatListSubItem();
                sub.NicName = "群组";
                sub.DisplayName = i.groupName;
                sub.ID = (uint)i.id;
                sub.PersonalMsg = "";
                sub.Status = ChatListSubItem.UserStatus.QMe;
                groupChat.SubItems.Add(sub);
            }
            this.groupChatListBox.Items.Add(groupChat);
        }

        //头像闪动
        public void userHeadTwinkle(uint id)
        {
            this.onlineUserListBox.GetSubItemsById(id)[0].IsTwinkle=true;
            this.recentChatListBox.GetSubItemsById(id)[0].IsTwinkle = true;
            this.groupChatListBox.GetSubItemsById(id)[0].IsTwinkle = true;
        }

        //头像停止闪动
        public void userHeadNotTwinkle(uint id)
        {
            this.onlineUserListBox.GetSubItemsById(id)[0].IsTwinkle = false;
            this.recentChatListBox.GetSubItemsById(id)[0].IsTwinkle = false;
            this.groupChatListBox.GetSubItemsById(id)[0].IsTwinkle = false;
        }

        //头像变灰（下线）
        public void userHeadDark(uint id)
        {
            this.onlineUserListBox.GetSubItemsById(id)[0].Status= ChatListSubItem.UserStatus.OffLine;
            this.onlineUserListBox.GetSubItemsById(id)[0].NicName = "下线";
            this.recentChatListBox.GetSubItemsById(id)[0].Status = ChatListSubItem.UserStatus.OffLine;
            this.recentChatListBox.GetSubItemsById(id)[0].NicName = "下线";
        }

        //头像变亮（上线）
        public void userHeadBright(uint id)
        {
            this.onlineUserListBox.GetSubItemsById(id)[0].Status = ChatListSubItem.UserStatus.Online;
            this.onlineUserListBox.GetSubItemsById(id)[0].NicName = "在线";
            this.recentChatListBox.GetSubItemsById(id)[0].Status = ChatListSubItem.UserStatus.Online;
            this.recentChatListBox.GetSubItemsById(id)[0].NicName = "在线";
        }

        private void onlineUserListBox_Click(object sender, EventArgs e)
        {

        }

        private void onlineUserListBox_DoubleClickSubItem(object sender, ChatListEventArgs e, MouseEventArgs es)
        {
            userHeadNotTwinkle(e.SelectSubItem.ID);
            if (publicClass.s1 == null )
            {
                publicClass.s1 = new singleChat(e.SelectSubItem.ID,e.SelectSubItem.DisplayName);
                publicClass.s1.Show();
            }
            else if(e.SelectSubItem.DisplayName != publicClass.s1.targetUserName)
            {
                publicClass.s1 = new singleChat(e.SelectSubItem.ID, e.SelectSubItem.DisplayName);
                publicClass.s1.Show();

            }
        }

        private void recentChatListBox_DoubleClickSubItem(object sender, ChatListEventArgs e, MouseEventArgs es)
        {
            userHeadNotTwinkle(e.SelectSubItem.ID);
            if (publicClass.s1 != null || e.SelectSubItem.DisplayName != publicClass.s1.targetUserName)
            {
                publicClass.s1 = new singleChat(e.SelectSubItem.ID,e.SelectSubItem.DisplayName);
            }
        }

        private void groupChatListBox_DoubleClickSubItem(object sender, ChatListEventArgs e, MouseEventArgs es)
        {
            userHeadNotTwinkle(e.SelectSubItem.ID);
            if (publicClass.g1 != null || e.SelectSubItem.DisplayName != publicClass.g1.groupName)
            {
                publicClass.g1 = new groupChat(e.SelectSubItem.ID,e.SelectSubItem.DisplayName);
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            string sendMessage = JsonConvert.SerializeObject(new command() { data = publicClass.mainUser.id, type = 0, subType = "mainPageListDraw", res = "" });//序列化
            publicClass.cSocket.sendSysMsg(sendMessage);
        }
    }
}
