using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorCinta : MonoBehaviour
{
    public GameObject prefab;  // El objeto que queremos pool
    public int poolSize = 10;   // Tamaño inicial del pool
    public bool canExpand = true;  // Permite expandir el pool si se necesitan más objetos
    public float tiempoEntreGeneraciones = 2f;

    private List<GameObject> objectPool;

    void Start()
    {
        InitializeObjectPool();
        StartCoroutine(GenerateObjectPeriodically());
    }

    private void InitializeObjectPool()
    {
        objectPool = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab, transform);
            obj.GetComponent<ObjectCintaController>().SetPool(this);
            objectPool.Add(obj);
            obj.SetActive(false);
        }
    }
    private IEnumerator GenerateObjectPeriodically()
    {
        while (true)
        {
            float tmp = Random.Range(0.1f, tiempoEntreGeneraciones);
            yield return new WaitForSeconds(tmp);

            // Obtener un objeto del pool
            GameObject obj = GetPooledObject();

            // Configurar la posición inicial del objeto
            obj.transform.position = new Vector3(Random.Range(transform.position.x - 0.5f, transform.position.x + 0.5f), transform.position.y, transform.position.z);
            obj.transform.rotation = transform.rotation;
            obj.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
            obj.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
            // Activar el objeto
            obj.SetActive(true);
        }
    }
    private GameObject GetPooledObject()
    {
        for (int i = 0; i < objectPool.Count; i++)
        {
            if (!objectPool[i].activeInHierarchy)
            {
                return objectPool[i];
            }
        }

        if (canExpand)
        {
            GameObject obj = Instantiate(prefab, transform);
            obj.GetComponent<ObjectCintaController>().SetPool(this);
            objectPool.Add(obj);
            return obj;
        }

        return null;  // Retorna null si no se encuentra un objeto disponible y no se permite la expansión
    }
    public void ReturnToPool(GameObject obj)
    {
        obj.SetActive(false);
        
    }

}
