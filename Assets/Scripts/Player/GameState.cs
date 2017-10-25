using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
	public GameObject YouWinText = null;
	public GameObject StartText = null;
	public GameObject MainCamera = null;
	public GameObject Body = null;
	private bool isStartScreen = true;

    void Start()
    {
        if (Inventory.GetStarted())
        {
            SetPlayingState();
       
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
                if (Input.GetButton("Menu"))
                {
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
        SnowBallShooter snowBallShooter = MainCamera.GetComponent<SnowBallShooter>();
        if (snowBallShooter != null)
        {
            snowBallShooter.enabled = true;
        }
        MainCamera.transform.localPosition = new Vector3 (0f, 1.9f, -2.26f);
		MainCamera.transform.rotation = Quaternion.EulerAngles(15, 0, 0);
		StartText.SetActive (false);

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
        SnowBallShooter snowBallShooter = MainCamera.GetComponent<SnowBallShooter>();
        if (snowBallShooter != null)
        {
            snowBallShooter.enabled = false;
        }

		if (Input.GetButton ("Fire1")) {
			SceneManager.LoadScene (0);
		}
	}
}

