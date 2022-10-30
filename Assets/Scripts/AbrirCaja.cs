using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class AbrirCaja : MonoBehaviour
{
    public Text cajaAbrir;
    [SerializeField] bool posibilidad;
    // Start is called before the first frame update
    void Start()
    {
        posibilidad = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (posibilidad && Input.GetKeyDown(KeyCode.E))
        {

            this.gameObject.tag = "CajaAbierta";
            this.GetComponent<Animation>().Play("Caja");
            this.GetComponent<AudioSource>().Play();
            posibilidad = false;
            cajaAbrir.enabled = false;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (this.gameObject.tag == "Caja")
            {
                cajaAbrir.enabled = true;
                posibilidad = true;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            cajaAbrir.enabled = false;
            posibilidad = false;
        }
    }
}
