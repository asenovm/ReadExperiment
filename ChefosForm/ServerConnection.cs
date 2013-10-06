using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace Read
{
    public class ServerConnection
    {

        private const string REGISTER_MESSAGE = "register";

        private const string UNREGISTER_MESSAGE = "unregister";

        private enum Status
        {
            REGISTER, ANSWER, UNREGISTER
        }

        private Encoding encoding;

        private ClientConfiguration clientConfiguration;

        private JsonConverter converter;

        public ServerConnection(ClientConfiguration configuration)
        {
            encoding = Encoding.GetEncoding(1251);
            this.clientConfiguration = configuration;
            converter = new JsonConverter();
        }

        public void Register()
        {
            Thread registerThread = new Thread(RegisterInternal);
            registerThread.Start();
        }

        public void SendAnswer(Answer answer)
        {
            Thread sendAnswerThread = new Thread(() => SendAnswerInternal(answer));
            sendAnswerThread.Start();
        }

        public void Unregister()
        {
            Thread unregisterThread = new Thread(UnregisterInternal);
            unregisterThread.Start();
        }

        private void RegisterInternal()
        {
            SendRequest(((int)Status.REGISTER).ToString(), REGISTER_MESSAGE);
        }

        private void SendAnswerInternal(Answer answer)
        {
            SendRequest(((int)Status.ANSWER).ToString(), converter.ToJson(answer));
        }

        private void UnregisterInternal()
        {
            SendRequest(((int)Status.UNREGISTER).ToString(), UNREGISTER_MESSAGE);
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

    }
}
