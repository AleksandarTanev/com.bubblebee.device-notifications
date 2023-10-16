using UnityEngine;

namespace DeviceNotifications
{
    public class DummyNotificationService : INotificationService
    {
        public void NotifyUser(string msg)
        {
            Debug.Log(msg);

#if !UNITY_EDITOR
            Debug.LogWarning($"[DeviceNotifications] Using debug device notification service!");
#endif
        }
    }
}