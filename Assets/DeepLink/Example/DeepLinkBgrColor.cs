using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeepLinkBgrColor : MonoBehaviour {

    new Camera camera {
        get {
            return Camera.main;
        }
    }

    public void ColorURLOpened(string url)
    {
        string color = url.Substring(url.IndexOf("color=", System.StringComparison.CurrentCultureIgnoreCase)).Split('=','?')[1];
        Debug.LogFormat("[{0}] from '{1}'", color, url);
        SetBgrColor(color);
    }

    public void SetBgrColor(string color)
    {
        switch (color)
        {
            case "red":
                camera.backgroundColor = Color.red;
                break;
            case "green":
                camera.backgroundColor = Color.green;
                break;
            case "blue":
                camera.backgroundColor = Color.blue;
                break;
            case "magenta":
            case "pink":
                camera.backgroundColor = Color.magenta;
                break;
            case "yellow":
                camera.backgroundColor = Color.yellow;
                break;
            case "grey":
            case "gray":
                camera.backgroundColor = Color.grey;
                break;
            case "white":
                camera.backgroundColor = Color.white;
                break;
            case "black":
                camera.backgroundColor = Color.black;
                break;
            default:
                camera.backgroundColor = new Color32(100, 149, 237, 255);
                break;
        }
    }
}
