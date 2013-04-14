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

        private const string KEY_ID = "id";

        private const string KEY_SERVER_ADDRESS = "serverAddress";

        private const string KEY_SERVER_PORT = "serverPort";

        private const string DEFAULT_CLIENT_ID = "UnconfiguredId";

        private const int DEFAULT_SERVER_PORT = 65535;

        private Dictionary<string, string> configuration;

        public ClientConfiguration()
        {
            configuration = new Dictionary<string, string>();
        }

        public ClientConfiguration(string configurationPath)
            : this()
        {
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

        public string GetClientId()
        {
            if (configuration.ContainsKey(KEY_ID))
            {
                return configuration[KEY_ID];
            }
            return DEFAULT_CLIENT_ID;
        }

        public string GetServerIdAppress()
        {
            if (configuration.ContainsKey(KEY_SERVER_ADDRESS))
            {
                return configuration[KEY_SERVER_ADDRESS];
            }
            return GetDefaultServerIpAddress();
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
