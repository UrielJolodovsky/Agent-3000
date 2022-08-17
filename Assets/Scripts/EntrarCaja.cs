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
    [SerializeField] Vector3 posicionjugadorcaja;
    

    // Start is called before the first frame update
    void Start()
    {
         controller = GetComponent<CharacterController>();
         controller.stepOffset = 100;

    }

// Update is called once per frame
private void Update()
    {
        if (jugador.transform.position != caja.transform.position)
        {
            controller.enabled = controller.enabled;
        }
        // 1. mover el reigidbody 2. desactivar solo lascolisiones del charactercpntroller 3. ontrigger exit vuelvaelcharacter controller
    }   

    void OnTriggerStay()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            posicionjugadorcaja = new Vector3(jugador.transform.position.x, jugador.transform.position.y, jugador.transform.position.z);
            jugador.transform.position = caja.transform.position;
            jugadorcontroller.CollisionFlags = 0;
            controller.stepOffset = 100;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            jugador.transform.position = posicionjugadorcaja;
            //controller.enabled = controller.enabled;
            controller.stepOffset = 0.3f;
        }
        
    }
}
