using UnityEngine;
using System.Collections;

public class CollectByCollision : MonoBehaviour
{

    void OnTriggerEnter(Collider collider)
    {
        Body body = collider.gameObject.GetComponent<Body>();
        if (body != null)
        {
            DestroyObject(this.gameObject);
        }
    }
}
