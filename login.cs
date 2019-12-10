using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            userNameBox.LostFocus += new EventHandler(this.userNameCheck);
        }

        private void userNameCheck(object sender ,EventArgs e)
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
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
