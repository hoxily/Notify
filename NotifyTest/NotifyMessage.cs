using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace notify
{
    public class NotifyMessage
    {
        public string VerifyCode;
        public int Timeout;
        public string TipTitle;
        public string TipText;
        public NotifyMessage()
        {
        }
        public NotifyMessage(string verifyCode, int timeout, string tipTitle, string tipText)
        {
            VerifyCode = verifyCode;
            Timeout = timeout;
            TipTitle = tipTitle;
            TipText = tipText;
        }
    }
    public class LoggedNotifyMessage : NotifyMessage
    {
        public DateTime TimeStamp;
        public LoggedNotifyMessage(NotifyMessage nMsg)
            : base(nMsg.VerifyCode, nMsg.Timeout, nMsg.TipTitle, nMsg.TipText)
        {
            TimeStamp = DateTime.Now;
        }
    }
}
