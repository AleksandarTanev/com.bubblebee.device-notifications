using NUnit.Framework;
using UnityEngine;

namespace DeviceNotifications.Tests
{
    public class ClickNotificationWidgetTests
    {
        [Test]
        public void Click_ClickNotificationWidgetUI_GameobjectNameAsNotification()
        {
            var mockedService = new MockNotificationService();

            DeviceNotificationsManager.Dispose();
            DeviceNotificationsManager.SetNotificationService(mockedService);

            string objectName = "WidgetUI";

            var newGameObject = new GameObject();
            newGameObject.name = objectName;
            var widget = newGameObject.AddComponent<ClickNotificationWidgetUI>();

            widget.OnPointerClick(null);

            // When debug mode is active, the widget returns sends the name of the object as notification text
            Assert.AreEqual(objectName, mockedService.receivedNotification);
        }

        [Test]
        public void Click_ClickNotificationWidgetGO_GameobjectNameAsNotification()
        {
            var mockedService = new MockNotificationService();

            DeviceNotificationsManager.Dispose();
            DeviceNotificationsManager.SetNotificationService(mockedService);

            string objectName = "WidgetGO";

            var newGameObject = new GameObject();
            newGameObject.name = objectName;

            newGameObject.AddComponent<BoxCollider>();
            var widget = newGameObject.AddComponent<ClickNotificationWidgetGO>();

            widget.OnMouseUp();

            // When debug mode is active, the widget returns sends the name of the object as notification text
            Assert.AreEqual(objectName, mockedService.receivedNotification);
        }

        public class MockNotificationService : INotificationService
        {
            public string receivedNotification;

            public void Notify(string msg)
            {
                receivedNotification = msg;
            }
        }
    }
}
