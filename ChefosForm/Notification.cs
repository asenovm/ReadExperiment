using System;
using System.Collections.Generic;
using System.Text;

namespace ChefosForm
{
    public class Notification
    {

        public Notification(string jsonMessage) {
            message = new JsonConverter().parseJson(jsonMessage);
        }

        private Dictionary<string, string> message;

        public string GetSenderId() {
            return message[JsonConverter.KEY_ID];
        }

        public string GetMessage() {
            return message[JsonConverter.KEY_MESSAGE];
        }

    }
}
