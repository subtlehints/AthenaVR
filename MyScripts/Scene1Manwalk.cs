using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Manwalk : MonoBehaviour {

    public Transform target;
    public Transform MovingObj;
    public GameObject Question;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        walk();
	}

    public void walk()
    {
        float step = speed * Time.deltaTime;

        MovingObj.position = Vector3.MoveTowards(MovingObj.position, target.position, step);
        
    }

    void OnCollisionEnter(Collision col)
    {
        Question.SetActive(true);
        speed = 0;
        Debug.Log("Collision");
    }
}
