using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgarrarTarjeta : MonoBehaviour
{
    public Text TeclaTarjeta;
    public GameObject tarjeta;
    [SerializeField] public bool tarjetaAgarrada;
    public Text Objetivo;
    public RawImage tarjetaPNG;
    [SerializeField] bool posibilidad;
    [SerializeField] GameObject[] cajas;
    [SerializeField] public UbicarTarjeta tarjeteando;
    [SerializeField] int num;
    [SerializeField] Text ObjetivoAscensor;
    [SerializeField] AudioSource Sonido;
    // Start is called before the first frame update
    void Start()
    {
        num = tarjeteando.num;
        TeclaTarjeta.enabled = false;
        tarjetaAgarrada = false;
        Objetivo.enabled = true;
        tarjetaPNG.enabled = false;
        posibilidad = false;
        ObjetivoAscensor.enabled = false;
        Sonido = tarjetaPNG.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (posibilidad && Input.GetKeyDown(KeyCode.Q) && cajas[num].gameObject.tag == "CajaAbierta")
        {
            TeclaTarjeta.enabled = false;
            tarjeta.SetActive(false);
            tarjetaAgarrada = true;
            Objetivo.enabled = false;
            tarjetaPNG.enabled = true;
            ObjetivoAscensor.enabled = true;
            
        }
        if (tarjetaPNG.enabled)
        {
            Sonido.Play();
        }
    }
    void OnTriggerStay(Collider other)//Collision colision)
    {
        
        if (other.gameObject.tag == "Player")
        {
            posibilidad = true;
        }
        
        Debug.Log("colision");
        //if (colision.gameObject.tag == "Player")
        //{
        if (cajas[num].gameObject.tag == "CajaAbierta")
        {
           TeclaTarjeta.enabled = true;
        }
            
        //}
    }
    void OnTriggerExit()
    {
        TeclaTarjeta.enabled = false;
        posibilidad = false;
    }
}
