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
    public bool isEquipped = false;
    private Quaternion originRotation;
    private Vector3 originScale;

    // Use this for initialization
    void Start()
    {
        originRotation = transform.localRotation;
        originScale = transform.localScale;
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
                    Collider col = target.GetComponent<Collider>();
                    if (col != null)
                    {
                        col.enabled = false;
                    }
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
                Collider col = GetComponent<Collider>();
                if (col != null)
                {
                    col.enabled = true;
                }
                Body body = target.GetComponent<Body>();
                if (body != null)
                {
                    if (body.TryEquipGameObject(this.gameObject))
                    {
                        isEquipped = true;
                        Rotate rotate = GetComponent<Rotate>();
                        if (rotate != null) {
                            rotate.enabled = false;
                            transform.localRotation = originRotation;
                            transform.localScale = originScale;
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
                                transform.localRotation = originRotation;
                                transform.localScale = originScale;
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
                        if (isEquipped && target.name == "InspectPosition")
                        {
                            if (target.transform.childCount > 0)
                            {
                                for (int i = 0; i < target.transform.childCount; i++)
                                {
                                    DestroyObject(target.transform.GetChild(i).gameObject);
                                }
                            }
                            BodyPartHover bph = GetComponent<BodyPartHover>();
                            if (bph != null)
                            {
                                bph.isEnabled = false;
                            }
                            isEquipped = false;
                            transform.parent = target.transform;
                            transform.localRotation = originRotation;
                            transform.localScale = originScale;
                            Rotate rotate = GetComponent<Rotate>();
                            if (rotate != null)
                            {
                                rotate.enabled = true;
                            }
                            BodyPart[] bodyParts = GetComponents<BodyPart>();
                            InventoryObject io = GetComponent<InventoryObject>();
                            if (io != null) {
                                foreach (BodyPart bodyPart in bodyParts)
                                {
                                    if (bodyPart != null)
                                    {
                                        switch (bodyPart.bodyPartType)
                                        {
                                            case BodyPartType.Hat:
                                                if (EquipedItems.GetHat() == io.ResourceName)
                                                {
                                                    EquipedItems.EquipHat(null);
                                                }
                                                break;
                                            case BodyPartType.EyeNose:
                                                if (EquipedItems.GetLeftEye() == io.ResourceName)
                                                {
                                                    EquipedItems.EquipLeftEye(null);
                                                }
                                                if (EquipedItems.GetRightEye() == io.ResourceName)
                                                {
                                                    EquipedItems.EquipRightEye(null);
                                                }
                                                if (EquipedItems.GetNose() == io.ResourceName)
                                                {
                                                    EquipedItems.EquipNose(null);
                                                }
                                                break;
                                            case BodyPartType.Mouth:
                                                if (EquipedItems.GetMouth() == io.ResourceName)
                                                {
                                                    EquipedItems.EquipMouth(null);
                                                }
                                                break;
                                            case BodyPartType.Scarf:
                                                if (EquipedItems.GetNeck() == io.ResourceName)
                                                {
                                                    EquipedItems.EquipNeck(null);
                                                }
                                                break;
                                            case BodyPartType.Mitten:
                                                if (EquipedItems.GetLeftHand() == io.ResourceName)
                                                {
                                                    EquipedItems.EquipLeftHand(null);
                                                }
                                                if (EquipedItems.GetRightHand() == io.ResourceName)
                                                {
                                                    EquipedItems.EquipRightHand(null);
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
