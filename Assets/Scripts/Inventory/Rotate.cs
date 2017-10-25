using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    private Rigidbody rigidBody;
    public float force = 1f;

    public bool X = false;
    public bool Y = false;
    public bool Z = false;

    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        if (rigidBody == null)
        {
            throw new MissingComponentException("Missing Rigidbody Component");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = 0;
        float y = 0;
        float z = 0;

        if (X)
        {
            x = force * Time.deltaTime;
        }
        if (Y)
        {
            y = force * Time.deltaTime;
        }
        if (Z)
        {
            z = force * Time.deltaTime;
        }

        Vector3 vector = new Vector3(x, y, z);
        rigidBody.transform.Rotate(vector);
    }
}