using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace ChefosForm
{
    class NotificationsDaemon
    {


        private static ManualResetEvent allDone = new ManualResetEvent(false);

        private INotificationsListener notificationsListener;

        public NotificationsDaemon(INotificationsListener listener) {
            this.notificationsListener = listener;
        }

        private class SocketListener
        {

            private INotificationsListener listener;

            public SocketListener(INotificationsListener notificationsListener) {
                this.listener = notificationsListener;
            }

            public void acceptCallback(IAsyncResult asyncResult)
            {
                allDone.Set();

                Socket listener = (Socket)asyncResult.AsyncState;
                Socket handler = listener.EndAccept(asyncResult);

                SocketState state = new SocketState();
                state.workSocket = handler;
                handler.BeginReceive(state.buffer, 0, SocketState.BufferSize, 0,
                    new AsyncCallback(readCallback), state);
            }

            public class SocketState
            {
                public Socket workSocket = null;
                public const int BufferSize = 1024;
                public byte[] buffer = new byte[BufferSize];
                public StringBuilder sb = new StringBuilder();
            }

            public void readCallback(IAsyncResult asyncResult)
            {
                SocketState state = (SocketState)asyncResult.AsyncState;
                Socket handler = state.workSocket;

                int read = handler.EndReceive(asyncResult);

                if (read > 0)
                {
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, read));
                    handler.BeginReceive(state.buffer, 0, SocketState.BufferSize, 0,
                        new AsyncCallback(readCallback), state);
                }
                else
                {
                    if (state.sb.Length > 1)
                    {
                        string content = state.sb.ToString();
                        listener.onNotificationReceived(new Notification(content, content.Split(new char[] { ' ' })[0]));
                    }
                    handler.Close();
                }
            }
        }

        public void Daemonize()
        {
            IPAddress serverAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint localEP = new IPEndPoint(serverAddress, 65534);

            Socket listener = new Socket(localEP.Address.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEP);
                listener.Listen(10);

                while (true)
                {
                    allDone.Reset();
                    listener.BeginAccept(
                        new AsyncCallback(new SocketListener(notificationsListener).acceptCallback),
                        listener);
                    allDone.WaitOne();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
