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
	public Toggle LeftEyeToggle = null;

	private GameObject RightEye = null;
	public GameObject RightEyePosition = null;
	public Toggle RightEyeToggle = null;

	// Nose
	private GameObject Nose = null;
	public GameObject NosePosition = null;
	public Toggle NoseToggle = null;

	// Mouth
	private GameObject Mouth = null;
	public GameObject MouthPosition = null;
	public Toggle MouthToggle = null;

	// Neck
	private GameObject Scarf = null;
	public GameObject ScarfPosition = null;
	public Toggle ScarfToggle = null;

	// Hands
	private GameObject LeftMitten = null;
	public GameObject LeftMittenPosition = null;
	public Toggle LeftMittenToggle = null;

	private GameObject RightMitten = null;
	public GameObject RightMittenPosition = null;
	public Toggle RightMittenToggle = null;

	public Toggle HatToggle = null;

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
        TryEquipGameObject(obj);
	}
	
    public void TryEquipGameObject(GameObject obj)
    {
        if (obj != null)
        {
            BodyPart[] bodyParts = obj.GetComponents<BodyPart>();
            foreach (BodyPart bodyPart in bodyParts)
            {
                BodyPartHover bph = obj.GetComponent<BodyPartHover>();
                if (bph != null && bph.isEnabled)
                {
                    if (bodyPart != null)
                    {
                        switch (bodyPart.bodyPartType)
                        {
                            case BodyPartType.Hat:
                                if (HatEquipmentPosition.Object == null)
                                {
                                    HatEquipmentPosition.Object = obj;
                                    EquipGameObject(bodyPart, HatEquipmentPosition.ObjectPosition);
                                    if (HatToggle != null)
                                    {
                                        HatToggle.isOn = true;
                                    }
                                }
                                break;
                            case BodyPartType.EyeNose:

                                if (this.LeftEye == null)
                                {
                                    this.LeftEye = obj;
                                    EquipGameObject(bodyPart, LeftEyePosition);
                                    if (LeftEyeToggle != null)
                                    {
                                        LeftEyeToggle.isOn = true;
                                    }
                                }
                                else if (this.LeftEye != obj && this.RightEye == null)
                                {
                                    this.RightEye = obj;
                                    EquipGameObject(bodyPart, RightEyePosition);
                                    if (RightEyeToggle != null)
                                    {
                                        RightEyeToggle.isOn = true;
                                    }
                                }
                                else if (this.LeftEye != obj && this.RightEye != obj && this.Nose == null)
                                {
                                    this.Nose = obj;
                                    EquipGameObject(bodyPart, NosePosition);
                                    if (NoseToggle != null)
                                    {
                                        NoseToggle.isOn = true;
                                    }
                                }
                                break;
                            case BodyPartType.Mouth:
                                if (this.Mouth == null)
                                {
                                    this.Mouth = obj;
                                    EquipGameObject(bodyPart, MouthPosition);
                                    if (MouthToggle != null)
                                    {
                                        MouthToggle.isOn = true;
                                    }
                                }
                                break;
                            case BodyPartType.Scarf:
                                if (this.Scarf == null)
                                {
                                    this.Scarf = obj;
                                    EquipGameObject(bodyPart, ScarfPosition);
                                    if (ScarfToggle != null)
                                    {
                                        ScarfToggle.isOn = true;
                                    }
                                }
                                break;
                            case BodyPartType.Mitten:
                                if (this.LeftMitten == null)
                                {
                                    this.LeftMitten = obj;
                                    EquipGameObject(bodyPart, LeftMittenPosition);
                                    if (LeftMittenToggle != null)
                                    {
                                        LeftMittenToggle.isOn = true;
                                    }
                                    // Rotate Mitten so Thumb is up.
                                    obj.transform.localRotation = new Quaternion(0f, 0.9f, 0f, 1f);
                                }
                                else if (this.LeftMitten != obj && this.RightMitten == null)
                                {
                                    this.RightMitten = obj;
                                    EquipGameObject(bodyPart, RightMittenPosition);
                                    if (RightMittenToggle != null)
                                    {
                                        RightMittenToggle.isOn = true;
                                    }
                                    // Rotate Mitten so Thumb is up.
                                    obj.transform.localRotation = new Quaternion(0f, -0.9f, 0f, 1f);
                                }
                                break;
                        }
                    }
                }
            }
        }

	// Positions the gameobject on the player
	void EquipGameObject(BodyPart obj, GameObject parent) {
		Quaternion rotation = obj.transform.localRotation;
		obj.transform.parent = parent.transform;

		obj.transform.localPosition = new Vector3 ();

		Vector3 newRotation = rotation.eulerAngles;
		newRotation.x += obj.Rotation.x;
		newRotation.y += obj.Rotation.y;
		newRotation.z += obj.Rotation.z;
		rotation.eulerAngles = newRotation;
		BodyPartHover bph = obj.GetComponent<BodyPartHover> ();
		if (bph != null) {
			bph.isEnabled = false;
		}

		Rigidbody rigidbody = obj.GetComponent<Rigidbody> ();
		if (rigidbody != null) {
			rigidbody.isKinematic = true;
		}
			obj.transform.localRotation = rotation;
	}
}
