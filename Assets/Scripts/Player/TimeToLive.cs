using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToLive : MonoBehaviour {

    public float duration;
    private float startTime;

    // Use this for initialization
	void Start () {
        startTime = Time.time;
	}
	
	
	void FixedUpdate () {
		if (Time.time - startTime > duration)
        {
            DestroyObject(this.gameObject);
        }
	}
}
