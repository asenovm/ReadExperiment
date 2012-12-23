using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace ChefosForm
{
    public class ServerConnection
    {

        private ASCIIEncoding encoding;

        public ServerConnection() {            
            encoding= new ASCIIEncoding();   
        }

        public void Register() {
            TcpClient client = new TcpClient("127.0.0.1", 65535);
            byte[] encodedString = encoding.GetBytes("0 Register!");
            NetworkStream writeStream = client.GetStream();
            writeStream.Write(encodedString, 0, encodedString.Length);
            writeStream.Flush();
            writeStream.Close();           
        }

        private class SocketListener {
            public static void acceptCallback(IAsyncResult asyncResult) {
                allDone.Set();
                // Get the socket that handles the client request.
                Socket listener = (Socket)asyncResult.AsyncState;
                Socket handler = listener.EndAccept(asyncResult);

                // Create the state object.
                StateObject state = new StateObject();
                state.workSocket = handler;
                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(SocketListener.readCallback), state);
            }

            public class StateObject
            {
                public Socket workSocket = null;
                public const int BufferSize = 1024;
                public byte[] buffer = new byte[BufferSize];
                public StringBuilder sb = new StringBuilder();
            }

            public static void readCallback(IAsyncResult asyncResult) {
                StateObject state = (StateObject) asyncResult.AsyncState;
                Socket handler = state.workSocket;

                // Read data from the client socket.
                int read = handler.EndReceive(asyncResult);

                // Data was read from the client socket.
                if (read > 0)
                {
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, read));
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                        new AsyncCallback(readCallback), state);
                }
                else
                {
                    if (state.sb.Length > 1)
                    {
                        // All the data has been read from the client;
                        // display it on the console.
                        string content = state.sb.ToString();
                        Console.WriteLine("Read {0} bytes from socket.\n Data : {1}",
                           content.Length, content);
                    }
                    handler.Close();
                }
            }
        }

        public static ManualResetEvent allDone = new ManualResetEvent(false);

        public void Daemonize() {
            Thread daemonThread = new Thread(DaemonizeHelper);
            daemonThread.Start();
        }

        public void DaemonizeHelper() {
            IPAddress serverAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint localEP = new IPEndPoint(serverAddress, 65534);

            Socket listener = new Socket(localEP.Address.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            Console.WriteLine("socket created!");

            try
            {
                listener.Bind(localEP);
                listener.Listen(10);

                Console.WriteLine("socket is bound");

                while (true)
                {
                    allDone.Reset();
                    listener.BeginAccept(
                        new AsyncCallback(SocketListener.acceptCallback),
                        listener);
                    allDone.WaitOne();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("Closing the listener...");
        }

        public void SendAnswer(Answer answer) {
            TcpClient client = new TcpClient("127.0.0.1", 65535);
            byte[] encodedString = encoding.GetBytes("1 " + answer.ToString());
            NetworkStream writeStream = client.GetStream();
            writeStream.Write(encodedString, 0, encodedString.Length);
            writeStream.Flush();
            writeStream.Close();
        }
    }
}
