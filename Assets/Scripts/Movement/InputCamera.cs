using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCamera : MonoBehaviour {

    public float speed = 6.0f;
    public float gravity = -9.8f;

    private CharacterController charController;
    private Rigidbody rigidBody;
    private float myMass = 1;
    public Camera mainCamera = null;
 

    void Start()
    {
        charController = GetComponent<CharacterController>();
        rigidBody = GetComponent<Rigidbody>();
        myMass = rigidBody.mass;
    }

    void Update()
    {

        float deltaX = UnityEngine.Input.GetAxis("Horizontal") * speed;
        float deltaZ = UnityEngine.Input.GetAxis("Vertical") * speed;
            Vector3 movement = new Vector3(deltaX, 0, deltaZ);

            movement = Vector3.ClampMagnitude(movement, speed);

            movement *= Time.deltaTime;

            Vector3 cameraWorldMovement = mainCamera.transform.TransformDirection(movement);
            Vector3 cameraWorldMovementGravity = cameraWorldMovement;
        cameraWorldMovement.y = 0;
        cameraWorldMovementGravity.y += gravity;
        charController.Move(cameraWorldMovementGravity);

        Vector3 worldMovement = transform.position + cameraWorldMovement;
       
        if (movement.x != 0 || movement.z != 0)
        {
            transform.LookAt(worldMovement);
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {

        Rigidbody body = hit.collider.attachedRigidbody;
        float pushPower = 0;

        if (body == null || body.isKinematic)
            return;

        if (hit.moveDirection.y < -0.3F)
            return;

        if (body.mass < myMass)
        {
            pushPower = myMass / body.mass;
        }
        else
        {
            return;
        }

        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        // body.velocity = Vector3.ClampMagnitude(pushDir * pushPower, speed);
    }
}
