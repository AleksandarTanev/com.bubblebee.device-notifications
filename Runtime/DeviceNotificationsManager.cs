using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeviceNotifications
{
    public static class DeviceNotificationsManager
    {
        private static INotificationService _notificationService;

        public static void SendNotification(string msg)
        {
            if (_notificationService == null)
            {
                _notificationService = GetDefaultNotificationService();
            }

            _notificationService.Notify(msg);
        }

        public static void SetNotificationService(INotificationService newNotificationService)
        {
            _notificationService = newNotificationService;
        }

        private static INotificationService GetDefaultNotificationService()
        {

#if UNITY_ANDROID && !UNITY_EDITOR
            return new AndroidNotificationService();
#elif UNITY_IOS && !UNITY_EDITOR
            return new IOSNotificationService();
#else
            return new DummyNotificationService();
#endif
        }

        public static void Dispose()
        {
            _notificationService = null;
        }
    }
}
