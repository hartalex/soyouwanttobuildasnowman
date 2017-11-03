using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    void Start()
    {

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Cancel") || Input.GetButton("Inventory"))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
