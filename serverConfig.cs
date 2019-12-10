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
    public partial class serverConfig : Form
    {
        public serverConfig()
        {
            InitializeComponent();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            publicClass.serverIP = IPAddress.Parse(serverIPBox.Text);
            publicClass.serverPorts = new List<int>()
            {
                int.Parse(sysPort.Text),
                int.Parse(txtPort.Text),
                int.Parse(imgPort.Text),
                int.Parse(filePort.Text),
            };
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
