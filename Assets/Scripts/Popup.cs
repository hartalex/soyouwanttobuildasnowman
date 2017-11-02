using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour {
    public bool isEnabled = true;
    public float Step;
    public float Offset = 6f;
    public float max = 2.5f;
    public float alt = 0f;
    public float incre = 0.1f;

    public Vector3 InitialPosition;


    void Start()
    {
        //Store where we were placed in the editor
        InitialPosition = transform.position;
        Step = 0;
    }

    void FixedUpdate()
    {
        if (isEnabled)
        {
            Step += incre;
            //Make sure Steps value never gets too out of hand 
            if (Step < max)
            {

                //Float up and down along the y axis, 
                transform.position = new Vector3(InitialPosition.x, InitialPosition.y + (Mathf.Sin(Step) * Offset) + alt, InitialPosition.z);
            } else
            {
                DestroyObject(this);
            }
        }
    }
}
