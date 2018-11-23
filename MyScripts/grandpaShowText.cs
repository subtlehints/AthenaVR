using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grandpaShowText : MonoBehaviour {

    public GameObject textInfo;
    private bool Show = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void showText()
    {
        if (Show == false)
        {
            textInfo.SetActive(true);
            Show = true;
        }
        else
        {
            textInfo.SetActive(false);
            Show = false;
        }
    }
}
