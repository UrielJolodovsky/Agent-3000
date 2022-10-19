using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntrarAscensorAnim : MonoBehaviour
{
    public Text entrarAscensor;
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
            this.GetComponent<Animation>().Play("Ascensor");
            posibilidad = false;
            entrarAscensor.enabled = false;
            this.gameObject.tag = "AscensorAbierto"; 
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (this.gameObject.tag == "Ascensor")
            {
                entrarAscensor.enabled = true;
                posibilidad = true;
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
