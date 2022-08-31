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
    // Start is called before the first frame update
    void Start()
    {
        TeclaTarjeta.enabled = false;
        tarjetaAgarrada = false;
        Objetivo.enabled = true;
        tarjetaPNG.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay()//Collision colision)
    {

        Debug.Log("colision");
        //if (colision.gameObject.tag == "Player")
        //{
            TeclaTarjeta.enabled = true;
            if(Input.GetKeyDown(KeyCode.E))
            {
                TeclaTarjeta.enabled = false;
                tarjeta.SetActive(false);
                tarjetaAgarrada = true;
                Objetivo.enabled = false;
                tarjetaPNG.enabled = true;
        }
        //}
    }
    void OnTriggerExit()
    {
        TeclaTarjeta.enabled = false;
    }
}
