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
        public login()
        {
            InitializeComponent();
            userNameCheckPicture.Hide();
            sameNameWarning.Hide();
            loginBtn.Enabled = false;
            userNameBox.LostFocus += new EventHandler(this.userNameCheck);  //用户名输入框失焦
        }

        private void userNameCheck(object sender ,EventArgs e) //用户名输入框失焦操作
        {
            if (userNameBox.Text == "hwy")
            {
                userNameCheckPicture.ImageLocation = "../..//src/img/greenYes.png";
                userNameCheckPicture.Show();
                sameNameWarning.Hide();
                loginBtn.Enabled = true;
            }
            else if (userNameBox.Text == "")
            {
                userNameCheckPicture.Hide();
                sameNameWarning.Hide();
                loginBtn.Enabled = false;
            }
            else
            {
                userNameCheckPicture.ImageLocation = "../..//src/img/redNo.png";
                sameNameWarning.Show();
                userNameCheckPicture.Show();
                loginBtn.Enabled = false;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
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
    }
}
