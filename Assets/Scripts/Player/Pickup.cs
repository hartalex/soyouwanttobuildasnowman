using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Pickup : MonoBehaviour {

    public Camera viewCamera = null;
    public Text ActionPromptText = null;
    public Text ActionNameText = null;
    public GameObject ActionPromptImage = null;
    InventoryObject hoveredObject = null;

    void Start()
    {
     
        if (viewCamera == null)
        {
            viewCamera = GetComponent<Camera>();
            if (viewCamera == null)
            {
                throw new MissingComponentException("Missing Camera Component");
            }
        }

        if (ActionPromptText == null)
        {
            throw new MissingComponentException("Missing ActionPromptText Component");
        }
        if (ActionNameText == null)
        {
            throw new MissingComponentException("Missing ActionNameText Component");
        }
        if (ActionPromptImage == null)
        {
            throw new MissingComponentException("Missing ActionPromptImage Component");
        }
    }

    
    public void OnDrag(PointerEventData eventData)
    {

    }

void FixedUpdate()
    {
        // pickup if e pressed
        if (Input.GetButton("Activate") && hoveredObject != null)
        {
            Inventory.addObject(hoveredObject.ResourceName);
            DestroyObject(hoveredObject.gameObject);
            hoveredObject = null;
            ActionPromptText.enabled = false;
            ActionNameText.enabled = false;
            ActionPromptImage.SetActive(false);
        }

        if (Input.GetAxis("Mouse Y") != 0 || Input.GetAxis("Mouse X") != 0 ||
            Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            Vector3 point = new Vector3(viewCamera.pixelWidth / 2, viewCamera.pixelHeight / 2, 0);
            Ray ray = viewCamera.ScreenPointToRay(point);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 10))
            {
                InventoryObject io = hit.collider.gameObject.GetComponent<InventoryObject>();
                if (io != null)
                {
                    if (!ActionPromptText.enabled)
                    {
                        ActionPromptText.enabled = true;
                        ActionPromptText.text = io.Name;
                        ActionNameText.enabled = true;
                        ActionPromptImage.SetActive(true);
                    }

                    hoveredObject = io;
                }
                else
                {
                    hoveredObject = null;
                    ActionPromptText.enabled = false;
                    ActionNameText.enabled = false;
                    ActionPromptImage.SetActive(false);
                }
            }
            else
            {
                hoveredObject = null;
                ActionPromptText.enabled = false;
                ActionNameText.enabled = false;
                ActionPromptImage.SetActive(false);
            }
        }
    }
}
