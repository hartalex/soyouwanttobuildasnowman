using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Body : MonoBehaviour {

	// Head
	public EquipmentPosition HatEquipmentPosition = null;
	public EquipmentPosition LeftEyeEquipmentPosition = null;
	public EquipmentPosition RightEyeEquipmentPosition = null;
	public EquipmentPosition NoseEquipmentPosition = null;
	public EquipmentPosition MouthEquipmentPosition = null;
	public EquipmentPosition ScarfEquipmentPosition = null;
	public EquipmentPosition LeftMittenEquipmentPosition = null;
	public EquipmentPosition RightMittenEquipmentPosition = null;

	// private GameObject Face
	private GameObject LeftEye = null;
	public GameObject LeftEyePosition = null;
	public GameObject LeftEyeText = null;

	private GameObject RightEye = null;
	public GameObject RightEyePosition = null;
	public GameObject RightEyeText = null;

	// Nose
	private GameObject Nose = null;
	public GameObject NosePosition = null;
	public GameObject NoseText = null;

	// Mouth
	private GameObject Mouth = null;
	public GameObject MouthPosition = null;
	public GameObject MouthText = null;

	// Neck
	private GameObject Scarf = null;
	public GameObject ScarfPosition = null;
	public GameObject ScarfText = null;

	// Hands
	private GameObject LeftMitten = null;
	public GameObject LeftMittenPosition = null;
	public GameObject LeftMittenText = null;

	private GameObject RightMitten = null;
	public GameObject RightMittenPosition = null;
	public GameObject RightMittenText = null;

	 public bool isComplete() {
		return (HatEquipmentPosition.Object != null &&
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
					if (HatEquipmentPosition.Object == null) {
						HatEquipmentPosition.Object = obj;
						EquipGameObject (obj, HatEquipmentPosition.ObjectPosition);
						Text script = HatEquipmentPosition.UIText.GetComponent<Text> ();
						if (script != null) {
							script.color = Color.gray;
						}
					}
					break;
				case BodyPartType.EyeNose:


					if (this.LeftEye == null) {
						this.LeftEye = obj;
						EquipGameObject (obj, LeftEyePosition);
						Text script = LeftEyeText.GetComponent<Text> ();
						if (script != null) {
							script.color = Color.gray;
						}
					} else if (this.LeftEye != obj && this.RightEye == null) {
						this.RightEye = obj;
						EquipGameObject (obj, RightEyePosition);
						Text script = RightEyeText.GetComponent<Text> ();
						if (script != null) {
							script.color = Color.gray;
						}
					} else if (this.LeftEye != obj && this.RightEye != obj && this.Nose == null) {
						this.Nose = obj;
						EquipGameObject (obj, NosePosition);
						Text script = NoseText.GetComponent<Text> ();
						if (script != null) {
							script.color = Color.gray;
						}
					}
					break;
				case BodyPartType.Mouth:
					if (this.Mouth == null) {
						this.Mouth = obj;
						EquipGameObject (obj, MouthPosition);
						Text script = MouthText.GetComponent<Text> ();
						if (script != null) {
							script.color = Color.gray;
						}
					}
					break;
				case BodyPartType.Scarf:
					if (this.Scarf == null) {
						this.Scarf = obj;
						EquipGameObject (obj, ScarfPosition);
						Text script = ScarfText.GetComponent<Text> ();
						if (script != null) {
							script.color = Color.gray;
						}
					}
					break;
				case BodyPartType.Mitten:
					if (this.LeftMitten == null) {
						this.LeftMitten = obj;
						EquipGameObject (obj, LeftMittenPosition);
						Text script = LeftMittenText.GetComponent<Text> ();
						if (script != null) {
							script.color = Color.gray;
						}
						// Rotate Mitten so Thumb is up.
						obj.transform.localRotation = new Quaternion(0f,0.9f,0f,1f);
					} else if (this.LeftMitten != obj && this.RightMitten == null) {
						this.RightMitten = obj;
						EquipGameObject (obj, RightMittenPosition);
						Text script = RightMittenText.GetComponent<Text> ();
						if (script != null) {
							script.color = Color.gray;
						}
						// Rotate Mitten so Thumb is up.
						obj.transform.localRotation = new Quaternion(0f,-0.9f,0f,1f);
					}
					break;
				}
			}



		}
	}

	// Positions the gameobject on the player
	void EquipGameObject(GameObject obj, GameObject parent) {
		Quaternion rotation = obj.transform.localRotation;
		obj.transform.parent = parent.transform;
		obj.transform.localRotation = rotation;
		obj.transform.localPosition = new Vector3 ();

		BodyPart bodyPart = obj.GetComponent<BodyPart> ();
		if (bodyPart != null) {
			bodyPart.isEnabled = false;
		}

		Rigidbody rigidbody = obj.GetComponent<Rigidbody> ();
		if (rigidbody != null) {
			rigidbody.isKinematic = true;
		}
	}
}
