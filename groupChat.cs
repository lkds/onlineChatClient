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
    public partial class groupChat : Form
    {
        public groupChat()
        {
            InitializeComponent();
            inputBox.ForeColor = Color.Gray;
            inputBox.Text = "此处输入文字消息......";
            inputBox.LostFocus += new EventHandler(this.inputTip);  //消息输入框失焦
            inputBox.Enter += new EventHandler(this.inputTipCancel);  //消息输入框得到焦点
        }

        private void inputTipCancel(object sender, EventArgs e)  //消息框得到焦点取消文字提示
        {
            if (inputBox.Text != "此处输入文字消息......")
                inputBox.ForeColor = Color.Black;
            else
            {
                inputBox.ForeColor = Color.Black;
                inputBox.Text = "";
            }
        }

        private void inputTip(object sender, EventArgs e)  //消息框失焦提示文字
        {
            if (inputBox.Text == "")
            {
                inputBox.ForeColor = Color.Gray;
                inputBox.Text = "此处输入文字消息......";
            }
        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void chatSendBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
