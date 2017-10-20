using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallShooter : MonoBehaviour {

    private Camera camera = null;

    public GameObject snowBall = null;
    public int maxDistance = 30;

    // Use this for initialization
    void Start () {
        camera = GetComponent<Camera>();
        if (camera == null)
        {
            throw new MissingComponentException("Missing Camera Component");
        }
        if (snowBall == null)
        {
            throw new MissingReferenceException("Missing SnowBall Object");
        }
      
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            Vector3 point = new Vector3(camera.pixelWidth / 2, camera.pixelHeight / 2, 0);
            Ray ray = camera.ScreenPointToRay(point);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                GameObject mySnowBall = GameObject.Instantiate(snowBall);
                mySnowBall.transform.position = transform.TransformPoint(Vector3.forward * 2.5f);
                mySnowBall.transform.position = transform.TransformPoint(Vector3.right);
                                               
                mySnowBall.transform.LookAt(hit.point);
                SnowBall snowBallScript = mySnowBall.GetComponent<SnowBall>();
                snowBallScript.endposition = hit.transform.position;
                
            }
        }
	}
        

    private void OnGUI()
    {
        int size = 12;
        float posX = camera.pixelWidth / 2 - size / 4;
        float posY = camera.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "*");
    }
}
