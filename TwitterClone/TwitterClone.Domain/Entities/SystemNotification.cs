using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class SystemNotification : Notification
    {
        public SystemNotification(Guid  systemNotificationByUserId) : base("System")
        {
            SystemNotificationByUserId = systemNotificationByUserId;
        }

        //System er ki userid ase??system notification er khetre amra ki use korbo?
        //like comment user kore tai user id korsi,but system er khetre ki korbo?/
        public Guid  SystemNotificationByUserId { get; set; }

        public override string GetMessage()
        {
            return $"System notification triggered by user with ID {SystemNotificationByUserId}.";
        }
    }
}
