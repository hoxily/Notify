using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Net;
using notify;
using System.Web.Script.Serialization;

namespace NotifyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient();
            client.Connect(new IPEndPoint(IPAddress.Loopback, 1001));
            NotifyMessage msg = new NotifyMessage {
                VerifyCode = "NOTIFY1.0.0.0",
                Timeout = 5000,
                TipTitle = "Tip Tile",
                TipText = "Test notify:)<>>KK!@#!$$汉字"
            };
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string json = serializer.Serialize(msg);
            byte[] buffer = Encoding.UTF8.GetBytes(json);
            NetworkStream ns = client.GetStream();
            ns.Write(buffer, 0, buffer.Length);
            ns.Close();
            client.Close();
        }
    }
}
