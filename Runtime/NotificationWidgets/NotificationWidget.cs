using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

namespace DeviceNotifications
{
    [RequireComponent(typeof(Collider))]
    public class NotificationWidget : NotificationWidgetBase
    {
        void OnMouseUp()
        {
            base.OnClick();
        }
    }
}