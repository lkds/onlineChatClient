using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace onlineChat
{
    public partial class mainWindow : Skin_Metro
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void Avatar_Click(object sender, EventArgs e)
        {

        }

        private void OnlineList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            login l1 = new login();
            l1.Show();
        }

        private void SingleUserBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
