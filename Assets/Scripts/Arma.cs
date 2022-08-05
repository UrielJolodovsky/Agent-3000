using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public GameObject bala;
    public GameObject armajugador;
    float speed = 2;
    float lifetime = 2;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(bala, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(bala, armajugador.transform.position, armajugador.transform.rotation);
        }
        bala.transform.position += bala.transform.forward * speed;
    }
    void OnCollisionEnter()
    {
         Destroy(bala);
    }
}
