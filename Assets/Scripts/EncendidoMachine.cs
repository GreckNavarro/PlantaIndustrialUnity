using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncendidoMachine : MonoBehaviour
{
    private bool enZona;
    private bool activa;
    public GameObject[] moledoras;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && enZona == true)
        {
            activa = !activa;

            if (activa == true)
            {
                for (int i = 0; i < moledoras.Length; i++)
                {
                    moledoras[i].GetComponent<EspesadorController>().SetActiva(true);
                }
            }

            if (activa == false)
            {
                for (int i = 0; i < moledoras.Length; i++)
                {
                    moledoras[i].GetComponent<EspesadorController>().SetActiva(false);
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
