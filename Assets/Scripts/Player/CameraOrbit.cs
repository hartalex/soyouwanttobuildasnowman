using UnityEngine;
using System.Collections;

public class CameraOrbit : MonoBehaviour {

	public float turnSpeed = 0.5f;
	public Transform player;

	public float height = 1f;
	public float distance = 3f;

	private Vector3 offsetX;

	void Start () {

		offsetX = new Vector3(0, height, distance);
	}

	void LateUpdate()
	{
		offsetX = Quaternion.AngleAxis (1 * turnSpeed, Vector3.up) * offsetX;
		transform.position = player.position + offsetX; 
		transform.LookAt(player.position);
	}
}