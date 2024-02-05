using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionMoledora : MonoBehaviour
{

    public float velocidadRotacion = 30f; // Puedes ajustar la velocidad de rotación según tus necesidades

    void Update()
    {
        // Rotar el objeto en el eje Z constantemente
        transform.Rotate(0f, 0f, velocidadRotacion * Time.deltaTime);
    }
}
