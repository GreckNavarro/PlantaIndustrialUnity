using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorLuzController : MonoBehaviour
{
    private Light spotlight;
    public float intensity;
    private bool cambiar;

    private void Start()
    {
        spotlight = GetComponent<Light>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            spotlight.intensity = intensity;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            spotlight.intensity = 0;
        }
    }
}
