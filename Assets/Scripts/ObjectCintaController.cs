using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCintaController : MonoBehaviour
{
    [SerializeField] int velocidad;
    [SerializeField] Rigidbody rb;
    [SerializeField] GeneradorCinta _cinta;
    private bool cambiardireccion;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cambiardireccion = false;
    }

    public void SetPool(GeneradorCinta cinta)
    {
        _cinta = cinta;
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        Movement();
    }
    void Update()
    {
        
    }

    private void Movement()
    {
        if(cambiardireccion == false)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, velocidad);
        }
        else if(cambiardireccion == true)
        {
            rb.velocity = new Vector3(velocidad, rb.velocity.y, rb.velocity.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Stock")
        {
            _cinta.ReturnToPool(this.gameObject);
            cambiardireccion = false;

        }

        if (other.gameObject.tag == "Cambio")
        {
            cambiardireccion = true;

        }
    }
}
