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
	private GameObject Button1 = null;
	private GameObject Button2 = null;
	private GameObject Button3 = null;
	private GameObject Button4 = null;

	public GameObject HatPosition = null;
	public GameObject HatText = null;

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
				if (bodyPart.bodyPartType == BodyPartType.Hat) {
					if (this.Hat == null) {
						this.Hat = obj;
						AssignGameObject (obj, HatPosition);
						HatText.SetActive (false);
					}
				
				}
			}
		}
	}

	void AssignGameObject(GameObject obj, GameObject parent) {
		//Vector3 scale = obj.transform.localScale;
		
		obj.transform.parent = parent.transform;
		obj.transform.rotation = new Quaternion ();
		obj.transform.localPosition = new Vector3 ();
		//obj.transform.localScale = scale;

		Rigidbody rigidbody = obj.GetComponent<Rigidbody> ();
		if (rigidbody != null) {
			rigidbody.isKinematic = true;
		}
	}
}
