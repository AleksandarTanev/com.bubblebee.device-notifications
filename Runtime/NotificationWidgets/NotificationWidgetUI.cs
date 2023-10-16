using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DeviceNotifications
{
    [RequireComponent(typeof(RectTransform))]
    public class NotificationWidgetUI : NotificationWidgetBase, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            base.OnClick();
        }
    }
}