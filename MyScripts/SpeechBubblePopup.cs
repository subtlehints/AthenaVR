using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechBubblePopup : MonoBehaviour {

    public GameObject speechBubble;
    public GameObject correctAns;
    public GameObject wrongAns;

    public GameObject correctText;
    public GameObject wrongText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        showSpeechBubble();
	}

    void showSpeechBubble()
    {
        if (correctAns.activeSelf == true)
        {
            speechBubble.SetActive(true);
            if (correctText.activeSelf == false)
            {
                correctText.SetActive(true);
            }   
            else if (wrongText.activeSelf == true)
            {
                wrongText.SetActive(false);
                correctText.SetActive(true);
            }
        }
        else if (wrongAns.activeSelf == true)
        {
            speechBubble.SetActive(true);
            if (wrongText.activeSelf == false)
            {
                wrongText.SetActive(true);
            }
            else if (correctText.activeSelf == true)
            {
                correctText.SetActive(false);
                wrongText.SetActive(true);
            }
        }
    }
}
