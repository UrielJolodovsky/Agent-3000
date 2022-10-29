using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararTorreta : MonoBehaviour
{
    [SerializeField] int counter;
    public bool disparar;
    public GameObject bala;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(disparar)
        {
            InvokeRepeating("Disparar", 0f, 10f);
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            disparar = true;
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            disparar = false;
        }
    }
    void Disparar()
    {
        Instantiate(bala, transform.position, transform.rotation);
    }
}
