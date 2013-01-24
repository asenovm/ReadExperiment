using System;
using System.Collections.Generic;
using System.Text;


using System.Web.Script.Serialization;
using Newtonsoft.Json;
namespace ChefosForm
{
    public class JsonConverter
    {

        public string ToJson(Notification notification)
        {
            return JsonConvert.SerializeObject(notification.AsDictionary());
        }

        public string ToJson(Answer answer) {
            return JsonConvert.SerializeObject(answer.AsDictionary());
        }

        public string ToJson(Object convertee)
        {
            return JsonConvert.SerializeObject(convertee);
        }

        public Dictionary<string, string> ParseJson(string json)
        {
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
    }
}
