using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ChefosForm
{
    public class ClientConfiguration
    {

        private const string KEY_ID = "id";

        private const string KEY_SERVER_ADDRESS = "serverAddress";

        private const string KEY_SERVER_PORT = "serverPort";

        private const string DEFAULT_CLIENT_ID = "UnconfiguredId";

        private const string DEFAULT_SERVER_IP_ADDRESS = "77.70.11.102";

        private const int DEFAULT_SERVER_PORT = 65534;

        private Dictionary<string, string> configuration;

        public ClientConfiguration() {
            configuration = new Dictionary<string, string>();
        }

        public ClientConfiguration(string configurationPath) : this(){
            try
            {
                System.IO.StreamReader streamReader = new StreamReader(configurationPath, Encoding.GetEncoding(1251));
                string configurationLine = streamReader.ReadLine();
                while (configurationLine != null)
                {
                    Console.WriteLine("line is " + configurationLine);
                    string[] splitLine = configurationLine.Split(new char[] { '=' });
                    configuration.Add(splitLine[0], splitLine[1]);
                    configurationLine = streamReader.ReadLine();
                }
                streamReader.Close();

                foreach (var value in configuration.Values) {
                    Console.WriteLine("value is " + value);
                }
            }
            catch (FileNotFoundException ex) {
                Console.WriteLine(ex.Message);
            }

        }

        public string GetClientId() {
            if (configuration.ContainsKey(KEY_ID)) {
                return configuration[KEY_ID];
            }
            return DEFAULT_CLIENT_ID;
        }

        public string GetServerIdAppress() {
            if (configuration.ContainsKey(KEY_SERVER_ADDRESS)) {
                return configuration[KEY_SERVER_ADDRESS];
            }
            return DEFAULT_SERVER_IP_ADDRESS;
        }

        public int GetServerPort() {
            if (configuration.ContainsKey(KEY_SERVER_PORT)) {
                return Int32.Parse(configuration[KEY_SERVER_PORT]);
            }
            return DEFAULT_SERVER_PORT;
        }

    }
}
