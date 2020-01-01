using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace onlineChat  
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            publicClass.l1 = new login();
            publicClass.l1.ShowDialog();
            if (publicClass.l1.DialogResult == DialogResult.OK)
            {
                publicClass.m1 = new mainPage();
                Application.Run(publicClass.m1);
            }else
            {
                System.Environment.Exit(0);
            }
        }
    }

    //全局变量
    //static class globalVar
    //{
    //    //public static user mainUser=new user();//当前用户
    //    //public static Dictionary<int,chatSession> myChat = new Dictionary<int, chatSession>();//保存本地聊天会话

    //}
}
