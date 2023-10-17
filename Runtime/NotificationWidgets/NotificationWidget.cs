using System;
using System.Collections;
using UnityEngine;

namespace DeviceNotifications
{
    public abstract class NotificationWidget : MonoBehaviour
    {
        [SerializeField] private bool _debugMode = true;

        protected Func<string> _messageProviderFunc;
        protected Func<Action<string>, IEnumerator> _asyncMessageProviderFunc;

        protected void OnClick()
        {
            if (_messageProviderFunc != null)
            {
                SendNotification(_messageProviderFunc.Invoke());
            }
            else if (_asyncMessageProviderFunc != null)
            {
                StartCoroutine(_asyncMessageProviderFunc(SendNotification));
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

        public void SetAsyncMessageProvider(Func<Action<string>, IEnumerator> asyncMessageProviderFunc)
        {
            _asyncMessageProviderFunc = asyncMessageProviderFunc;
        }

        public void ClearMessageProvider()
        {
            _messageProviderFunc = null;
        }
    }
}

