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

namespace onlineChat
{
    public partial class startNewGroup : Form
    {
        public List<user> selectedUser;
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
                //向服务端发送建群请求
                //selectedUser
            }
        }


        private void selectUserBox_DoubleClickSubItem(object sender, ChatListEventArgs e)
        {
            if(e.SelectSubItem.Status == ChatListSubItem.UserStatus.OffLine)
            {
                e.SelectSubItem.Status = ChatListSubItem.UserStatus.Online;
                e.SelectSubItem.NicName = "已选择";
                selectedUser.Add(publicClass.onlineUserList[(int)e.SelectSubItem.ID]);
            }
            else
            {
                e.SelectSubItem.Status = ChatListSubItem.UserStatus.OffLine;
                e.SelectSubItem.NicName = "未选择";
                foreach(user i in selectedUser)
                {
                    if(i.id== (int)e.SelectSubItem.ID)
                    {
                        selectedUser.Remove(i);
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
