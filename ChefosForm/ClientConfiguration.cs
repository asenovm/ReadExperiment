using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ChefosForm
{
    public class ClientConfiguration
    {

        private const string DEFAULT_CLIENT_ID = "UnconfiguredId";

        private Dictionary<string, string> configuration;

        public ClientConfiguration() {
            configuration = new Dictionary<string, string>();
        }

        public ClientConfiguration(string configurationPath) : this(){
            try
            {
                System.IO.StreamReader streamReader = System.IO.File.OpenText(configurationPath);
                string configurationLine = streamReader.ReadLine();
                while (configurationLine != null)
                {
                    string[] splitLine = configurationLine.Split(new char[] { '=' });
                    configuration.Add(splitLine[0], splitLine[1]);
                    configurationLine = streamReader.ReadLine();
                }
                streamReader.Close();
            }
            catch (FileNotFoundException ex) {
                Console.WriteLine(ex.Message);
            }

        }

        public string GetClientId() {
            if (configuration.ContainsKey("id")) {
                return configuration["id"];
            }
            return DEFAULT_CLIENT_ID;
        }

    }
}
