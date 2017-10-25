using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    public new Camera camera = null;

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
    }

    void FixedUpdate()
    {
        if (Input.GetButton("Activate"))
        {
            Vector3 point = new Vector3(camera.pixelWidth / 2, camera.pixelHeight / 2, 0);
            Ray ray = camera.ScreenPointToRay(point);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 5))
            {
                InventoryObject io = hit.collider.gameObject.GetComponent<InventoryObject>();
                if (io != null)
                {
                    Inventory.addObject(io.ResourceName);
                    DestroyObject(hit.collider.gameObject);
                }
            }
        }
    }
}
