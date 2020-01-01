using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin.SkinControl;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;

namespace onlineChat
{
    public partial class startNewGroup : Form
    {
        public List<int> selectedUserID;
        public startNewGroup()
        {
            InitializeComponent();
            List<user> onlineUserList = publicClass.onlineUserList;  //在线用户
            ChatListItem onlineUser = new ChatListItem("请选择在线用户");
            foreach (user i in onlineUserList)  //绘制在线列表
            {
                ChatListSubItem sub = new ChatListSubItem();
                sub.NicName = "下线";
                sub.Status = ChatListSubItem.UserStatus.OffLine;
                sub.ID = (uint)i.id;
                sub.DisplayName = i.userName;
                sub.PersonalMsg = i.IPAddress;
                onlineUser.SubItems.Add(sub);
            }
            this.selectUserBox.Items.Add(onlineUser);
        }

        private void startGroupBtn_Click(object sender, EventArgs e)
        {
            if(this.newGroupName.Text=="")
            {
                MessageBox.Show("请设置群名称");
            }
            else
            {
                selectedUserID.Add(publicClass.mainUser.id);
                ArrayList groupMessage = new ArrayList() {newGroupName.Text,selectedUserID};
                string sendMessage = JsonConvert.SerializeObject(new command() { data = groupMessage, type = 0, subType = "createGroup", res = "" });//序列化
                publicClass.cSocket.sendSysMsg(sendMessage);
                this.Close();
            }
        }


        private void selectUserBox_DoubleClickSubItem(object sender, ChatListEventArgs e)
        {
            if(e.SelectSubItem.Status == ChatListSubItem.UserStatus.OffLine)
            {
                e.SelectSubItem.Status = ChatListSubItem.UserStatus.Online;
                e.SelectSubItem.NicName = "已选择";
                selectedUserID.Add((int)e.SelectSubItem.ID);
            }
            else
            {
                e.SelectSubItem.Status = ChatListSubItem.UserStatus.OffLine;
                e.SelectSubItem.NicName = "未选择";
                foreach(int i in selectedUserID)
                {
                    if(i== (int)e.SelectSubItem.ID)
                    {
                        selectedUserID.Remove(i);
                        break;
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void selectUserBox_Click(object sender, EventArgs e)
        {

        }
    }
}
