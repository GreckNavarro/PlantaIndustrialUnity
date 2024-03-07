using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
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
      
        //Bloquear y desbloquear la c�mara para que el usuario pueda presionar el bot�n de men�
        if (Input.GetKeyDown(KeyCode.P) && cursor == true)
        {
            Cursor.lockState = CursorLockMode.None;
            cursor = false;
            Debug.Log("Hola");
        }
        else if(Input.GetKeyDown(KeyCode.P) && cursor == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            cursor = true;
        }
        
    }

    // Movimiento del player
    void Movement()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(x, 0, y);
        transform.Translate(movimiento * Time.deltaTime * movementSpeed);

    }

    // Actualizar hacia donde est� mirando el usuario
    void UpdateMouseLook()
    {
        float hormouse = Input.GetAxis("Mouse X");
        float vermouse = Input.GetAxis("Mouse Y");

        if (hormouse != 0)
        {
            transform.Rotate(0, hormouse * sensibilidadMouse.x, 0);
        }

        // Limitar el movimiento de la c�mara para que no pueda girar por completo

        if (vermouse != 0)
        {
            Vector3 rotation = camera.localEulerAngles;
            rotation.x = (rotation.x - vermouse * sensibilidadMouse.y + 360) % 360;

            if(rotation.x > 80 && rotation.x < 180)
            {
                rotation.x = 80;
            }
            else if(rotation.x < 280 && rotation.x > 180)
            {
                rotation.x = 280;
            }

            camera.localEulerAngles = rotation;
        }


    }
}
