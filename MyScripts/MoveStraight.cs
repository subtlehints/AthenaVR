using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraight : MonoBehaviour {

    public Transform target;
    public Transform target2;
    public Transform target3;
    public Transform vrCamera;
    public float toggleAngle;
    public float speed;
    private int stage = 0;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        float step = speed * Time.deltaTime;
        
        
        if (stage == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            cycle();

            if (transform.position == target.position)
            {
                stage += 1;
            }
        }

        if (stage == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, target2.position, step);

            cycle();

            if (transform.position == target2.position)
            {
                stage += 1;
            }

        }

        if (stage == 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, target3.position, step);

            cycle();

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
            speed = 2 ;
        }
        
    }
}
