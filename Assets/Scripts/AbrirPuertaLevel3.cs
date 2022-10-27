using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuertaLevel3 : MonoBehaviour
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
            this.GetComponent<Animation>().Play();
        }
    }
    void OnTriggerStay(Collider other)
    {
        posibilidad = true;
    }
}
