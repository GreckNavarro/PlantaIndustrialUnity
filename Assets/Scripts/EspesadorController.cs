using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspesadorController : MonoBehaviour
{

    private bool activar;
    public float velocidadRotacion = 30f; // Puedes ajustar la velocidad de rotación según tus necesidades

    private void Start()
    {
        activar = false;
    }
    void Update()
    {
        if (activar == true)
        {
            transform.Rotate(0f, 0f, velocidadRotacion * Time.deltaTime);
        }
        else if (activar == false)
        {
            transform.Rotate(0f, 0f, 0f);
        }
        Debug.Log(activar);
    }
    public void SetActiva(bool activa)
    {
        activar = activa;
    }
}
