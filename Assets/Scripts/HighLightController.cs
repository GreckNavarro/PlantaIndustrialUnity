using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighLightController : MonoBehaviour
{
    public Light[] luces;
    public bool activar;
    public bool enZona;




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && enZona == true)
        {
            activar = !activar;

            if (activar == true)
            {
                for (int i = 0; i < luces.Length; i++)
                {
                    luces[i].GetComponent<SpotLightHighBay>().CambiarEstado(true);
                }
            }

            if (activar == false)
            {
                for (int i = 0; i < luces.Length; i++)
                {
                    luces[i].GetComponent<SpotLightHighBay>().CambiarEstado(false);
                }
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enZona = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enZona = false;
        }
    }
}
