using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour {

    public new Camera camera = null;
    public Text ActionPromptText = null;
    public Text ActionNameText = null;
    public GameObject ActionPromptImage = null;

    void Start()
    {
     
        if (camera == null)
        {
            camera = GetComponent<Camera>();
            if (camera == null)
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

    void FixedUpdate()
    {
        Vector3 point = new Vector3(camera.pixelWidth / 2, camera.pixelHeight / 2, 0);
        Ray ray = camera.ScreenPointToRay(point);
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
                
                if (Input.GetButton("Activate"))
                {
                    Inventory.addObject(io.ResourceName);
                    DestroyObject(hit.collider.gameObject);
                }
            }
            else
            {
                ActionPromptText.enabled = false;
                ActionNameText.enabled = false;
                ActionPromptImage.SetActive(false);
            }
        }
        else
        {
            ActionPromptText.enabled = false;
            ActionNameText.enabled = false;
            ActionPromptImage.SetActive(false);
        }
    }
}
