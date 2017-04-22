using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour {

	// Head
	private GameObject Hat = null;
	// private GameObject Face
	private GameObject LeftEye = null;
	private GameObject RightEye = null;
	private GameObject Nose = null;
	private GameObject Mouth1 = null;
	private GameObject Mouth2 = null;
	private GameObject Mouth3 = null;
	private GameObject Mouth4 = null;
	private GameObject Mouth5 = null;

	private GameObject Scarf = null;
	public GameObject Torso = null;
	private GameObject Legs = null;
	private GameObject Button1 = null;
	private GameObject Button2 = null;
	private GameObject Button3 = null;
	private GameObject Button4 = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (isComplete()) {
			// You WIN
		}
	}

	public bool isComplete() {
		return (Hat != null &&
			LeftEye != null &&
			RightEye != null &&
			Nose != null &&
			Mouth1 != null &&
			Mouth2 != null &&
			Mouth3 != null &&
			Mouth4 != null &&
			Mouth5 != null &&
			Scarf != null &&
			Torso != null &&
			Legs != null &&
			Button1 != null &&
			Button2 != null &&
			Button3 != null &&
			Button4 != null);
	}

	void OnCollisionEnter(Collision collision)
	{
		GameObject obj = collision.gameObject;
		if (obj != null) {
			BodyPart bodyPart = obj.GetComponent<BodyPart> ();
			if (bodyPart != null) {
				if (bodyPart.bodyPartType == BodyPartType.Torso) {
					if (this.Torso == null) {
						this.Torso = obj;
						AssignGameObject (obj);
					}
				
				}
			}
		}
	}

	void AssignGameObject(GameObject obj) {
		obj.transform.parent = this.transform;
	}
}
