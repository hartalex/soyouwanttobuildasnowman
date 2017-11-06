using UnityEngine;


public class SnowBallShooter : MonoBehaviour {

    public new Camera camera = null;

    public GameObject snowBall = null;
    public int maxDistance = 30;

    public float duration;
    private float startTime;

    // Use this for initialization
    void Start () {
        if (camera == null)
        {
            camera = GetComponent<Camera>();
            if (camera == null)
            {

                throw new MissingComponentException("Missing Camera Component");
            }
        }
        if (snowBall == null)
        {
            throw new MissingReferenceException("Missing SnowBall Object");
        }
        startTime = Time.time;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
	}

    // Update is called once per frame
    void FixedUpdate() {
        if (Time.time - startTime > duration) { 
            if (Input.GetButton("Fire1"))
            {
                Vector3 point = new Vector3(camera.pixelWidth / 2, camera.pixelHeight / 2, 0);
                Ray ray = camera.ScreenPointToRay(point);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    GameObject mySnowBall = GameObject.Instantiate(snowBall);
                    mySnowBall.transform.position = transform.position + (Vector3.forward * 5f);
                    mySnowBall.transform.position = transform.position + (Vector3.right);

                    mySnowBall.transform.LookAt(hit.point);
                    SnowBall snowBallScript = mySnowBall.GetComponent<SnowBall>();
                }
            }
            startTime = Time.time;
        }
	}
}
