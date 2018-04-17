using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QuadraTron.DeepLink;

public class ExampleText : MonoBehaviour {

    Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        text.text = DeepLink.LastURL;
	}

    public void OnApplicationFocus(bool focus)
    {
        text.text = DeepLink.LastURL;
    }
}
