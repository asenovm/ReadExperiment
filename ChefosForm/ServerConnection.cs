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

        private Encoding encoding;

        private INotificationsListener notificationsListener;

        private ClientConfiguration clientConfiguration;

        private JsonConverter converter;

        public class SimpleNotificationsListener : INotificationsListener {
            public void OnNotificationReceived(Notification notification) { 
                //blank
            }
        }


        public ServerConnection() : this(new SimpleNotificationsListener(), new ClientConfiguration()) {
            //blank
        }

        public ServerConnection(ClientConfiguration configuration) : this(new SimpleNotificationsListener(), configuration) { 
            //blank
        }

        public ServerConnection(INotificationsListener notificationsListener, ClientConfiguration configuration){
            encoding = Encoding.GetEncoding(1251);
            this.notificationsListener = notificationsListener;
            this.clientConfiguration = configuration;
            converter = new JsonConverter();
        }

        public void Register() {
            try
            {
                TcpClient server = new TcpClient(clientConfiguration.GetServerIdAppress(), clientConfiguration.GetServerPort());
                byte[] encodedString = encoding.GetBytes(converter.ToJson(GetNotification(((int)Status.REGISTER).ToString(), "register")));
                WriteToServer(server, encodedString);
            }
            catch (Exception ex)
            {
                LogUtil.LogException(ex);
            }
        }

        public void Daemonize() {
            Thread daemonThread = new Thread(new NotificationsDaemon(this).Daemonize);
            daemonThread.Start();
        }

        public void SendAnswer(Answer answer) {
            try
            {
                TcpClient server = new TcpClient(clientConfiguration.GetServerIdAppress(), clientConfiguration.GetServerPort());
                byte[] encodedString = encoding.GetBytes(converter.ToJson(GetNotification(((int)Status.ANSWER).ToString(), answer.ToString())));
                WriteToServer(server, encodedString);
            }
            catch (Exception ex) {
                LogUtil.LogException(ex);
            }
        }

        private Notification GetNotification(string status, string message) {
            return new Notification(clientConfiguration.GetClientId(), status, message);
        }

        private void WriteToServer(TcpClient server, byte[] message) {
            NetworkStream writeStream = server.GetStream();
            writeStream.Write(message, 0, message.Length);
            writeStream.Flush();
            writeStream.Close();
        }

        public void Unregister() {
            try
            {
                TcpClient server = new TcpClient(clientConfiguration.GetServerIdAppress(), clientConfiguration.GetServerPort());
                byte[] encodedString = encoding.GetBytes(converter.ToJson(GetNotification(((int)Status.UNREGISTER).ToString(), "Unregister")));
                WriteToServer(server, encodedString);
            }
            catch (Exception ex) {
                LogUtil.LogException(ex);
            }
        }

        public void OnNotificationReceived(Notification notification)
        {
            notificationsListener.OnNotificationReceived(notification);
        }
    }
}
