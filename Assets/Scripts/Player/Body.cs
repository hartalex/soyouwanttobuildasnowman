using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Body : MonoBehaviour {

	// Head
	private GameObject Hat = null;
	// private GameObject Face
	private GameObject LeftEye = null;
	private GameObject RightEye = null;
	private GameObject Nose = null;
	private GameObject Mouth = null;

	private GameObject Scarf = null;
	private GameObject LeftMitten = null;
	private GameObject RightMitten = null;

	public GameObject HatPosition = null;
	public GameObject HatText = null;

	public GameObject LeftEyePosition = null;
	public GameObject LeftEyeText = null;

	public GameObject RightEyePosition = null;
	public GameObject RightEyeText = null;

	public GameObject NosePosition = null;
	public GameObject NoseText = null;

	public GameObject MouthPosition = null;
	public GameObject MouthText = null;

	public GameObject ScarfPosition = null;
	public GameObject ScarfText = null;

	public GameObject LeftMittenPosition = null;
	public GameObject LeftMittenText = null;

	public GameObject RightMittenPosition = null;
	public GameObject RightMittenText = null;

	public GameObject YouWinText = null;
	public GameObject StartText = null;
	public GameObject MainCamera = null;

	private bool isStartScreen = true;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		// Start Scene is also the main scene, this gives snow some time to fall
		if (isStartScreen) {
			if (Input.GetButton ("Fire1")) {
				isStartScreen = false;
				// Turn off Spinning 
				Look cameraLook = MainCamera.GetComponent<Look> ();
				if (cameraLook != null) {
					cameraLook.enabled = true;
				}
				CameraOrbit cameraOrbit = MainCamera.GetComponent<CameraOrbit> ();
				if (cameraOrbit != null) {
					cameraOrbit.enabled = false;
				}
				Look look = this.GetComponent<Look> ();
				if (look != null) {
					look.enabled = true;
				}
				MainCamera.transform.localPosition = new Vector3 (0f, 1f, 0.75f);
				MainCamera.transform.rotation = new Quaternion();
				StartText.SetActive (false);
			}
		} else {

			if (isComplete ()) {
				// You WIN
				//MainCamera
				YouWinText.SetActive (true);

				Look cameraLook = MainCamera.GetComponent<Look> ();
				if (cameraLook != null) {
					cameraLook.enabled = false;
				}
				CameraOrbit cameraOrbit = MainCamera.GetComponent<CameraOrbit> ();
				if (cameraOrbit != null) {
					cameraOrbit.enabled = true;
				}
				Look look = this.GetComponent<Look> ();
				if (look != null) {
					look.enabled = false;
				}

			}
		}
	}

	public bool isComplete() {
		return (Hat != null &&
			LeftEye != null &&
			RightEye != null &&
			Nose != null &&
			Mouth != null &&
			Scarf != null &&
			LeftMitten != null &&
			RightMitten != null);
	}

	void OnCollisionEnter(Collision collision)
	{
		GameObject obj = collision.gameObject;
		if (obj != null) {
			BodyPart bodyPart = obj.GetComponent<BodyPart> ();
			if (bodyPart != null) {
				switch (bodyPart.bodyPartType) {
				case BodyPartType.Hat:
					if (this.Hat == null) {
						this.Hat = obj;
						AssignGameObject (obj, HatPosition);
						Text script = HatText.GetComponent<Text> ();
						if (script != null) {
							script.color = Color.gray;
						}
					}
					break;
				case BodyPartType.EyeNose:
					if (this.LeftEye == null) {
						this.LeftEye = obj;
						AssignGameObject (obj, LeftEyePosition);
						Text script = LeftEyeText.GetComponent<Text> ();
						if (script != null) {
							script.color = Color.gray;
						}
					} else if (this.LeftEye != obj && this.RightEye == null) {
						this.RightEye = obj;
						AssignGameObject (obj, RightEyePosition);
						Text script = RightEyeText.GetComponent<Text> ();
						if (script != null) {
							script.color = Color.gray;
						}
					} else if (this.LeftEye != obj && this.RightEye != obj && this.Nose == null) {
						this.Nose = obj;
						AssignGameObject (obj, NosePosition);
						Text script = NoseText.GetComponent<Text> ();
						if (script != null) {
							script.color = Color.gray;
						}
					}
					break;
				case BodyPartType.Mouth:
					if (this.Mouth == null) {
						this.Mouth = obj;
						AssignGameObject (obj, MouthPosition);
						Text script = MouthText.GetComponent<Text> ();
						if (script != null) {
							script.color = Color.gray;
						}
					}
					break;
				case BodyPartType.Scarf:
					if (this.Scarf == null) {
						this.Scarf = obj;
						AssignGameObject (obj, ScarfPosition);
						Text script = ScarfText.GetComponent<Text> ();
						if (script != null) {
							script.color = Color.gray;
						}
					}
					break;
				case BodyPartType.Mitten:
					if (this.LeftMitten == null) {
						this.LeftMitten = obj;
						AssignGameObject (obj, LeftMittenPosition);
						Text script = LeftMittenText.GetComponent<Text> ();
						if (script != null) {
							script.color = Color.gray;
						}
					} else if (this.LeftMitten != obj && this.RightMitten == null) {
						this.RightMitten = obj;
						AssignGameObject (obj, RightMittenPosition);
						Text script = RightMittenText.GetComponent<Text> ();
						if (script != null) {
							script.color = Color.gray;
						}

					}
					break;
				}
			}



		}
	}

	void AssignGameObject(GameObject obj, GameObject parent) {
		//Vector3 scale = obj.transform.localScale;
		
		obj.transform.parent = parent.transform;
		obj.transform.rotation = new Quaternion ();
		obj.transform.localPosition = new Vector3 ();

		BodyPart bodyPart = obj.GetComponent<BodyPart> ();
		if (bodyPart != null) {
			bodyPart.isEnabled = false;
		}
		//obj.transform.localScale = scale;

		Rigidbody rigidbody = obj.GetComponent<Rigidbody> ();
		if (rigidbody != null) {
			rigidbody.isKinematic = true;
		}
	}
}
