using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        GameObject obj = collision.gameObject;
        InventoryObject io = obj.GetComponent<InventoryObject>();
        if (io != null)
        {
            Inventory.addObject(io.ResourceName);
            DestroyObject(obj);
        }
    }
}
