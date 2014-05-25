# 概述
本程序的目的是创建一个监听远程发送过来的通知消息并以声音与文本等方式加以提醒的工具。

本程序最初用于让位于虚拟机中的Weechat发送提醒到虚拟机外的Windows，因为虚拟机中安装的Archlinux没有安装X，平时使用也是通过SSH+Tmux连接。

# 消息格式
发送端与接收端通过Socket通信，传送JSON格式包装的通知消息。

消息格式如下：
    public class NotifyMessage
    {
        public string VerifyCode;
        public int Timeout;
        public string TipTitle;
        public string TipText;
    }
转成JSON字符串后以UTF-8编码传送到接收端。

接收端反向操作，还原出原始消息，并加以提醒。

# 更多特性
- 是否可以增加消息类别，并配备相应的提示声音？
- DataGrid中的消息文本无法复制，是否需要增加复制功能？
- 如果有多个发送来源，是否可以做一下分类？
