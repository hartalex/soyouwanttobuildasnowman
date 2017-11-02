using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
	public GameObject YouWinText = null;
	public GameObject StartText = null;
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
			if (Input.GetButton ("Fire1")) {
				SetPlayingState ();
                Inventory.SetStarted(true);

            }
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
                
                    SceneManager.LoadScene(1);
                }
            }
		}
	}

	public void SetPlayingState() {
		isStartScreen = false;
		// Turn off Spinning 
		Look cameraLook = MainCamera.GetComponent<Look> ();
		if (cameraLook != null) {
			cameraLook.enabled = true;
		}
		CameraOrbit cameraOrbit = MainCamera.GetComponent<CameraOrbit> ();
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
        MainCamera.transform.localPosition = new Vector3 (0f, 4f, -7f);
		MainCamera.transform.localRotation = Quaternion.Euler(15, 0, 0);
		StartText.SetActive (false);
        CrossHairs.SetActive(true);


    }

	public void SetEndState()
	{
		// You WIN
		//MainCamera
		YouWinText.SetActive (true);
		MainCamera.transform.localRotation = new Quaternion (0f, 1.2f, 0f, 1f);
		Look cameraLook = MainCamera.GetComponent<Look> ();
		if (cameraLook != null) {
			cameraLook.enabled = false;
		}
		CameraOrbit cameraOrbit = MainCamera.GetComponent<CameraOrbit> ();
		if (cameraOrbit != null) {
			cameraOrbit.enabled = true;
		}
		Look look = Body.GetComponent<Look> ();
		if (look != null) {
			look.enabled = false;
		}
        
        if (snowBallShooter != null)
        {
            snowBallShooter.enabled = false;
        }
        CrossHairs.SetActive(false);

        if (Input.GetButton ("Fire1")) {
			SceneManager.LoadScene (0);
		}
	}
}

