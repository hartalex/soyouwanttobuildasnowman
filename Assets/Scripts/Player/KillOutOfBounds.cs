using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOutOfBounds : MonoBehaviour {

    public Vector3 min;
    public Vector3 max;

    // Update is called once per frame
    void FixedUpdate () {
		if (transform.position.x < min.x || 
            transform.position.x > max.x ||
            transform.position.y < min.y ||
            transform.position.y > max.y ||
            transform.position.z < min.z ||
            transform.position.z > max.z)
        {
            DestroyObject(gameObject);
        }
	}
}
