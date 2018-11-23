using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkCycle : MonoBehaviour {

    public Transform target;
    public Transform target2;
    public Transform target3;
    public Transform vrCamera;
    public float toggleAngle = 10.0f;
    public float speed;
    private int stage = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {

        
        if (stage == 0)
        {
            onScript();
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            cycle();
            checkStage();
        }
        else if (stage == 1)
        {
            onScript();
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target2.position, step);
            cycle();
            checkStage();
        }
        else if (stage == 2)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target3.position, step);
            cycle();
            checkStage();
        }
        

    }

    void cycle()
    {
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            speed = 0;
        }
        else
        {
            speed = 1;
        }

    }

    void onScript()
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

    void checkStage()
    {
        if (transform.position == target.position)
        {
            offScript();
            stage = 1;
        }
        else if (transform.position == target2.position)
        {
            stage = 2;
        }
        else if (transform.position == target3.position)
        {
            stage = 3;
        }
    }

}
