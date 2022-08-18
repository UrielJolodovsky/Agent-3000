using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class EntrarCajaCAM : MonoBehaviour
{
    public GameObject jugador;
    public FirstPersonController jugadorcontroller;
    public CharacterController controller;
    public GameObject caja;
    [SerializeField] Vector3 posicionjugadorcaja;
    public GameObject camCaja;
    public GameObject camJugador;


    // Start is called before the first frame update
    void Start()
    {
        CharacterController controller = jugador.GetComponent<CharacterController>();

    }

    // Update is called once per frame
    private void Update()
    {
       /* if (jugador.transform.position != caja.transform.position)
        {
            jugador.controller.enabled = true;
        }*/
        if (camCaja.gameObject.activeInHierarchy && Input.GetKeyDown(KeyCode.P))
        {
            camCaja.SetActive(false);
            jugador.SetActive(true);
            controller.enabled = true;
            camJugador.SetActive(true);
        }
        
        // 1. mover el reigidbody 2. desactivar solo lascolisiones del charactercpntroller 3. ontrigger exit vuelvaelcharacter controller
    }

    
}