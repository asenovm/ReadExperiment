using System;
using System.Collections.Generic;
using System.Text;

namespace ChefosForm
{
    public class Notification
    {


        private const string KEY_STATUS_CODE = "status";

        private const string KEY_ID = "id";

        private const string KEY_SYSTEM_ID = "systemId";

        private const string KEY_MESSAGE = "message";

        private const string KEY_SUPPLIER = "vendor";

        private const string KEY_SATISFCATION = "satisfaction";

        private Dictionary<string, string> notification;

        private Dictionary<string, string> notificationMessage;

        public Notification(string id, string status, string message)
        {
            notification = new Dictionary<string, string>();
            notification.Add(KEY_ID, id);
            notification.Add(KEY_STATUS_CODE, status);
            notification.Add(KEY_MESSAGE, message);
        }

        public Notification(string jsonMessage)
        {
            JsonConverter converter = new JsonConverter();
            notification = converter.ParseJson(jsonMessage);
            notificationMessage = converter.ParseJson(notification[KEY_MESSAGE]); 
        }

        public string GetSenderId()
        {
            return notification[KEY_ID];
        }

        public string GetSenderServerId() {
            return notification[KEY_SYSTEM_ID];
        }

        public string GetSupplier()
        {
            return notificationMessage[KEY_SUPPLIER];
        }

        public string GetSatisfaction()
        {
            int satisfaction = int.Parse(notificationMessage[KEY_SATISFCATION]);
            switch (satisfaction) { 
                case -4:
                    return "изключително разочарован";
                case -3:
                    return "много разочарован";
                case -2:
                    return "разочарован";
                case -1:
                    return "по-скоро разочарован, отколкото удовлетворен";
                case 0:
                    return "колкото удовлетворен, толкова и разочарован";
                case 1:
                    return "по-скоро удовлетворен, отколкото разочарован";
                case 2:
                    return "удовлетворен";
                case 3:
                    return "много удовлетворен";
                case 4:
                    return "изключително удовлетворен";
                default:
                    return "грешка";
            }
        }

        public int Satisfaction {
            get {
                return int.Parse(notificationMessage[KEY_SATISFCATION]);
            }
        }

        public Dictionary<string, string> AsDictionary()
        {
            return new Dictionary<string, string>(notification);
        }
    }
}
