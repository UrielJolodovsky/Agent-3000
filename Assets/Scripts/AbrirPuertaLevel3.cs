using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuertaLevel3 : MonoBehaviour
{
    [SerializeField] bool posibilidad;
    [SerializeField] public bool puertaAbierta;
    // Start is called before the first frame update
    void Start()
    {
        posibilidad = false;
        puertaAbierta = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (posibilidad && Input.GetKeyDown(KeyCode.E))
        {
            this.GetComponent<Animation>().Play("PuertaLvl3");
            puertaAbierta = true;
        }
    }
    void OnTriggerStay(Collider other)
    {
        posibilidad = true;
    }
    void OnTriggerExit(Collider other)
    {
        posibilidad = false;
    }
}
