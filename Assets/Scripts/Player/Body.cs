﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Body : MonoBehaviour {

    public bool isInventory = false;
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

	public GameObject LeftEyePosition = null;
	public Toggle LeftEyeToggle = null;


	public GameObject RightEyePosition = null;
	public Toggle RightEyeToggle = null;

	// Nose

	public GameObject NosePosition = null;
	public Toggle NoseToggle = null;

	// Mouth
	
	public GameObject MouthPosition = null;
	public Toggle MouthToggle = null;

	// Neck

	public GameObject ScarfPosition = null;
	public Toggle ScarfToggle = null;

	// Hands

	public GameObject LeftMittenPosition = null;
	public Toggle LeftMittenToggle = null;


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
            ins.layer = 2;
            DragNDrop dnd = ins.AddComponent<DragNDrop>();
            dnd.isEquipped = true;
            BodyPart[] bodyParts = ins.GetComponents<BodyPart>();
            foreach (BodyPart bodyPart in bodyParts)
            {
                if (bodyPart != null && bodyPart.bodyPartType == BodyPartType.Hat)
                {
                    EquipGameObject(bodyPart, HatEquipmentPosition.ObjectPosition);
                }
            }
        }
        if (EquipedItems.GetLeftEye() != null)
        {
            GameObject obj = (GameObject)Resources.Load(EquipedItems.GetLeftEye(), typeof(GameObject));
            GameObject ins = Instantiate(obj);
            ins.layer = 2;
            DragNDrop dnd = ins.AddComponent<DragNDrop>();
            dnd.isEquipped = true;
            BodyPart[] bodyParts = ins.GetComponents<BodyPart>();
            foreach (BodyPart bodyPart in bodyParts)
            {
                if (bodyPart != null && bodyPart.bodyPartType == BodyPartType.EyeNose)
                {
                    EquipGameObject(bodyPart, LeftEyePosition);
                }
            }
        }
        if (EquipedItems.GetRightEye() != null)
        {
            GameObject obj = (GameObject)Resources.Load(EquipedItems.GetRightEye(), typeof(GameObject));
            GameObject ins = Instantiate(obj);
            ins.layer = 2;
            DragNDrop dnd = ins.AddComponent<DragNDrop>();
            dnd.isEquipped = true;
            BodyPart[] bodyParts = ins.GetComponents<BodyPart>();
            foreach (BodyPart bodyPart in bodyParts)
            {
                if (bodyPart != null && bodyPart.bodyPartType == BodyPartType.EyeNose)
                {
                    EquipGameObject(bodyPart, RightEyePosition);
                }
            }
        }
        if (EquipedItems.GetNose() != null)
        {
            GameObject obj = (GameObject)Resources.Load(EquipedItems.GetNose(), typeof(GameObject));
            GameObject ins = Instantiate(obj);
            ins.layer = 2;
            DragNDrop dnd = ins.AddComponent<DragNDrop>();
            dnd.isEquipped = true;
            BodyPart[] bodyParts = ins.GetComponents<BodyPart>();
            foreach (BodyPart bodyPart in bodyParts)
            {
                if (bodyPart != null && bodyPart.bodyPartType == BodyPartType.EyeNose)
                {
                    EquipGameObject(bodyPart, NosePosition);
                }
            }
        }
        if (EquipedItems.GetMouth() != null)
        {
            GameObject obj = (GameObject)Resources.Load(EquipedItems.GetMouth(), typeof(GameObject));
            GameObject ins = Instantiate(obj);
            ins.layer = 2;
            DragNDrop dnd = ins.AddComponent<DragNDrop>();
            dnd.isEquipped = true;
            BodyPart[] bodyParts = ins.GetComponents<BodyPart>();
            foreach (BodyPart bodyPart in bodyParts)
            {
                if (bodyPart != null && bodyPart.bodyPartType == BodyPartType.Mouth)
                {
                    EquipGameObject(bodyPart, MouthPosition);
                }
            }
        }
        if (EquipedItems.GetNeck() != null)
        {
            GameObject obj = (GameObject)Resources.Load(EquipedItems.GetNeck(), typeof(GameObject));
            GameObject ins = Instantiate(obj);
            ins.layer = 2;
            DragNDrop dnd = ins.AddComponent<DragNDrop>();
            dnd.isEquipped = true;
            BodyPart[] bodyParts = ins.GetComponents<BodyPart>();
            foreach (BodyPart bodyPart in bodyParts)
            {
                if (bodyPart != null && bodyPart.bodyPartType == BodyPartType.Scarf)
                {
                    EquipGameObject(bodyPart, ScarfPosition);
                }
            }
        }
        if (EquipedItems.GetLeftHand() != null)
        {
            GameObject obj = (GameObject)Resources.Load(EquipedItems.GetLeftHand(), typeof(GameObject));
            GameObject ins = Instantiate(obj);
            ins.layer = 2;
            obj.transform.localRotation = new Quaternion(0f, 0.9f, 0f, 1f);
            DragNDrop dnd = ins.AddComponent<DragNDrop>();
            dnd.isEquipped = true;
            BodyPart[] bodyParts = ins.GetComponents<BodyPart>();
            foreach (BodyPart bodyPart in bodyParts)
            {
                if (bodyPart != null && bodyPart.bodyPartType == BodyPartType.Mitten)
                {
                    EquipGameObject(bodyPart, LeftMittenPosition);
                }
            }
        }
        if (EquipedItems.GetRightHand() != null)
        {
            GameObject obj = (GameObject)Resources.Load(EquipedItems.GetRightHand(), typeof(GameObject));
            GameObject ins = Instantiate(obj);
            ins.layer = 2;
            ins.transform.localRotation = new Quaternion(0f, -0.9f, 0f, 1f);
            DragNDrop dnd = ins.AddComponent<DragNDrop>();
            dnd.isEquipped = true;
            BodyPart[] bodyParts = ins.GetComponents<BodyPart>();
            foreach (BodyPart bodyPart in bodyParts)
            {
                if (bodyPart != null && bodyPart.bodyPartType == BodyPartType.Mitten)
                {
                    EquipGameObject(bodyPart, RightMittenPosition);
                }
            }
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
                if (bph != null)
                {
                    if (bodyPart != null)
                    {
                        InventoryObject io = obj.GetComponent<InventoryObject>();
                        if (io != null)
                        {
                            switch (bodyPart.bodyPartType)
                            {
                                case BodyPartType.Hat:
                                    if (EquipedItems.GetHat() == null)
                                    {
                                        HatEquipmentPosition.Object = obj;
                                        EquipGameObject(bodyPart, HatEquipmentPosition.ObjectPosition);
                                        if (HatToggle != null)
                                        {
                                            HatToggle.isOn = true;
                                        }
                                       
                                            EquipedItems.EquipHat(io.ResourceName);
                                      
                                        retval = true;
                                    }
                                    break;
                                case BodyPartType.EyeNose:

                                    if (EquipedItems.GetLeftEye() == null)
                                    {
                            
                                        EquipGameObject(bodyPart, LeftEyePosition);
                                        if (LeftEyeToggle != null)
                                        {
                                            LeftEyeToggle.isOn = true;
                                        }
                                       
                                            EquipedItems.EquipLeftEye(io.ResourceName);
                                        
                                        retval = true;
                                    }
                                    else if (EquipedItems.GetLeftEye() != io.ResourceName && EquipedItems.GetRightEye() == null)
                                    {
                        
                                        EquipGameObject(bodyPart, RightEyePosition);
                                        if (RightEyeToggle != null)
                                        {
                                            RightEyeToggle.isOn = true;
                                        }
                                        
                                            EquipedItems.EquipRightEye(io.ResourceName);
                                       
                                        retval = true;
                                    }
                                    else if (EquipedItems.GetLeftEye() != io.ResourceName && EquipedItems.GetRightEye() != io.ResourceName && EquipedItems.GetNose() == null)
                                    {
               
                                        EquipGameObject(bodyPart, NosePosition);
                                        if (NoseToggle != null)
                                        {
                                            NoseToggle.isOn = true;
                                        }
                                       
                                            EquipedItems.EquipNose(io.ResourceName);
                                      
                                        retval = true;
                                    }
                                    break;
                                case BodyPartType.Mouth:
                                    if (EquipedItems.GetMouth() == null)
                                    {
                                    
                                        EquipGameObject(bodyPart, MouthPosition);
                                        if (MouthToggle != null)
                                        {
                                            MouthToggle.isOn = true;
                                        }
                                       
                                            EquipedItems.EquipMouth(io.ResourceName);
                                      
                                        retval = true;
                                    }
                                    break;
                                case BodyPartType.Scarf:
                                    if (EquipedItems.GetNeck() == null)
                                    {
                  
                                        EquipGameObject(bodyPart, ScarfPosition);
                                        if (ScarfToggle != null)
                                        {
                                            ScarfToggle.isOn = true;
                                        }
                                       EquipedItems.EquipNeck(io.ResourceName);
                                       
                                        retval = true;
                                    }
                                    break;
                                case BodyPartType.Mitten:
                                    if (EquipedItems.GetLeftHand() == null)
                                    {
                                
                                        EquipGameObject(bodyPart, LeftMittenPosition);
                                        if (LeftMittenToggle != null)
                                        {
                                            LeftMittenToggle.isOn = true;
                                        }
                                       
                                            EquipedItems.EquipLeftHand(io.ResourceName);
                                      
                                        // Rotate Mitten so Thumb is up.
                                        obj.transform.localRotation = new Quaternion(0f, 0.9f, 0f, 1f);
                                        retval = true;
                                    }
                                    else if (EquipedItems.GetLeftHand() != io.ResourceName && EquipedItems.GetRightHand() == null)
                                    {
                                        
                                        EquipGameObject(bodyPart, RightMittenPosition);
                                        if (RightMittenToggle != null)
                                        {
                                            RightMittenToggle.isOn = true;
                                        }

                                        EquipedItems.EquipRightHand(io.ResourceName);

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
