using UnityEngine;
using System.Collections;

public class Look : MonoBehaviour {
	public enum RotationAxes {
		MouseXAndY = 0,
		MouseX = 1,
		MouseY = 2
	}
	public RotationAxes axes = RotationAxes.MouseXAndY;

	public float sensitivityHor = 9.0f;
	public float sensitivityVert = 9.0f;
	
	public float minVert = -45.0f;
	public float maxVert = 45.0f;

	private float rotX = 0;
	
	void Start() {
		Rigidbody body = GetComponent<Rigidbody>();
		if (body != null)
			body.freezeRotation = true;
	}

	void Update() {
		if (axes == RotationAxes.MouseX) {
			transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
		}
		else if (axes == RotationAxes.MouseY) {
			rotX -= Input.GetAxis("Mouse Y") * sensitivityVert;
			rotX = Mathf.Clamp(rotX, minVert, maxVert);
			transform.localEulerAngles = new Vector3(rotX, transform.localEulerAngles.y, 0);
		}
		else {
			float rotY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityHor;
			rotX -= Input.GetAxis("Mouse Y") * sensitivityVert;
			rotX = Mathf.Clamp(rotX, minVert, maxVert);
			transform.localEulerAngles = new Vector3(rotX, rotY, 0);
		}
	}
}