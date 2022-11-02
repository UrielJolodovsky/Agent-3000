using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CajaTorretas : MonoBehaviour
{
    [SerializeField] bool posibilidad;
    public Text AbrirCaja;
    public bool desactivar;
    public Text apagar;
    // Start is called before the first frame update
    void Start()
    {
        posibilidad = false;
        AbrirCaja = GameObject.FindGameObjectWithTag("AbrirCaja").GetComponent<Text>();
        apagar = GameObject.FindGameObjectWithTag("ApagarTorretas").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (posibilidad && Input.GetKeyDown(KeyCode.E) )
        {
            this.GetComponent<Animation>().Play("AbrirCajaTorretas");
            AbrirCaja.enabled = false;
            this.gameObject.tag = "CajaAbierta";
        }
        if (this.gameObject.tag == "CajaAbierta" && Input.GetKeyDown(KeyCode.Q))
        {
            DispararTorreta.disparar = false;
            apagar.enabled = false;
            this.GetComponent<AudioSource>().Play();
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && gameObject.tag != "CajaAbierta")
        {
            posibilidad = true;
            AbrirCaja.enabled = true;
        }
        else if(other.gameObject.tag == "Player" && gameObject.tag == "CajaAbierta")
        {
            if (DispararTorreta.disparar == true)
            {
                apagar.enabled = true;
            }
        
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
