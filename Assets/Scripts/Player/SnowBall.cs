using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour
{
    public float speed = 10.0f;
    public GameObject snowBallExplosion = null;
    private MeshRenderer meshRenderer = null;
    public float gravity = -9.8f;
    public float height = 1;

    void Start()
    {
        if (snowBallExplosion == null)
        {
            throw new MissingReferenceException("Missing snowBallExplosion Object");
        }
        meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer == null)
        {
            throw new MissingComponentException("Missing meshRenderer Componenet");
        }   
    }

    // Update is called once per frame
    void Update()
    {
        height += gravity * Time.deltaTime;
        Vector3 newPos = new Vector3(0, height, speed * Time.deltaTime);
       
        transform.Translate(newPos);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != 2)
        { // Ignore Raycast
            HitIndicator();
            other.gameObject.SendMessage("SnowBalled",null,SendMessageOptions.DontRequireReceiver);
        }
    }

    private void HitIndicator()
    {
        if (meshRenderer != null)
        {
            meshRenderer.enabled = false;
            GameObject explosion = GameObject.Instantiate(snowBallExplosion);
            explosion.transform.position = transform.position;
            DestroyObject(this.gameObject);
        }
    }

    
}
