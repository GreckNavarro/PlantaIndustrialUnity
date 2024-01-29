using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightController : MonoBehaviour
{
    private Light spotlight;
    private bool cambiar;

    private void Start()
    {
        spotlight = GetComponent<Light>();
    }

    public void CambiarEstado(bool recibirdato)
    {
        cambiar = !cambiar;

        if(cambiar == true)
        {
            spotlight.intensity = 3;
        }

        else if(cambiar == false)
        {
            spotlight.intensity = 0;
        }

    }
}
