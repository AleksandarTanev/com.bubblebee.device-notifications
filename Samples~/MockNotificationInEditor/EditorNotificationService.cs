using DeviceNotifications;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace DeviceNotifications.Samples
{
    public class EditorNotificationService : INotificationService
    {
        private UnityToast _unityToast;

        public void Notify(string msg)
        {
            if (_unityToast == null || _unityToast.IsDestroyed())
            {
                var guids = AssetDatabase.FindAssets("UnityToast");

                foreach (var g in guids)
                {
                    var assetPath = AssetDatabase.GUIDToAssetPath(g);
                    var prefab = (GameObject)AssetDatabase.LoadAssetAtPath(assetPath, typeof(GameObject));

                    if (prefab != null)
                    {
                        _unityToast = UnityEngine.Object.Instantiate(prefab).GetComponent<UnityToast>();
                        break;
                    }
                }

            }

            _unityToast.Show(msg);
        }
    }
}
