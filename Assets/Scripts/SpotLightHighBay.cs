using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightHighBay : MonoBehaviour
{
    private Light spotlight;
    private bool cambiar;
    public float intensidad;

    private void Start()
    {
        spotlight = GetComponent<Light>();
    }

    public void CambiarEstado(bool recibirdato)
    {
        cambiar = !cambiar;

        if(cambiar == true)
        {
            spotlight.intensity = intensidad;
        }

        else if(cambiar == false)
        {
            spotlight.intensity = 0;
        }

    }
}
