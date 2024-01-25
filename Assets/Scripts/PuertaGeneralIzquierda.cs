using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaGeneralIzquierda : MonoBehaviour
{

    public Animator puerta;
    private bool enZona;
    private bool activa; 

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && enZona == true)
        {
            activa = !activa;

            if (activa == true)
            {
                puerta.SetBool("PuertaActiva", true);
            }

            if(activa == false)
            {
                puerta.SetBool("PuertaActiva", false);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
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
