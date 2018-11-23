using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPedeMove : MonoBehaviour {

    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime;
    }
}
