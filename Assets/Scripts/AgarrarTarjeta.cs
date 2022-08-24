using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgarrarTarjeta : MonoBehaviour
{
    public Text TeclaTarjeta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collision colision)
    {
        TeclaTarjeta.enabled = true;

        if (colision.gameObject.tag == "Player")
        {

        }
    }
}
