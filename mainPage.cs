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
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
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
    }
}
