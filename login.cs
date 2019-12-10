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

namespace onlineChat
{
    public partial class login : Form
    {
        public bool isLogin = false;
        public int isExist;  //标识账户是否存在，未判断为0，存在为1，不存在为-1

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
            if (userNameBox.Text == "hwy")
            {
                userNameCheckPicture.ImageLocation = "../..//src/img/greenYes.png";
                userNameCheckPicture.Show();
                userNameTips.Hide();
                isExist = 1;
            }
            else if (userNameBox.Text == "")
            {
                userNameCheckPicture.Hide();
                userNameTips.Hide();
                isExist = 0;
            }
            else
            {
                userNameCheckPicture.ImageLocation = "../..//src/img/blueQues.png";
                userNameTips.Show();
                userNameCheckPicture.Show();
                isExist = -1;
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
                    if(passwordBox.Text!="")//新建账户并进入
                    {
                        List<int> ports = new List<int>();
                        ports.Add(8888);
                        ports.Add(8889);
                        ports.Add(8890);
                        ports.Add(8891);
                        clientSocket c1 = new clientSocket(IPAddress.Parse("127.0.0.1"), ports);
                        c1.connectSocket();
                        this.DialogResult = DialogResult.OK;
                        Close();
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
                    this.DialogResult = DialogResult.OK;
                    Close();
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
    }
}
