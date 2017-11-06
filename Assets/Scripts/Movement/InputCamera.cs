using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCamera : MonoBehaviour {

    public float speed = 6.0f;
    public float gravity = -9.8f;

    private CharacterController charController;
    public Camera mainCamera = null;
    public float jumpSpeed = 8.0F;


    void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    void LateUpdate()
    {

        float deltaX = UnityEngine.Input.GetAxis("Horizontal") * speed;
        float deltaZ = UnityEngine.Input.GetAxis("Vertical") * speed;
            Vector3 movement = new Vector3(deltaX, 0, deltaZ);

            movement = Vector3.ClampMagnitude(movement, speed);

            movement *= Time.deltaTime;

            Vector3 cameraWorldMovement = mainCamera.transform.TransformDirection(movement);
            Vector3 cameraWorldMovementGravity = cameraWorldMovement;
        cameraWorldMovement.y = 0;
        if (UnityEngine.Input.GetButton("Jump")&& charController.isGrounded)
        {
            cameraWorldMovementGravity.y += jumpSpeed;
        }
        cameraWorldMovementGravity.y += gravity;
        charController.Move(cameraWorldMovementGravity);

        Vector3 worldMovement = transform.position + cameraWorldMovement;
       
        if (movement.x != 0 || movement.z != 0)
        {
            transform.LookAt(worldMovement);
        }
    }
}
