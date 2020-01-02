using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace onlineChat
{
    public partial class login : Form
    {
        public bool isLogin = false;
        public int isExist;  //标识账户是否存在，未判断为0，存在为1，不存在为-1
        public string defaultIP="127.0.0.1";

        public login()
        {
            InitializeComponent();
            userNameCheckPicture.Hide();
            userNameTips.Hide();
            isExist = 0;
            // loginBtn.Enabled = false;
            userNameBox.LostFocus += new EventHandler(this.userNameCheck);  //用户名输入框失焦
        }

        private void userNameCheck(object sender ,EventArgs e) //用户名输入框失焦操作
        {
            string secUser = JsonConvert.SerializeObject(new command() { data = userNameBox.Text, type = 0, subType = "checkUserName" ,res=""});//序列化
            if (publicClass.isRun)
            {
                publicClass.cSocket.sendSysMsg(secUser,0);
                userNameCheck(true);
            }
            //if (userNameBox.Text == "hwy")
            //{
            //    userNameCheckPicture.ImageLocation = "../..//src/img/greenYes.png";
            //    userNameCheckPicture.Show();
            //    userNameTips.Hide();
            //    isExist = 1;
            //}
            //else 
            //if (userNameBox.Text == "")
            //{
            //    userNameCheckPicture.Hide();
            //    userNameTips.Hide();
            //    isExist = 0;
            //}
            //else
            //{
            //    userNameCheckPicture.ImageLocation = "../..//src/img/blueQues.png";
            //    userNameTips.Show();
            //    userNameCheckPicture.Show();
            //    isExist = -1;
            //}
        }

        //用户名检测与提示显示
        public void userNameCheck(bool nameExist)
        {
            if (!nameExist)//用户名不存在
            {
                userNameCheckPicture.ImageLocation = "../..//src/img/blueQues.png";
                userNameTips.Visible = true;
                userNameCheckPicture.Visible = true;
                isExist = -1;
            }
            else //用户存在
            {
                userNameCheckPicture.ImageLocation = "../..//src/img/greenYes.png";
                    userNameCheckPicture.Visible = true;
                userNameTips.Visible = false;
                    isExist = 1;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (isExist == 0)
            {
                MessageBox.Show("请输入用户名","提示");
            }
            else if (isExist == -1)
            {
                if (MessageBox.Show("确定要新创建这个账户吗？","提示",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (passwordBox.Text != "")//新建账户并进入
                    {
                        publicClass.mainUser = new user(userNameBox.Text, publicClass.getIPAddress(),passwordBox.Text);
                        string secUser = JsonConvert.SerializeObject(new command() { data=publicClass.mainUser,type=0,subType="login",res=""});//序列化
                        publicClass.cSocket.sendSysMsg(secUser,0);
                    }
                    else
                    {
                        MessageBox.Show("密码不能为空", "提示");
                    }
                }
            }
            else
            {
                if (passwordBox.Text != "")//已有帐户进入
                {
                    List<string> l1 = new List<string>()
                    {
                        userNameBox.Text,passwordBox.Text
                    };
                    string secUser = JsonConvert.SerializeObject(new command() { data =l1, type = 0, subType = "login",res="" });//序列化
                    if (publicClass.isRun)
                    {
                        publicClass.cSocket.sendSysMsg(secUser,0);

                    }
                    //this.DialogResult = DialogResult.OK;
                    //Close();
                }
                else
                {
                    MessageBox.Show("密码不能为空", "提示");
                }
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ServerConfigBtn_Click(object sender, EventArgs e)
        {
            serverConfig s1 = new serverConfig();
            s1.Show();
        }

        private void ConnectServerBtn_Click(object sender, EventArgs e)
        {
            if (publicClass.isRun)
            {
                publicClass.isRun = false;
                publicClass.cSocket = null;
                this.label1.Enabled = false;
                this.userNameTips.Enabled = false;
                this.userNameBox.Enabled = false;
                this.userNameCheckPicture.Enabled = false;
                this.label3.Enabled = false;
                this.passwordBox.Enabled = false;
                this.loginBtn.Enabled = false;
                this.serverConfigBtn.Enabled = true;
                this.connectServerBtn.Text = "连接服务器";
            }
            else
            {
                publicClass.cSocket = new clientSocket();//创建客户端套接字
                if(publicClass.cSocket.connectSocket())
                {
                    publicClass.isRun = true;
                    this.label1.Enabled = true;
                    this.userNameTips.Enabled = true;
                    this.userNameBox.Enabled = true;
                    this.userNameCheckPicture.Enabled = true;
                    this.label3.Enabled = true;
                    this.passwordBox.Enabled = true;
                    this.loginBtn.Enabled = true;
                    this.serverConfigBtn.Enabled = false;
                    this.connectServerBtn.Text = "断开服务器";
                }
            }
        }
    }
}
