using UnityEngine;

namespace DeviceNotifications
{
    public class DummyNotificationService : INotificationService
    {
        public void Notify(string msg)
        {
            Debug.Log(msg);

#if !UNITY_EDITOR
            Debug.LogWarning($"[DeviceNotifications] Using debug device notification service!");
#endif
        }
    }
}