using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class SystemNotification : Notification
    {
        public SystemNotification(int systemNotificationByUserId) : base("System")
        {
            SystemNotificationByUserId = systemNotificationByUserId;
        }

        //System er ki userid ase??system notification er khetre amra ki use korbo?
        //like comment user kore tai user id korsi,but system er khetre ki korbo?/
        public int SystemNotificationByUserId { get; set; }
    }
}
