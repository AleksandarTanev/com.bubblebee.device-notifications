using DeviceNotifications;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace DeviceNotifications.Samples
{
    public class TextClickNotificationWidget : ClickNotificationWidgetUI
    {
        [SerializeField] private TextMeshProUGUI _label;

        private void OnEnable()
        {
            base.SetMessageProvider(GetText);
        }

        private string GetText()
        {
            if (_label == null)
            {
                return "N/A";
            }

            return _label.text;
        }

        private void OnDisable()
        {
            base.ClearMessageProvider();
        }
    }

}