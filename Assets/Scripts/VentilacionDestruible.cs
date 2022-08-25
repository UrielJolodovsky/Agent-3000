using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentilacionDestruible : MonoBehaviour
{
    int vida = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (vida == 0)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter()
    {
        vida -= 1;
        Debug.Log("colision");
    }
}
