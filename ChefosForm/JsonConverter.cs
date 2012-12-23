using System;
using System.Collections.Generic;
using System.Text;


using System.Web.Script.Serialization;
using Newtonsoft.Json;
namespace ChefosForm
{
    public class JsonConverter
    {

        public static string KEY_STATUS_CODE = "status";

        public static string KEY_ID = "id";

        public static  string KEY_MESSAGE = "message";

        public string toJson(Object convertee){
            return JsonConvert.SerializeObject(convertee);
        }

        public Dictionary<string, string> parseJson(string json){
            Dictionary<string, string> result = new Dictionary<string,string>();
            string[] tokens = json.Split(new char[':']);
            for (var i = 0; i < tokens.Length; i += 2) {
                result.Add(tokens[i], tokens[i+1]);
            }
            return result;
        }
    }
}
