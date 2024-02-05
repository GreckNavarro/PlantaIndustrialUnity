using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCintaController : MonoBehaviour
{
    [SerializeField] int velocidad;
    [SerializeField] Rigidbody rb;
    [SerializeField] GeneradorCinta _cinta;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void SetPool(GeneradorCinta cinta)
    {
        _cinta = cinta;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, velocidad);   
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Stock")
        {
            _cinta.ReturnToPool(this.gameObject);

        }
    }
}
