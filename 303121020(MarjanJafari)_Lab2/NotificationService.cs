using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Q2_WinForm
{
    public class NotificationService
    {
        public delegate void NotificationDelegate(string message);

        public event NotificationDelegate NotifySubscribersEvent;

        public void NotifySubscribers(string message)
        {
            NotifySubscribersEvent?.Invoke(message);
        }
    }
}
