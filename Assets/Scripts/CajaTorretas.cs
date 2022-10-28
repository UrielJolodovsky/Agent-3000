using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaTorretas : MonoBehaviour
{
    [SerializeField] bool posibilidad;
    [SerializeField] public bool torretasDeshabilitadas;
    // Start is called before the first frame update
    void Start()
    {
        posibilidad = false;
        torretasDeshabilitadas = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (posibilidad && Input.GetKeyDown(KeyCode.E))
        {
            this.GetComponent<Animation>().Play("AbrirCajaTorretas");
        }
        if (this.gameObject.tag == "CajaAbierta" && Input.GetKeyDown(KeyCode.Q))
        {
            torretasDeshabilitadas = true;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            posibilidad = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            posibilidad = false;
        }
    }
}
