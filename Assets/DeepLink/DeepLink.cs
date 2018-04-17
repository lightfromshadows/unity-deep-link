using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

namespace QuadraTron.DeepLink
{

    public static class DeepLink
    {

        [DllImport("__Internal")]
        private static extern string GetDeepLinkURL();

        public static string LastURL
        {
            get
            {
                return GetDeepLinkURL();
            }
        }
    }
}
