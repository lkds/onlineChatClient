﻿using System;
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
    //公共类，包含全局变量和方法
    class publicClass
    {
        //########################公共变量#############################
        public static user mainUser;//当前用户
        public static Dictionary<int, chatSession> myChat = new Dictionary<int, chatSession>();//保存本地聊天会话
        public static clientSocket cSocket;
        public static List<int> serverPorts;
        public static IPAddress serverIP;

        //########################公共方法################################
        //获取本机IP地址
        public static string getIPAddress()
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
    }

    //用户类
    class user
    {
        public int id;//用户身份ID
        public string userName;
        public string IPAddress;
        public string password;
        //public string port;
        public bool isOnline;
        public int avatar;//头像编号

        public user(int cID, string cUserName, string cIPAddress, int cAvatar, bool cIsOnline)
        {
            id = cID;
            userName = cUserName;
            IPAddress = cIPAddress;
            avatar = cAvatar;
            isOnline = cIsOnline;
        }
    }

    //群组类
    class group
    {
        public int id;//
        public string groupName;
        public List<user> groupUserList;
        public int groupAvatar;//群组头像编号

        public group(int cID, string cGroupName, List<user> cGroupUserList, int cGroupAvatar)
        {
            id = cID;
            groupName = cGroupName;
            groupUserList = cGroupUserList;
            groupAvatar = cGroupAvatar;
        }

        //添加一个用户
        public void addUser(user targetUaer)
        {
            groupUserList.Add(targetUaer);
        }
        
        //删除一个用户
        public void deleteUser(user targetUser)
        {
            groupUserList.Remove(targetUser);
        }

        //退出群组,删除
        //public void quitGroup()
        //{
            
        //}
    }

    //消息基类
    class baseMessage
    {
        public user sendUser;//消息发送者
        public DateTime sendTime;
        public bool isValid;//暂时用不到
        public int target;//目标用户或者群组
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

    //某个聊天连接,可以是群组也可以是单聊
    class chatSession
    {
        public string createTime;
        public user targetUser;//单聊用户
        public group userList;//群组
        public int chatSessionType;//类型，0单聊，1群聊
        public List<baseMessage> messageList;

        //构造函数
        public chatSession(string time, int type, dynamic target, List<baseMessage> messages)
        {
            createTime = time;//创建时间
            chatSessionType = type;
            if (type == 0)
            {
                targetUser = target;
            }
            else
            {
                userList = target;
            }
            messageList = messages;//消息
        }

        //添加一条聊天记录，可以是文字，图片，文件
        public void addMessage(baseMessage message)
        {
            messageList.Add(message);//添加到数组末尾
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
                    cSockets.Add(new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp));
                    IPEndPoint point = new IPEndPoint(serverIPAddress, Convert.ToInt32(serverPorts[i]));
                    cSockets[i].Connect(point);
                }
                //线程接收消息
                messageThread.Add(new Thread(receiveText));
                messageThread.Add(new Thread(receiveImage));
                messageThread.Add(new Thread(receiveFile));
                return true;
            }
            catch
            {
                return false;
            }
        }

        //接收消息函数簇
        public void receiveText()
        {
            byte[] textRec = new byte[4096];//创建接收消息的buffer
            int length = -1;
            try
            {
                length = cSockets[0].Receive(textRec);//接收消息长度计数

            }
            catch
            {
                return;
            }
            string strMsg = System.Text.Encoding.UTF8.GetString(textRec, 0, length - 1);// 将接受到的字节数据转化成字符串
            //解析
        }

        public void receiveImage()
        {
            byte[] imgRec = new byte[1024*1024*10];//创建接收消息的buffer
            int length = -1;
            try
            {
                length = cSockets[1].Receive(imgRec);//接收消息长度计数

            }
            catch
            {
                return;
            }
            //TODO
            //保存图片，显示图片
            //解析
        }

        public void receiveFile()
        {
            byte[] fileRec = new byte[1024*1024*2];//创建接收消息的buffer
            int length = -1;
            try
            {
                length = cSockets[2].Receive(fileRec);//接收消息长度计数

            }
            catch
            {
                return;
            }
            //TODO
            //保存文件
            //解析
        }

        public bool sendSysMsg(string msg)
        {
            try
            {
                //转化为字节流
                byte[] strbyte = Encoding.UTF8.GetBytes(msg);
                cSockets[0].Send(strbyte);
                return true;
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("byte为空");
                return false;
            }
            catch(SocketException)
            {
                Console.WriteLine("访问套接字出错");
                return false;

            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("用户离线");
                return false;
            }
        }
    }
}
