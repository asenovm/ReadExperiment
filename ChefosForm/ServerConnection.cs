using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace Read
{
    public class ServerConnection : INotificationsListener
    {

        private const string REGISTER_MESSAGE = "register";

        private const string UNREGISTER_MESSAGE = "unregister";

        private enum Status
        {
            REGISTER, ANSWER, UNREGISTER
        }

        private Encoding encoding;

        private INotificationsListener notificationsListener;

        private ClientConfiguration clientConfiguration;

        private JsonConverter converter;

        public class SimpleNotificationsListener : INotificationsListener
        {
            public void OnNotificationReceived(Notification notification)
            {
                //blank
            }
        }


        public ServerConnection()
            : this(new SimpleNotificationsListener(), new ClientConfiguration())
        {
            //blank
        }

        public ServerConnection(ClientConfiguration configuration)
            : this(new SimpleNotificationsListener(), configuration)
        {
            //blank
        }

        public ServerConnection(INotificationsListener notificationsListener, ClientConfiguration configuration)
        {
            encoding = Encoding.GetEncoding(1251);
            this.notificationsListener = notificationsListener;
            this.clientConfiguration = configuration;
            converter = new JsonConverter();
        }

        public void Register()
        {
            SendRequest(((int)Status.REGISTER).ToString(), REGISTER_MESSAGE);
        }

        public void SendAnswer(Answer answer)
        {
            SendRequest(((int)Status.ANSWER).ToString(), converter.ToJson(answer));
        }

        public void Unregister()
        {
            SendRequest(((int)Status.UNREGISTER).ToString(), UNREGISTER_MESSAGE);
        }


        public void Daemonize()
        {
            Thread daemonThread = new Thread(new NotificationsDaemon(this).Daemonize);
            daemonThread.Start();
        }


        private Notification GetNotification(string status, string message)
        {
            return new Notification(clientConfiguration.GetClientId(), status, message);
        }

        private void WriteToServer(TcpClient server, byte[] message)
        {
            NetworkStream writeStream = server.GetStream();
            writeStream.Write(message, 0, message.Length);
            writeStream.Flush();
            writeStream.Close();
        }


        private void SendRequest(string status, string message)
        {
            try
            {
                TcpClient server = new TcpClient(clientConfiguration.GetServerIdAppress(), clientConfiguration.GetServerPort());
                byte[] encodedString = encoding.GetBytes(converter.ToJson(GetNotification(status, message)));
                WriteToServer(server, encodedString);
                server.Close();
            }
            catch (Exception ex)
            {
                LogUtil.LogException(ex);
            }
        }

        public void OnNotificationReceived(Notification notification)
        {
            notificationsListener.OnNotificationReceived(notification);
        }
    }
}
