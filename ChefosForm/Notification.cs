using System;
using System.Collections.Generic;
using System.Text;

namespace ChefosForm
{
    public class Notification
    {

        public Notification(string message, string id) {
            this.message = message;
            this.senderId = id;
        }

        private string message;

        public string Message
        {
            get {
                return message;
            }
        }

        private string senderId;

        public string SenderId
        {
            get {
                return senderId;
            }
        }


        
    }
}
