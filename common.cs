using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace onlineChat
{
    //用户类
    class user
    {
        public string userName;
        public string IPAddress;
        //public string port;
        public string isOnline;
        public int avatar;//头像编号

        //获取本机IP地址
        public string getIPAddress()
        {
            string ip_addr;         //声明ip_addr变量存储ip地址
            string hostname = Dns.GetHostName();    //得到主机名，存储在hostname变量里面
            IPHostEntry ip = Dns.GetHostEntry(hostname);
            //IPHostEntry：为主机地址（多个）提供容器,实例化IPHostEntry为ip
            //Dns.GetHostEntry(hostname)：将主机名或 IP 地址解析为 IPHostEntry 实例，ip.addressList数组中存储有多个ip地址
            for (int i = 0; i < ip.AddressList.Length; i++)
            //遍历addressList数组得到IPv4的地址(主流IP地址)
            {
                if (ip.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                //判断ip类型：
                //对于 IPv4，返回 System.Net.Sockets.AddressFamily.InterNetwork；
                //对于 IPv6，返回 System.Net.Sockets.AddressFamily.InterNetworkV6
                {
                    ip_addr = ip.AddressList[i].ToString();
                    //利用ip_addr变量存储IP地址
                    return ip_addr;
                }
            }
            return "false";
        }
        public user(string userName="admin")
        {
            userName = userName;
            string tmp = getIPAddress();
            IPAddress = tmp!="false" ? tmp : "127.0.0.1";
        }
    }

    //消息基类
    class baseMessage
    {
        public user sendUser;
        public DateTime sendTime;
        public bool isValid;
    }

    //文本消息
    class textMessage : baseMessage
    {
        public string content;
    }

    //图片/文件消息
    class imageFileMessage : baseMessage
    {
        public string fileName;
        public string fileSize;
        public string fileType;
        public string filePath;
    }

    //某个聊天连接
    class chatSession
    {
        public string createTime;
        public List<user> userList;
        public List<baseMessage> messageList;

        //构造函数
        public chatSession()
        {
            createTime = DateTime.Now.ToString();
            userList = new List<user>();
            messageList = new List<baseMessage>();
        }

        //添加一条聊天记录，可以是文字，图片，文件
        public void addMessage(baseMessage message)
        {
            messageList.Add(message);//添加到数组末尾
        }

        //添加一个用户
        public void addUser(user targetUaer)
        {
            userList.Add(targetUaer);
        }

    }

    //客户端socket
    class clientSocket
    {
        public IPAddress serverIPAddress;//服务器IP地址
        //public int serverTextPort;//服务器文本监听端口
        //public int serverImagePort;//。。。
        //public int serverFilePort;//
        private List<int> serverPorts;//端口列表
        private bool isRun;//运行标志
        //private Socket cSocket;//套接字
        private List<Socket> cSockets;//套接字列表
        private List<Thread> messageThread;//消息接收线程列表

        //构造函数
        public clientSocket(IPAddress sIP, List<int> sP)
        {
            serverIPAddress = sIP;
            serverPorts = sP;
            cSockets = new List<Socket>();
            messageThread = new List<Thread>();
        }

        //连接到服务器
        public bool connectSocket()
        {
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    cSockets[i] = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPEndPoint point = new IPEndPoint(serverIPAddress, Convert.ToInt32(serverPorts[i]));
                    cSockets[i].Connect(point);
                }
                //线程接收消息
                //messageThread.Add(new Thread(receiveText));
                //messageThread.Add(new Thread(receiveImage));
                //messageThread.Add(new Thread(receiveFile));
                return true;
            }
            catch
            {
                return false;
            }
        }

        //接收消息函数簇
        //public textMessage receiveText()
        //{

        //}
    }
}
