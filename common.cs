using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineChat
{
    class user
    {
        public string userName;
        public string IPAddress;
        public string port;
        public string isOnline;
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
    class chat
    {
        public string createTime;
        public List<user> userList;

    }
}
