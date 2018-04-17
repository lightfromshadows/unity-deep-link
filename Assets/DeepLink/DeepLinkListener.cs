using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Runtime.InteropServices;

namespace QuadraTron.DeepLink
{

    public class DeepLinkListener : MonoBehaviour
    {
        [DllImport("__Internal")]
        private static extern void DeepLinkReceiverIsAlive();

        [System.Serializable]
        public class StringEvent : UnityEvent<string> { }

        public StringEvent urlOpenedEvent;

        public bool dontDestroyOnLoad = true;

        // Use this for initialization
        void Start()
        {
            if (dontDestroyOnLoad)
                DontDestroyOnLoad(this.gameObject);
            DeepLinkReceiverIsAlive(); // Let the App Controller know it's ok to call URLOpened now.
        }

        public void URLOpened(string url)
        {
            urlOpenedEvent.Invoke(url);
        }
    }
}