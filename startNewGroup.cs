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
            }
        }


        private void selectUserBox_DoubleClickSubItem(object sender, ChatListEventArgs e)
        {
            e.SelectSubItem.Status= ChatListSubItem.UserStatus.Online;
            e.SelectSubItem.NicName = "已选择";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void selectUserBox_Click(object sender, EventArgs e)
        {

        }
    }
}
