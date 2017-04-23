using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Collider))]
public class BodyPart : MonoBehaviour {


	public BodyPartType bodyPartType;
	public bool isEnabled = true;
	float Step;
	float Offset = 0.25f;

	void Start () {
		//Store where we were placed in the editor
		Vector3 InitialPosition = transform.position;
		Step = Random.value*10;
	}

	void FixedUpdate () {
		if (isEnabled) {
			Step += 0.01f;
			//Make sure Steps value never gets too out of hand 
			if (Step > 999999) {
				Step = 1f;
			}

			//Float up and down along the y axis, 
			transform.position = new Vector3 (transform.position.x, (Mathf.Sin (Step) * Offset) + .5f, transform.position.z);
		}
	}
}
