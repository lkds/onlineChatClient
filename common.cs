using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
}
