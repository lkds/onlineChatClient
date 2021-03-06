﻿using System;
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
        public ChatListItem onlineUser = new ChatListItem("在线用户");
        public ChatListItem recentChat = new ChatListItem("最近聊天用户");
        public ChatListItem groupChat = new ChatListItem("群组聊天");
        public mainPage()
        {
            InitializeComponent();
            mainUserIPLabel.Text = publicClass.mainUser.IPAddress;
            mainUserNameLabel.Text = publicClass.mainUser.userName;
            mainUserAvatarBox.Image=System.Drawing.Image.FromFile("../..//src/img/avatar" + publicClass.mainUser.avatar + ".png");

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
            onlineUser.SubItems.Clear();
            recentChat.SubItems.Clear();
            groupChat.SubItems.Clear();
            foreach (user i in onlineUserList)  //绘制在线列表
            {
                if(i.id!=publicClass.mainUser.id)
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
                    sub.HeadImage = System.Drawing.Image.FromFile("../..//src/img/avatar"+i.avatar+".png");
                    sub.DisplayName = i.userName;
                    sub.PersonalMsg = i.IPAddress;
                    onlineUser.SubItems.Add(sub);
                }
            }
            this.onlineUserListBox.Items.Add(onlineUser);

            foreach (user i in recentChatList)  //绘制最近聊列表
            {
                if (i.id != publicClass.mainUser.id)
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
                    sub.HeadImage = System.Drawing.Image.FromFile("../..//src/img/avatar" + i.avatar + ".png");
                    sub.DisplayName = i.userName;
                    sub.PersonalMsg = i.IPAddress;
                    recentChat.SubItems.Add(sub);
                }
            }
            this.recentChatListBox.Items.Add(recentChat);

            foreach (group i in groupChatList)  //绘制群列表
            {
                ChatListSubItem sub = new ChatListSubItem();
                sub.NicName = "群组";
                sub.DisplayName = i.groupName;
                sub.ID = (uint)i.id;
                sub.HeadImage = System.Drawing.Image.FromFile("../..//src/img/groupAvatar.png");
                sub.PersonalMsg = "";
                sub.Status = ChatListSubItem.UserStatus.QMe;
                groupChat.SubItems.Add(sub);
            }
            this.groupChatListBox.Items.Add(groupChat);
        }

        //头像闪动
        public void userHeadTwinkle(uint id,int type)
        {
            try
            {
                if(type==0)
                {
                    this.onlineUserListBox.GetSubItemsById(id)[0].IsTwinkle = true;
                    this.recentChatListBox.GetSubItemsById(id)[0].IsTwinkle = true;
                }
                else
                {
                    this.groupChatListBox.GetSubItemsById(id)[0].IsTwinkle = true;
                }
            }
            catch
            {
                return;
            }
        }

        //头像停止闪动
        public void userHeadNotTwinkle(uint id, int type)
        {
            try
            {
                if (type == 0)
                {
                    this.onlineUserListBox.GetSubItemsById(id)[0].IsTwinkle = false;
                    this.recentChatListBox.GetSubItemsById(id)[0].IsTwinkle = false;
                }
                else
                {
                    this.groupChatListBox.GetSubItemsById(id)[0].IsTwinkle = false;
                }
            }
            catch
            {
                return;
            }
        }

        //头像变灰（下线）
        public void userHeadDark(uint id)
        {
            try
            {
                this.onlineUserListBox.GetSubItemsById(id)[0].Status = ChatListSubItem.UserStatus.OffLine;
                this.onlineUserListBox.GetSubItemsById(id)[0].NicName = "下线";
                this.recentChatListBox.GetSubItemsById(id)[0].Status = ChatListSubItem.UserStatus.OffLine;
                this.recentChatListBox.GetSubItemsById(id)[0].NicName = "下线";
            }
            catch
            {
                return;
            }
        }

        //头像变亮（上线）
        public void userHeadBright(uint id)
        {
            try
            {
                this.onlineUserListBox.GetSubItemsById(id)[0].Status = ChatListSubItem.UserStatus.Online;
                this.onlineUserListBox.GetSubItemsById(id)[0].NicName = "在线";
                this.recentChatListBox.GetSubItemsById(id)[0].Status = ChatListSubItem.UserStatus.Online;
                this.recentChatListBox.GetSubItemsById(id)[0].NicName = "在线";
            }
            catch
            {
                return;
            }
        }

        private void onlineUserListBox_Click(object sender, EventArgs e)
        {

        }

        private void onlineUserListBox_DoubleClickSubItem(object sender, ChatListEventArgs e, MouseEventArgs es)
        {
            userHeadNotTwinkle(e.SelectSubItem.ID,0);
            if (e.SelectSubItem.Status != ChatListSubItem.UserStatus.OffLine)
            {
                if (publicClass.s1 == null)
                {
                    publicClass.s1 = new singleChat(e.SelectSubItem.ID);
                    publicClass.s1.Show();
                }
                else if (e.SelectSubItem.ID != publicClass.s1.targetUserID)
                {
                    publicClass.s1.Close();
                    publicClass.s1 = new singleChat(e.SelectSubItem.ID);
                    publicClass.s1.Show();

                }
                else
                {
                    if (publicClass.s1.IsDisposed)
                    {
                        publicClass.s1 = new singleChat(e.SelectSubItem.ID);
                        publicClass.s1.Show();
                    }
                }
            }
        }

        private void recentChatListBox_DoubleClickSubItem(object sender, ChatListEventArgs e, MouseEventArgs es)
        {
            userHeadNotTwinkle(e.SelectSubItem.ID,0);
            if (e.SelectSubItem.Status != ChatListSubItem.UserStatus.OffLine)
            {
                if (publicClass.s1 == null)
                {
                    publicClass.s1 = new singleChat(e.SelectSubItem.ID);
                    publicClass.s1.Show();
                }
                else if (e.SelectSubItem.ID != publicClass.s1.targetUserID)
                {
                    publicClass.s1.Close();
                    publicClass.s1 = new singleChat(e.SelectSubItem.ID);
                    publicClass.s1.Show();

                }
                else
                {
                    if (publicClass.s1.IsDisposed)
                    {
                        publicClass.s1 = new singleChat(e.SelectSubItem.ID);
                        publicClass.s1.Show();
                    }
                }
            }
        }

        private void groupChatListBox_DoubleClickSubItem(object sender, ChatListEventArgs e, MouseEventArgs es)
        {
            userHeadNotTwinkle(e.SelectSubItem.ID,1);
            if (publicClass.g1 == null)
            {
                publicClass.g1 = new groupChat(e.SelectSubItem.ID, e.SelectSubItem.DisplayName);
                publicClass.g1.Show();
            }
            else if (e.SelectSubItem.ID != publicClass.g1.groupID)
            {
                publicClass.g1.Close();
                publicClass.g1 = new groupChat(e.SelectSubItem.ID, e.SelectSubItem.DisplayName);
                publicClass.g1.Show();

            }
            else
            {
                if (publicClass.g1.IsDisposed)
                {
                    publicClass.g1 = new groupChat(e.SelectSubItem.ID, e.SelectSubItem.DisplayName);
                    publicClass.g1.Show();
                }
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            string sendMessage = JsonConvert.SerializeObject(new command() { data = publicClass.mainUser.id, type = 0, subType = "mainPageListDraw", res = "" });//序列化
            publicClass.cSocket.sendSysMsg(sendMessage,0);
        }
    }
}
