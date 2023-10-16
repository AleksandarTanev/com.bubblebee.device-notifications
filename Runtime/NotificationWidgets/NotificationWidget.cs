using System;
using UnityEngine;

namespace DeviceNotifications
{
    public abstract class NotificationWidget : MonoBehaviour
    {
        [SerializeField] private bool _debugMode = true;

        protected Func<string> _messageProviderFunc;

        protected void OnClick()
        {
            if (_messageProviderFunc != null)
            {
                SendNotification(_messageProviderFunc.Invoke());
            }
            else if (_debugMode)
            {
                SendNotification(this.gameObject.name);
            }
        }

        protected void SendNotification(string msg)
        {
            DeviceNotificationsManager.SendNotification(msg);
        }

        public void SetMessageProvider(Func<string> messageProvider)
        {
            _messageProviderFunc = messageProvider;
        }

        public void ClearMessageProvider()
        {
            _messageProviderFunc = null;
        }
    }
}

