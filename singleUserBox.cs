using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlineChat
{
    public partial class singleUserBox : UserControl
    {
        private string userName;
        public singleUserBox()
        {
            InitializeComponent();
        }
        public string userInfo
        {
            get { return userName; }
            set { userName = value; }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
