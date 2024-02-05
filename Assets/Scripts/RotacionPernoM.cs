using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionPernoM : MonoBehaviour
{

    public float velocidadRotacion = 30f; // Puedes ajustar la velocidad de rotaci�n seg�n tus necesidades

    void Update()
    {
        // Rotar el objeto en el eje Z constantemente
        transform.Rotate(velocidadRotacion * Time.deltaTime, 0f, 0f);
    }
}
