using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class EntrarCaja : MonoBehaviour
{
    public GameObject jugador;
    public FirstPersonController jugadorcontroller;
    CharacterController controller;
    public GameObject caja;

    // Start is called before the first frame update
    void Start()
    {
         controller = GetComponent<CharacterController>();

    }

// Update is called once per frame
private void Update()
    {
        
    }
    void OnTriggerStay()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            jugador.transform.position = caja.transform.position;
            jugadorcontroller.CollisionFlags = 0;
            controller.enabled = !controller.enabled;
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            jugador.transform.position = new Vector3(1, 1, 5);
            controller.enabled = controller.enabled;
        }
    }
}
