using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class EntrarCajaCAM : MonoBehaviour
{
    public GameObject jugador;
    public FirstPersonController jugadorController;
    public CharacterController controller;
    public GameObject caja;
    [SerializeField] Vector3 posicionjugadorcaja;
    public GameObject camCaja;
    public GameObject camJugador;
    public Text Entrar;
    public Text Salir;


    // Start is called before the first frame update
    void Start()
    {
        jugadorController = jugador.GetComponent<FirstPersonController>();
        Salir.enabled = false;
        jugador = GameObject.FindGameObjectWithTag("Player");
        CharacterController controller = jugador.GetComponent<CharacterController>();
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (camCaja.gameObject.activeInHierarchy)
        {
            Salir.enabled = true;
        }
         if (camCaja.gameObject.activeInHierarchy && Input.GetKeyDown(KeyCode.P))
        {
            camCaja.SetActive(false);
            jugador.SetActive(true);
            controller.enabled = true;
            camJugador.SetActive(true);
            Salir.enabled = false;
            Entrar.enabled = true;
        }
        
        // 1. mover el reigidbody 2. desactivar solo lascolisiones del charactercpntroller 3. ontrigger exit vuelvaelcharacter controller
    }

    
}