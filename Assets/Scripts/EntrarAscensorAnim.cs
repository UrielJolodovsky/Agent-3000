using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntrarAscensorAnim : MonoBehaviour
{
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
            
            posibilidad = false;
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
