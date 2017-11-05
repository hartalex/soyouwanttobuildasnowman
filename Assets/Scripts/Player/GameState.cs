using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
	public GameObject MainCamera = null;
	public GameObject Body = null;
    public GameObject CrossHairs = null;
	private bool isStartScreen = true;
    public SnowBallShooter snowBallShooter = null;

    void Start()
    {
        if (Inventory.GetStarted())
        {
            SetPlayingState();
            Body.gameObject.transform.localPosition = Inventory.GetPlayerPosition();
            Body.gameObject.transform.localRotation = Inventory.GetPlayerRotation();
            MainCamera.transform.localRotation = Inventory.GetCameraRotation();
        }
    }

	// Update is called once per frame
	void FixedUpdate () {

		// Start Scene is also the main scene, this gives snow some time to fall
		if (isStartScreen) {
				SetPlayingState ();
                Inventory.SetStarted(true);
		} else {
			if (Body.GetComponent<Body>().isComplete ()) {
				SetEndState ();
			}else
            {
                if (Input.GetButton("Inventory"))
                {
                    Inventory.SetPlayerPosition(Body.gameObject.transform.localPosition);
                    Inventory.SetPlayerRotation(Body.gameObject.transform.localRotation);
                    Inventory.SetCameraRotation(MainCamera.transform.localRotation);
                
                    SceneManager.LoadScene("Inventory");
                }
            }
		}
	}

	public void SetPlayingState() {
		isStartScreen = false;
        // Turn off Spinning 
        /*Look cameraLook = MainCamera.GetComponent<Look> ();
		if (cameraLook != null) {
			cameraLook.enabled = true;
		}
        /*CameraOrbit cameraOrbit = MainCamera.GetComponent<CameraOrbit> ();
		if (cameraOrbit != null) {
			cameraOrbit.enabled = false;
		}
        Look look = Body.GetComponent<Look> ();
		if (look != null) {
			look.enabled = true;
		}
        if (snowBallShooter != null)
        {
            snowBallShooter.enabled = true;
        }
        
        CrossHairs.SetActive(true);
        */

    }

    public void SetEndState()
	{
		

        if (Input.GetButton ("Fire1")) {
			SceneManager.LoadScene ("Title");
		}
	}
}

