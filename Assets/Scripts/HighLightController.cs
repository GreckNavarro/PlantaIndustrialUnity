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

        // Prender y apagar el arreglo de luces que se coloquen dependiendo de si presiona una tecla y está dentro del collider
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

    // Detectar si el jugador está cerca para prender las luces
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
