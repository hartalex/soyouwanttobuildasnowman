﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour
{
    public float speed = 10.0f;
    public GameObject snowBallExplosion = null;
    private MeshRenderer meshRenderer = null;
    public Vector3 endposition;
    private Vector3 midpoint;

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
        Vector3 newPos = new Vector3(0, 0, speed * Time.deltaTime);
       
        transform.Translate(newPos);
    }

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(HitIndicator());

    }

    private IEnumerator HitIndicator()
    {
        meshRenderer.enabled = false;
        GameObject explosion = GameObject.Instantiate(snowBallExplosion);
        explosion.transform.position = transform.position;
        yield return new WaitForSeconds(0.3f);
        Destroy(explosion);
        Destroy(gameObject);
    }

    
}