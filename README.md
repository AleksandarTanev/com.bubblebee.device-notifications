## Table of contents
* [General info](#general-info)
* [Usage](#usage)
* [Samples](#samples)
* [Setup](#setup)

## General info
This package provides the ability to show a native notification on Android: Toast.
It can be easily extended for other devices and even for debbuging in the Unity Editor

## Usage
The main method you will need is *DeviceNotificationsManager.SendNotification(message)* and it can be called from everywhere.

There are a few helpful components that can be used directly or extended:
* *ClickNotificationWidgetUI* - used to enable a UI game object to be clickable and to send a notification on click. You can tell it how to get the text to send.
* *ClickNotificationWidgetGO* - used to enable 2D and 3D objects to be clickable and to send a notification on click. You can tell it how to get the text to send.

You change how the notifications are handled by the *DeviceNotificationsManager* by providing it with a class that implements *INotificationService*. (example can be seen in the samples)

## Samples
There are a few samples included in the package that provide examples and other helpful tools
* **DefaultBehaviour** - includes a scene with examples for using the *ClickNotificationWidgetGO* and *ClickNotificationWidgetUI*
* **TextClickNotificationWidget** - shows an example for extending the *ClickNotificationWidgetUI* -> *TextClickNotificationWidget*, which can be directly used with a Text component
* **MockNotificationInEditor** - gives an example of how you can set up your own notification logic, where as in this example is mock of the Toast in the Unity Editor for better testing and debugging
	
## Setup
To add this package to your project, use the Package Manager in Unity and "*Add package through git URL...*"

```
https://github.com/AleksandarTanev/com.bubblebee.device-notifications.git
```
