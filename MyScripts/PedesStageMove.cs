using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedesStageMove : MonoBehaviour {

    public Transform target;
    public Transform target2;
    public Transform target3;
    public Transform target4;
    public Transform target5;
    public Transform target6;
    public Transform vrCamera;
    public float toggleAngle = 10.0f;
    public float speed;
    private int stage = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {


        if (stage == 0)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            walk();
            checkPosition();
        }

        else if (stage == 1)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target2.position, step);

            walk();
            checkPosition();

        }

        else if (stage == 2)
        {
            onScript();
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target3.position, step);

            walk();
            checkPosition();
        }

        else if (stage == 3)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target4.position, step);

            walk();
            checkPosition();

        }

        else if (stage == 4)
        {
            onScript();

            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target5.position, step);
            
            walk();
            checkPosition();

        }

        else if (stage == 5)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target6.position, step);

            walk();
            checkPosition();
        }

    }

    void walk()
    {
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            speed = 0;
        }
        else
        {
            speed = 4;
        }

    }

    void checkPosition()
    {
        if (transform.position == target.position)
        {
            stage = 1;
        }
        else if (transform.position == target2.position)
        {
            offScript();
            Debug.Log("here");
            stage = 2;
        }
        else if (transform.position == target3.position)
        {


            stage = 3;
        }
        else if (transform.position == target4.position)
        {
            offScript();
            Debug.Log("here");
            stage = 4;
        }
        else if (transform.position == target5.position)
        {
            stage = 5;
        }
        else if (transform.position == target6.position)
        {
            stage = 6;
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
            Debug.Log   ("off");
            this.enabled = false;
        }
    }
}
