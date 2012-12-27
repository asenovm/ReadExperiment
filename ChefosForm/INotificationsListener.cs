using System;
using System.Collections.Generic;
using System.Text;

namespace ChefosForm
{
    public interface INotificationsListener
    {
        void OnNotificationReceived(Notification notification);
    }
}
