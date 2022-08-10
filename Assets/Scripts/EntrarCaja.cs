using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntrarCaja : MonoBehaviour
{
    public GameObject jugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            jugador.transform.position = gameObject.transform.position;
        }
    }
}
