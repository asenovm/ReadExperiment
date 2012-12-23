using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace ChefosForm
{
    public class ServerConnection : INotificationsListener
    {

        private ASCIIEncoding encoding;

        private INotificationsListener notificationsListener;

        public class SimpleNotificationsListener : INotificationsListener {
            public void onNotificationReceived(Notification notification) { 
                //blank
            }
        }

        public ServerConnection() : this(new SimpleNotificationsListener()) {
            //blank
        }


        public ServerConnection(INotificationsListener notificationsListener) {            
            encoding= new ASCIIEncoding();
            this.notificationsListener = notificationsListener;
        }

        public void Register() {
            TcpClient client = new TcpClient("127.0.0.1", 65535);
            byte[] encodedString = encoding.GetBytes("0 Register!");
            NetworkStream writeStream = client.GetStream();
            writeStream.Write(encodedString, 0, encodedString.Length);
            writeStream.Flush();
            writeStream.Close();           
        }

       

        public void Daemonize() {
            Thread daemonThread = new Thread(new NotificationsDaemon(this).Daemonize);
            daemonThread.Start();
        }

        public void SendAnswer(Answer answer) {
            TcpClient client = new TcpClient("127.0.0.1", 65535);
            byte[] encodedString = encoding.GetBytes("1 " + answer.ToString());
            NetworkStream writeStream = client.GetStream();
            writeStream.Write(encodedString, 0, encodedString.Length);
            writeStream.Flush();
            writeStream.Close();
        }

        public void onNotificationReceived(Notification notification)
        {
            notificationsListener.onNotificationReceived(notification);
        }
    }
}
