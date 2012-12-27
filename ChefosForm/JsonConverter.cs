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
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
    }
}
