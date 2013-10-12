using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Read
{
    public class ClientConfiguration
    {

        private static string KEY_ID = "id";

        private static string KEY_SERVER_ADDRESS = "serverAddress";

        private static string KEY_SERVER_PORT = "serverPort";

        private static string KEY_NOTIFICATION_PAUSE = "pause";

        private static string KEY_NOTIFICATION_FLASH = "flash";

        private static string DEFAULT_CLIENT_ID = "UnconfiguredId";

        private static int DEFAULT_SERVER_PORT = 65535;

        private static int DEFAULT_NOTIFICATION_PAUSE = 800;

        private static int DEFAULT_NOTIFICATION_FLASH = 200;

        private Dictionary<string, string> configuration;

        /**
         * Creats a new client configuration by using
         * the values specified in the configuration file that can be found
         * at the <tt>configurationPath</tt> given
         */
        public ClientConfiguration(string configurationPath)
        {
            configuration = new Dictionary<string, string>();
            try
            {
                System.IO.StreamReader streamReader = new StreamReader(configurationPath, Encoding.GetEncoding(1251));
                string configurationLine = streamReader.ReadLine();
                while (configurationLine != null)
                {
                    string[] splitLine = configurationLine.Split(new char[] { '=' });
                    configuration.Add(splitLine[0], splitLine[1]);
                    configurationLine = streamReader.ReadLine();
                }
                streamReader.Close();
            }
            catch (FileNotFoundException ex)
            {
                LogUtil.LogException(ex);
            }

        }

        /**
         *  Returns the Id of the client
         */
        public string GetClientId()
        {
            if (configuration.ContainsKey(KEY_ID))
            {
                return configuration[KEY_ID];
            }
            return DEFAULT_CLIENT_ID;
        }

        /**
         *  Returns the IP address of the server to which the client is to connect
         */
        public string GetServerIdAppress()
        {
            if (configuration.ContainsKey(KEY_SERVER_ADDRESS))
            {
                return configuration[KEY_SERVER_ADDRESS];
            }
            return GetDefaultServerIpAddress();
        }

        public int GetNotificationPauseTime() {
            if (configuration.ContainsKey(KEY_NOTIFICATION_PAUSE)) {
                return int.Parse(configuration[KEY_NOTIFICATION_PAUSE]);
            }
            return DEFAULT_NOTIFICATION_PAUSE;
        }

        public int GetNotificationFlashTime() {
            if (configuration.ContainsKey(KEY_NOTIFICATION_FLASH)) {
                return int.Parse(configuration[KEY_NOTIFICATION_FLASH]);
            }
            return DEFAULT_NOTIFICATION_FLASH;
        }

        private string GetDefaultServerIpAddress()
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var address in ipHostInfo.AddressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    return address.ToString();
                }
            }
            return null;
        }

        /**
         * Gets the port at which the server, the client will be trying
         * to connect to is listening for requests.
         */
        public int GetServerPort()
        {
            if (configuration.ContainsKey(KEY_SERVER_PORT))
            {
                return Int32.Parse(configuration[KEY_SERVER_PORT]);
            }
            return DEFAULT_SERVER_PORT;
        }

    }
}
