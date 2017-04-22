using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class PencilAttack : MonoBehaviour {
	public GameObject prefabPencil;
	public GameObject camera;
	public GameObject body;

	private float startTime;
	private float nowTime;
	public bool doNotDestroy = false;
	public float speed = 10f;
	public float lifetime = 3.0f;

	// Use this for initialization
	void Start () {
		if (!doNotDestroy) {
			startTime = Time.time;		
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1")) {
			GameObject prefab = (GameObject)Instantiate (prefabPencil,body.transform.position + (new Vector3(camera.transform.rotation.x, 0, body.transform.rotation.y)*2), Quaternion.identity, body.transform);
			prefab.transform.rotation = transform.rotation;
			Rigidbody rigidBody = prefab.GetComponent<Rigidbody> ();
			if (rigidBody != null) {
				rigidBody.isKinematic = false;
				rigidBody.AddForce(new Vector3(camera.transform.rotation.x, 0, body.transform.rotation.y) * speed,ForceMode.Impulse);
			}
		}
		nowTime = Time.time;
		if (!doNotDestroy && Time.time - startTime > lifetime) {
			DestroyObject (this.gameObject);
		}
	}
}
