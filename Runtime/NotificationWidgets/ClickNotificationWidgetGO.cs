using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

namespace DeviceNotifications
{
    [RequireComponent(typeof(Collider))]
    public class ClickNotificationWidgetGO : NotificationWidget
    {
        public void OnMouseUp()
        {
            base.OnClick();
        }
    }
}