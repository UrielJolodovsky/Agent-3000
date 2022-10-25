using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificarEntryAscensor : MonoBehaviour
{
    [SerializeField] public bool entryAscensor;
    [SerializeField] GameObject ascensor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && ascensor.gameObject.tag == "AscensorAbierto")
        {
            entryAscensor = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            entryAscensor = false;
        }
    }
}
