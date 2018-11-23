using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseAmount : MonoBehaviour {

    public GameObject selection;
    public GameObject selection2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    
    public void check()
    {
        if (selection.activeSelf == false)
        {
            selection.SetActive(true);
            selection2.SetActive(false);
        }
    }

}
