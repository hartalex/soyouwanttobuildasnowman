using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCamera : MonoBehaviour
{

    public float speed = 6.0f;
    public float gravity = -9.8f;

    private CharacterController charController;
    public Camera mainCamera = null;
    public float jumpSpeed = 8.0F;
    public GameObject snowmanbase = null;
    public GameObject snowmanmid = null;
    public int rotationBaseSpeedModifier = -10;
    private float startMoveTime = 0;
    private float endMoveTime = -1;
    private float timeToFullSpeed = 1.0f;
    private float timeToNoSpeed = 1f;
    private float currentTime = 0;
    private float currentSpeed = 6.0f;


    void Start()
    {
        charController = GetComponent<CharacterController>();
        currentSpeed = speed;
    }

    void LateUpdate()
    {

        float deltaX = UnityEngine.Input.GetAxis("Horizontal") * speed;
        float deltaZ = UnityEngine.Input.GetAxis("Vertical") * speed;
        if (Input.GetButton("ResetCamera"))
        {
            deltaX = 0;
            deltaZ = 0;
        }
            Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        if (deltaX != 0 || deltaZ != 0)
        {
          
                currentTime = (Time.time - startMoveTime / timeToFullSpeed);
                currentSpeed = Mathf.Lerp(speed / 4, speed, currentTime);
                snowmanbase.transform.Rotate(rotationBaseSpeedModifier * currentSpeed * Time.deltaTime, 0, 0);
                Quaternion rotation = snowmanmid.transform.localRotation;
                snowmanmid.transform.localRotation = Quaternion.Euler(Mathf.Lerp(-20 / 4, -20, currentTime), 0, -90);
                Vector3 position = new Vector3(0, Mathf.Lerp(0.25f / 4, 0.25f, currentTime), 1.25f);
                snowmanmid.transform.localPosition = position;
                endMoveTime = 0;
                if (startMoveTime == 0)
                {
                    startMoveTime = Time.time;
                }
          
        }
        else
        {
            if (endMoveTime == 0)
            {
                endMoveTime = Time.time;
            }
            currentTime = (Time.time - endMoveTime / timeToNoSpeed);
            snowmanmid.transform.localRotation = Quaternion.Euler(Mathf.Lerp(-20, 0, currentTime), 0, -90);
            Vector3 position = new Vector3(0, Mathf.Lerp(0.25f, 0f, currentTime), 1.25f);
            snowmanmid.transform.localPosition = position;
            startMoveTime = 0;
        }
        movement = Vector3.ClampMagnitude(movement, currentSpeed);

        movement *= Time.deltaTime;

        Vector3 cameraWorldMovement = mainCamera.transform.TransformDirection(movement);
        Vector3 cameraWorldMovementGravity = cameraWorldMovement;
        cameraWorldMovement.y = 0;
        if (UnityEngine.Input.GetButton("Jump") && charController.isGrounded)
        {
            //    cameraWorldMovementGravity.y += jumpSpeed;
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
