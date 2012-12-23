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

        private enum Status { 
            REGISTER, ANSWER, UNREGISTER
        }

        private ASCIIEncoding encoding;

        private INotificationsListener notificationsListener;

        private ClientConfiguration clientConfiguration;

        private JsonConverter converter;

        public class SimpleNotificationsListener : INotificationsListener {
            public void onNotificationReceived(Notification notification) { 
                //blank
            }
        }


        public ServerConnection() : this(new SimpleNotificationsListener(), new ClientConfiguration()) {
            //blank
        }

        public ServerConnection(INotificationsListener notificationsListener, ClientConfiguration configuration){
            encoding = new ASCIIEncoding();
            this.notificationsListener = notificationsListener;
            this.clientConfiguration = configuration;
            converter = new JsonConverter();
        }

        public void Register() {
            TcpClient client = new TcpClient("127.0.0.1", 65535);
            Dictionary<string, string> registerData = new Dictionary<string, string>();
            registerData.Add(JsonConverter.KEY_STATUS_CODE, ((int)Status.REGISTER).ToString());
            registerData.Add(JsonConverter.KEY_ID, clientConfiguration.GetClientId());
            registerData.Add(JsonConverter.KEY_MESSAGE, "Register!");
            
            byte[] encodedString = encoding.GetBytes(converter.toJson(registerData));
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
            byte[] encodedString = encoding.GetBytes("1 " + clientConfiguration.GetClientId() + " " + answer.ToString());
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
