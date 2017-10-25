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
         return /*(HatEquipmentPosition.Object != null &&
			LeftEye != null &&
			RightEye != null &&
			Nose != null &&
			Mouth != null &&
			Scarf != null &&
			LeftMitten != null &&
			RightMitten != null);*/
             false;
	}

	void Start()
    {
        if (EquipedItems.GetHat() != null)
        {
            GameObject obj = (GameObject)Resources.Load(EquipedItems.GetHat(), typeof(GameObject));
            GameObject ins = Instantiate(obj);
            TryEquipGameObject(ins);
        }
        if (EquipedItems.GetLeftEye() != null)
        {
            GameObject obj = (GameObject)Resources.Load(EquipedItems.GetLeftEye(), typeof(GameObject));
            GameObject ins = Instantiate(obj);
            TryEquipGameObject(ins);
        }
        if (EquipedItems.GetRightEye() != null)
        {
            GameObject obj = (GameObject)Resources.Load(EquipedItems.GetRightEye(), typeof(GameObject));
            GameObject ins = Instantiate(obj);
            TryEquipGameObject(ins);
        }
        if (EquipedItems.GetNose() != null)
        {
            GameObject obj = (GameObject)Resources.Load(EquipedItems.GetNose(), typeof(GameObject));
            GameObject ins = Instantiate(obj);
            TryEquipGameObject(ins);
        }
        if (EquipedItems.GetMouth() != null)
        {
            GameObject obj = (GameObject)Resources.Load(EquipedItems.GetMouth(), typeof(GameObject));
            GameObject ins = Instantiate(obj);
            TryEquipGameObject(ins);
        }
        if (EquipedItems.GetNeck() != null)
        {
            GameObject obj = (GameObject)Resources.Load(EquipedItems.GetNeck(), typeof(GameObject));
            GameObject ins = Instantiate(obj);
            TryEquipGameObject(ins);
        }
        if (EquipedItems.GetLeftHand() != null)
        {
            GameObject obj = (GameObject)Resources.Load(EquipedItems.GetLeftHand(), typeof(GameObject));
            GameObject ins = Instantiate(obj);
            TryEquipGameObject(ins);
        }
        if (EquipedItems.GetRightHand() != null)
        {
            GameObject obj = (GameObject)Resources.Load(EquipedItems.GetRightHand(), typeof(GameObject));
            GameObject ins = Instantiate(obj);
            TryEquipGameObject(ins);
        }
    }

    public bool TryEquipGameObject(GameObject obj)
    {
        bool retval = false;
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
                                    InventoryObject io = obj.GetComponent<InventoryObject>();
                                    if (io != null)
                                    {
                                        EquipedItems.EquipHat(io.ResourceName);
                                    }
                                    retval = true;
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
                                    InventoryObject io = obj.GetComponent<InventoryObject>();
                                    if (io != null)
                                    {
                                        EquipedItems.EquipLeftEye(io.ResourceName);
                                    }
                                    retval = true;
                                }
                                else if (this.LeftEye != obj && this.RightEye == null)
                                {
                                    this.RightEye = obj;
                                    EquipGameObject(bodyPart, RightEyePosition);
                                    if (RightEyeToggle != null)
                                    {
                                        RightEyeToggle.isOn = true;
                                    }
                                    InventoryObject io = obj.GetComponent<InventoryObject>();
                                    if (io != null)
                                    {
                                        EquipedItems.EquipRightEye(io.ResourceName);
                                    }
                                    retval = true;
                                }
                                else if (this.LeftEye != obj && this.RightEye != obj && this.Nose == null)
                                {
                                    this.Nose = obj;
                                    EquipGameObject(bodyPart, NosePosition);
                                    if (NoseToggle != null)
                                    {
                                        NoseToggle.isOn = true;
                                    }
                                    InventoryObject io = obj.GetComponent<InventoryObject>();
                                    if (io != null)
                                    {
                                        EquipedItems.EquipNose(io.ResourceName);
                                    }
                                    retval = true;
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
                                    InventoryObject io = obj.GetComponent<InventoryObject>();
                                    if (io != null)
                                    {
                                        EquipedItems.EquipMouth(io.ResourceName);
                                    }
                                    retval = true;
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
                                    InventoryObject io = obj.GetComponent<InventoryObject>();
                                    if (io != null)
                                    {
                                        EquipedItems.EquipNeck(io.ResourceName);
                                    }
                                    retval = true;
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
                                    InventoryObject io = obj.GetComponent<InventoryObject>();
                                    if (io != null)
                                    {
                                        EquipedItems.EquipLeftHand(io.ResourceName);
                                    }
                                    // Rotate Mitten so Thumb is up.
                                    obj.transform.localRotation = new Quaternion(0f, 0.9f, 0f, 1f);
                                    retval = true;
                                }
                                else if (this.LeftMitten != obj && this.RightMitten == null)
                                {
                                    this.RightMitten = obj;
                                    EquipGameObject(bodyPart, RightMittenPosition);
                                    if (RightMittenToggle != null)
                                    {
                                        RightMittenToggle.isOn = true;
                                    }
                                    InventoryObject io = obj.GetComponent<InventoryObject>();
                                    if (io != null)
                                    {
                                        EquipedItems.EquipRightHand(io.ResourceName);
                                    }
                                    // Rotate Mitten so Thumb is up.
                                    obj.transform.localRotation = new Quaternion(0f, -0.9f, 0f, 1f);
                                    retval = true;
                                }
                                break;
                        }
                    }
                }
            }
        }
        return retval;
    }

	// Positions the gameobject on the player
	void EquipGameObject(BodyPart obj, GameObject parent) {
		Quaternion rotation = obj.transform.localRotation;
        Vector3 scale = obj.transform.localScale;
		obj.transform.parent = parent.transform;
        obj.transform.localScale = scale;
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
