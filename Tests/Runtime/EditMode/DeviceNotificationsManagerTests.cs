using DeviceNotifications;
using NUnit.Framework;

namespace DeviceNotifications.Tests
{
    public class DeviceNotificationsManagerTests
    {
        [Test]
        public void Set_NotificationService_EqualToGiven()
        {
            var mockedService = new MockNotificationService();

            string message = "Test message";

            DeviceNotificationsManager.Dispose();
            DeviceNotificationsManager.SetNotificationService(mockedService);
            DeviceNotificationsManager.SendNotification(message);

            Assert.AreEqual(message, mockedService.receivedNotification);
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