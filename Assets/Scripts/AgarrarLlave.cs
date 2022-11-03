using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgarrarLlave : MonoBehaviour
{
    [SerializeField] bool posibilidad;
    [SerializeField] public static bool tarjetaAgarrada;
    [SerializeField] GameObject llave;
    [SerializeField] public Text agarrarLlave;
    [SerializeField] public RawImage logo;
    [SerializeField] public Text OBJLlave;
    [SerializeField] public Text OBJAscensor;
    // Start is called before the first frame update
    void Start()
    {
        tarjetaAgarrada = false;
        posibilidad = false;
       // llave = GameObject.FindObjectOfType<AgarrarLlave>().gameObject;
        agarrarLlave.enabled = false;
        logo.enabled = false;
        OBJLlave.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (posibilidad && Input.GetKeyDown(KeyCode.E))
        {
            tarjetaAgarrada = true;
            gameObject.SetActive(false);
            agarrarLlave.enabled = false;
            logo.enabled = true;
            OBJLlave.enabled = false;
            OBJAscensor.enabled = true;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (!tarjetaAgarrada)
            {
                posibilidad = true;
                agarrarLlave.enabled = true;
            }
            
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            posibilidad = false;
            agarrarLlave.enabled = false;
        }
    }
}
