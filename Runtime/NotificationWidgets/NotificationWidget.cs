using System;
using System.Collections;
using UnityEngine;

namespace DeviceNotifications
{
    public abstract class NotificationWidget : MonoBehaviour
    {
        [SerializeField] private bool _debugMode = true;

        protected Func<string> _messageProvider;
        protected Action<Action<string>> _delayedMessageProvider;

        protected void OnClick()
        {
            if (_messageProvider != null)
            {
                SendNotification(_messageProvider.Invoke());
            }
            else if (_delayedMessageProvider != null)
            {
                _delayedMessageProvider.Invoke(SendNotification);
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
            _messageProvider = messageProvider;
        }

        public void SetDelayedMessageProvider(Action<Action<string>> delayedMessageProvider)
        {
            _delayedMessageProvider = delayedMessageProvider;
        }

        public void ClearMessageProvider()
        {
            _messageProvider = null;
        }
    }
}