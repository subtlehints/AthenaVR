using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STMCamera : MonoBehaviour {

    public Transform checkpoint1;
    public float speed;
    public Scene1Manwalk bicycleScript;
    public Scene1Manwalk manScript;
    private int stage = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {
		if (stage == 1)
        {
            moveCheckpoint1();
        }
	}

    public void moveCheckpoint1()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, checkpoint1.position, step);
        if (transform.position == checkpoint1.position)
        {
            stage = 2;
            bicycleScript.enabled = true;
            manScript.enabled = true;
        }
        
    }

    public void onScript()
    {
        if (this.enabled == false)
        {
            this.enabled = true;
        }
    }

    void offScript()
    {
        if (this.enabled == true)
        {
            this.enabled = false;
        }
    }
}
