using System;
using System.Collections.Generic;
using System.Text;

namespace Read
{
    public interface INotificationsListener
    {
        void OnNotificationReceived(Notification notification);
    }
}
