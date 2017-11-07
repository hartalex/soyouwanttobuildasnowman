using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbitLook : MonoBehaviour
{

    public GameObject target;//the target object
    public float speedMod = 10.0f;//a speed modifier
    
    public float distance = 10.0f;  // disptance between player and camera
    private Rigidbody myRigidbody = null;

    void Start()
    {//Set up things on the start method

        transform.LookAt(target.transform.position);//makes the camera look to it
        myRigidbody = GetComponent<Rigidbody>();
        if (myRigidbody == null)
        {
            throw new MissingComponentException("Missing RigidBody");
        }
    }

    void FixedUpdate()
    {//makes the camera rotate around "point" coords, rotating around its Y axis, 20 degrees per second times the speed modifier
        transform.RotateAround(target.transform.position, new Vector3(0.0f, 1.0f, 0.0f), 50*Time.deltaTime * speedMod * Input.GetAxis("Mouse X"));
        transform.RotateAround(target.transform.position, new Vector3(1.0f, 0.0f, 0.0f), 50*Time.deltaTime * speedMod * Input.GetAxis("Mouse Y"));
      
    }
    void LateUpdate()
    {

        transform.position = target.transform.position - transform.forward * distance;
        transform.LookAt(target.transform.position);//makes the camera look to it
    }
}
