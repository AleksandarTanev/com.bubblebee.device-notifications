using DeviceNotifications;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeviceNotifications.Samples
{
    public class MockNotificationInEditor : MonoBehaviour
    {
        private void Start()
        {
            var notificationService = new EditorNotificationService();
            DeviceNotificationsManager.SetNotificationService(notificationService);
        }
    }

}