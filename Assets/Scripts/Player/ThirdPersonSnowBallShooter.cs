﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonSnowBallShooter : MonoBehaviour
{

    public GameObject snowBall = null;
    public int maxDistance = 30;

    public float duration;
    private float startTime;

    // Use this for initialization
    void Start()
    {

        if (snowBall == null)
        {
            throw new MissingReferenceException("Missing SnowBall Object");
        }
        startTime = Time.time;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time - startTime > duration)
        {
            if (Input.GetButtonUp("Fire1"))
            {
                Vector3 origin = transform.position + transform.TransformDirection(Vector3.forward * 1.5f) + transform.TransformDirection(Vector3.right);
                Vector3 direction = transform.position + transform.TransformDirection(Vector3.forward * maxDistance);
                GameObject mySnowBall = GameObject.Instantiate(snowBall);
                mySnowBall.transform.position = origin;
                mySnowBall.transform.LookAt(direction);
                SnowBall snowBallScript = mySnowBall.GetComponent<SnowBall>();
                startTime = Time.time;
            }
           
        }
    }
}