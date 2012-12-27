using System;
using System.Collections.Generic;
using System.Text;

namespace ChefosForm
{
    public class Notification
    {


        private const string KEY_STATUS_CODE = "status";

        private const string KEY_ID = "id";

        private const string KEY_MESSAGE = "message";

        private Dictionary<string, string> notification;

        public Notification(string id, string status, string message) {
            notification = new Dictionary<string, string>();
            notification.Add(KEY_ID, id);
            notification.Add(KEY_STATUS_CODE, status);
            notification.Add(KEY_MESSAGE, message);
        }

        public Notification(string jsonMessage) {
            notification = new JsonConverter().ParseJson(jsonMessage);
        }

        public string GetSenderId() {
            return notification[KEY_ID];
        }

        public string GetMessage() {
            return notification[KEY_MESSAGE];
        }

        public Dictionary<string, string> AsDictionary(){
            return new Dictionary<string, string>(notification);
        }
    }
}
