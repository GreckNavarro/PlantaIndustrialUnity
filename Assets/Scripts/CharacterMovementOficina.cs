using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementOficina : MonoBehaviour
{
    public float movementSpeed;
    public Vector2 sensibilidadMouse;
    public Rigidbody rb;
    public new Transform camera;
    public bool cursor;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        cursor = true;
    }

    void FixedUpdate()
    {
        Movement();
    }

    private void Update()
    {
      
        if (cursor == true)
        {
            UpdateMouseLook();
        }

        if (Input.GetKeyDown(KeyCode.P) && cursor == true)
        {
            Cursor.lockState = CursorLockMode.None;
            cursor = false;
        }
        else if (Input.GetKeyDown(KeyCode.P) && cursor == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            cursor = true;
        }
    }

    void Movement()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 localInputDirection = new Vector3(x, 0f, y);

        // Convierte la dirección local a dirección global, considerando la rotación de la cámara
        Vector3 globalInputDirection = Camera.main.transform.TransformDirection(localInputDirection);

        // Aplica la dirección global al movimiento
        rb.velocity = new Vector3(globalInputDirection.x * movementSpeed, rb.velocity.y, globalInputDirection.z * movementSpeed);
    }

    void UpdateMouseLook()
    {
        float hormouse = Input.GetAxis("Mouse X");
        float vermouse = Input.GetAxis("Mouse Y");

        if (hormouse != 0)
        {
            transform.Rotate(0, hormouse * sensibilidadMouse.x, 0);
        }
        if (vermouse != 0)
        {
            Vector3 rotation = camera.localEulerAngles;
            rotation.x = (rotation.x - vermouse * sensibilidadMouse.y + 360) % 360;

            if (rotation.x > 80 && rotation.x < 180)
            {
                rotation.x = 80;
            }
            else if (rotation.x < 280 && rotation.x > 180)
            {
                rotation.x = 280;
            }

            camera.localEulerAngles = rotation;
        }
    }
}
