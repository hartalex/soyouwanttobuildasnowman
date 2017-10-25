using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dnd : MonoBehaviour
{
    private bool _mouseState;
    private GameObject target;
    public Vector3 screenSpace;
    public Vector3 offset;
    public Vector3 origin;
    private bool isEquipped = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(_mouseState);
        if (Input.GetMouseButtonDown(0))
        {
            origin = transform.localPosition;
            RaycastHit hitInfo;
            target = GetClickedObject(out hitInfo);
            if (target != null)
            {
                Dnd dnd = target.GetComponent<Dnd>();
                if (dnd != null)
                {
                    _mouseState = true;
                    screenSpace = Camera.main.WorldToScreenPoint(target.transform.position);
                    offset = target.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z));
                }
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            _mouseState = false;
            RaycastHit hitInfo;
            target = GetClickedObject(out hitInfo);
            if (target != null)
            {
                
                Body body = target.GetComponent<Body>();
                if (body != null)
                {
                    if (body.TryEquipGameObject(this.gameObject))
                    {
                        isEquipped = true;
                        Rotate rotate = GetComponent<Rotate>();
                        if (rotate != null) {
                            rotate.enabled = false;
                        }
                    }
                    else
                    {
                        transform.localPosition = origin;
                        isEquipped = false;
                    }
                }
                    else
                {
                    body = target.GetComponentInParent<Body>();
                    if (body != null)
                    {
                        if (body.TryEquipGameObject(this.gameObject))
                        {
                            isEquipped = true;
                            Rotate rotate = GetComponent<Rotate>();
                            if (rotate != null)
                            {
                                rotate.enabled = false;
                            }
                        } else
                        {
                            transform.localPosition = origin;
                            isEquipped = false;
                        }
                    }
                    else
                    {
                        // InspectPosition needs  rigidbody and collider and larger hot spot
                        // Player needs larger hotspot as well
                        if (isEquipped && target.name == "inspectPosition")
                        {
                            if (target.transform.childCount > 0)
                            {
                                for (int i = 0; i < target.transform.childCount; i++)
                                {
                                    DestroyObject(target.transform.GetChild(i).gameObject);
                                }
                            }
                            transform.parent = target.transform;
                            Rotate rotate = GetComponent<Rotate>();
                            if (rotate != null)
                            {
                                rotate.enabled = true;
                            }
                            BodyPart[] bodyParts = GetComponents<BodyPart>();
                            InventoryObject io = GetCompoent<InventoryObject>();
                            if (io != null) {
                                foreach (BodyPart bodyPart in bodyParts)
                                {
                                    if (bp != null)
                                    {
                                        switch (bp.bodyPartType)
                                        {
                                            case BodyPartType.Hat:
                                                if (EquippedItems.GetHat() == io.ResourceName)
                                                {
                                                    EquippedItems.EquipHat(null);
                                                }
                                                break;
                                            case BodyPartType.EyeNose:
                                                if (EquippedItems.GetLeftEye() == io.ResourceName)
                                                {
                                                    EquippedItems.EquipLeftEye(null);
                                                }
                                                if (EquippedItems.GetRightEye() == io.ResourceName)
                                                {
                                                    EquippedItems.EquipRightEye(null);
                                                }
                                                if (EquippedItems.GetNose() == io.ResourceName)
                                                {
                                                    EquippedItems.EquipNose(null);
                                                }
                                                break;
                                            case BodyPartType.Mouth:
                                                if (EquippedItems.GetMouth() == io.ResourceName)
                                                {
                                                    EquippedItems.EquipMouth(null);
                                                }
                                                break;
                                            case BodyPartType.Scarf:
                                                if (EquippedItems.GetNeck() == io.ResourceName)
                                                {
                                                    EquippedItems.EquipNeck(null);
                                                }
                                                break;
                                            case BodyPartType.Hitten:
                                                if (EquippedItems.GetLeftHand() == io.ResourceName)
                                                {
                                                    EquippedItems.EquipLeftHand(null);
                                                }
                                                if (EquippedItems.GetRightHand() == io.ResourceName)
                                                {
                                                    EquippedItems.EquipRightHand(null);
                                                }
                                                break;
                                        }
                                    }
                                }
                            }
                            
                        }
                        else
                        {

                            transform.localPosition = origin;
                            isEquipped = false;
                        }

                    }
                }
            }
            else
            {
                transform.localPosition = origin;
                isEquipped = false;
            }
        }
        if (_mouseState)
        {
            //keep track of the mouse position
            var curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z);

            //convert the screen mouse position to world point and adjust with offset
            var curPosition = Camera.main.ScreenToWorldPoint(curScreenSpace) + offset;

            //update the position of the object in the world
            target.transform.position = curPosition;
        }
    }


    GameObject GetClickedObject(out RaycastHit hit)
    {
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))
        {
            target = hit.collider.gameObject;
        }

        return target;
    }
}
