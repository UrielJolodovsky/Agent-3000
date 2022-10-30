using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AbrirPuertaLevel3 : MonoBehaviour
{
    [SerializeField] bool posibilidad;
    [SerializeField] static public bool puertaAbierta;
    [SerializeField] public Text abrir;
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
            puertaAbierta = true;
        }
        if (puertaAbierta)
        {
            gameObject.transform.position += new Vector3(0, 0, 0.08f);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            posibilidad = true;
            abrir.enabled = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            posibilidad = false;
            abrir.enabled = false;
        }
    }
}
