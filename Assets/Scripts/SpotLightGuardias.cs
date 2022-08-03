using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightGuardias : MonoBehaviour
{
    public GameObject jugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, jugador.transform.position);
        Debug.DrawRay(transform.position, jugador.transform.position);

    }
}
