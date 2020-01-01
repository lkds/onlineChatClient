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

namespace onlineChat
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
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

        public void drawList(ArrayList allThreeList)  //绘制三个列表
        {
            ArrayList onlineUserList = (ArrayList)allThreeList[0];  //在线用户
            ArrayList recentChatList = (ArrayList)allThreeList[1];  //最近聊
            ArrayList groupChatList = (ArrayList)allThreeList[2];  //群聊

            ChatListItem onlineUser = new ChatListItem("在线用户");
            ChatListItem recentChat = new ChatListItem("最近聊天用户");
            ChatListItem groupChat = new ChatListItem("群组聊天");

            foreach(user i in onlineUserList)  //绘制在线列表
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
                sub.PersonalMsg = "";
                sub.Status = ChatListSubItem.UserStatus.QMe;
                groupChat.SubItems.Add(sub);
            }
            this.groupChatListBox.Items.Add(groupChat);
        }

        //头像闪动
        public void userHeadTwinkle(string name)
        {
            this.onlineUserListBox.GetSubItemsByDisplayName(name)[0].IsTwinkle=true;
            this.recentChatListBox.GetSubItemsByDisplayName(name)[0].IsTwinkle = true;
            this.groupChatListBox.GetSubItemsByDisplayName(name)[0].IsTwinkle = true;
        }

        //头像停止闪动
        public void userHeadNotTwinkle(string name)
        {
            this.onlineUserListBox.GetSubItemsByDisplayName(name)[0].IsTwinkle = false;
            this.recentChatListBox.GetSubItemsByDisplayName(name)[0].IsTwinkle = false;
            this.groupChatListBox.GetSubItemsByDisplayName(name)[0].IsTwinkle = false;
        }

        //头像变灰（下线）
        public void userHeadDark(string name)
        {
            this.onlineUserListBox.GetSubItemsByDisplayName(name)[0].Status= ChatListSubItem.UserStatus.OffLine;
            this.onlineUserListBox.GetSubItemsByDisplayName(name)[0].NicName = "下线";
            this.recentChatListBox.GetSubItemsByDisplayName(name)[0].Status = ChatListSubItem.UserStatus.OffLine;
            this.recentChatListBox.GetSubItemsByDisplayName(name)[0].NicName = "下线";
        }

        //头像变亮（上线）
        public void userHeadBright(string name)
        {
            this.onlineUserListBox.GetSubItemsByDisplayName(name)[0].Status = ChatListSubItem.UserStatus.Online;
            this.onlineUserListBox.GetSubItemsByDisplayName(name)[0].NicName = "在线";
            this.recentChatListBox.GetSubItemsByDisplayName(name)[0].Status = ChatListSubItem.UserStatus.Online;
            this.recentChatListBox.GetSubItemsByDisplayName(name)[0].NicName = "在线";
        }

        private void onlineUserListBox_Click(object sender, EventArgs e)
        {

        }

        private void onlineUserListBox_DoubleClickSubItem(object sender, ChatListEventArgs e, MouseEventArgs es)
        {
            e.SelectSubItem.IsTwinkle = false;
            if (publicClass.s1 != null || e.SelectSubItem.DisplayName != publicClass.s1.currentUserName)
            {
                publicClass.s1 = new singleChat(e.SelectSubItem.DisplayName);
            }
        }

        private void recentChatListBox_DoubleClickSubItem(object sender, ChatListEventArgs e, MouseEventArgs es)
        {
            e.SelectSubItem.IsTwinkle = false;
            if (publicClass.s1 != null || e.SelectSubItem.DisplayName != publicClass.s1.currentUserName)
            {
                publicClass.s1 = new singleChat(e.SelectSubItem.DisplayName);
            }
        }

        private void groupChatListBox_DoubleClickSubItem(object sender, ChatListEventArgs e, MouseEventArgs es)
        {
            e.SelectSubItem.IsTwinkle = false;
            if (publicClass.g1 != null || e.SelectSubItem.DisplayName != publicClass.g1.groupName)
            {
                publicClass.g1 = new groupChat(e.SelectSubItem.DisplayName);
            }
        }
    }
}
