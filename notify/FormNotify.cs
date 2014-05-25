using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Web.Script.Serialization;
using System.Media;
/*
 * 2014-05-16 bug fix: 消息接收时间内容列不应该用datetime.ToString()方法，这样子无法正确排序。需要补上前导0
 * */

namespace notify
{
    public partial class FormNotify : Form
    {
        private SoundPlayer NotifySoundPlayer;
        private Thread TcpListenerThread;
        private List<LoggedNotifyMessage> NotifyList;
        public FormNotify()
        {
            InitializeComponent();
            myNotify.Visible = true;
            NotifyList = new List<LoggedNotifyMessage>();
            NotifySoundPlayer = new SoundPlayer("Resource/msg.wav");
        }

        private void TcpListening()
        {
            System.Net.Sockets.TcpListener listener = new TcpListener(IPAddress.Any, 1001);
            try
            {
                listener.Start();
            }
            catch (SocketException e)
            {
                MessageBox.Show(e.Message);
                Application.Exit();
            }
            byte[] buffer = new byte[2048];
            MemoryStream stream;
            while (true)
            {
                stream = new MemoryStream();
                Socket client = listener.AcceptSocket();
                try
                {
                    int receivedLength;
                    do
                    {
                        receivedLength = client.Receive(buffer);
                        stream.Write(buffer, 0, receivedLength);
                    } while (receivedLength > 0);
                }
                catch (SocketException)
                {
                }
                finally
                {
                    stream.Position = 0;
                    string json = (new StreamReader(stream, Encoding.UTF8)).ReadToEnd();
                    client.Close();
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    NotifyMessage msg = null;
                    try
                    {
                        msg = serializer.Deserialize<NotifyMessage>(json);
                    }
                    catch (Exception e)
                    {
                    }
                    stream.Close();
                    if (msg != null && msg.VerifyCode == "NOTIFY1.0.0.0")
                    {
                        myNotify.ShowBalloonTip(msg.Timeout, msg.TipTitle, msg.TipText, ToolTipIcon.Info);
                        AddNotify(msg);
                    }
                }
            }
        }

        private void AddNotify(NotifyMessage msg)
        {
            NotifySoundPlayer.Play();
            NotifyList.Add(new LoggedNotifyMessage(msg));
            this.Invoke(new Action(UpdateNotifyListWindow));
        }
        private void UpdateNotifyListWindow()
        {
            notifyDataGrid.Rows.Add();
            LoggedNotifyMessage msg = NotifyList[NotifyList.Count - 1];
            DataGridViewRow row = notifyDataGrid.Rows[notifyDataGrid.Rows.Count - 1];
            row.Cells["ColumnTime"].Value = msg.TimeStamp.ToString("yyyy-MM-dd HH:mm:ss");
            row.Cells["ColumnTime"].ToolTipText = msg.TimeStamp.ToString("yyyy-MM-dd HH:mm:ss");
            row.Cells["ColumnTimeout"].Value = msg.Timeout.ToString();
            row.Cells["ColumnTimeout"].ToolTipText = msg.Timeout.ToString();
            row.Cells["ColumnTitle"].Value = msg.TipTitle;
            row.Cells["ColumnTitle"].ToolTipText = msg.TipTitle;
            row.Cells["ColumnText"].Value = msg.TipText;
            row.Cells["ColumnText"].ToolTipText = msg.TipText;
        }

        private void FormNotify_Load(object sender, EventArgs e)
        {
            myNotify.ShowBalloonTip(5000, "Hey guys!", "Welcome to Gibberish Studio's Notify System Tray!", ToolTipIcon.Info);
            TcpListenerThread = new Thread(new ThreadStart(TcpListening));
            TcpListenerThread.IsBackground = true;
            TcpListenerThread.Start();
        }

        private void DoHideWindow()
        {
            this.Visible = false;
            this.Hide();
        }

        private void exitEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void myNotify_Click(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                return;
            }
            this.Visible = true;
            this.Show();
        }

        private void FormNotify_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
