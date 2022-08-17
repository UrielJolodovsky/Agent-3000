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
    public GameObject camCaja;
    public GameObject camJugador;
    

    // Start is called before the first frame update
    void Start()
    {
         controller = GetComponent<CharacterController>();
         

    }

// Update is called once per frame
private void Update()
    {
        if (jugador.transform.position != caja.transform.position)
        {
            controller.enabled = controller.enabled;
        }
        if (Input.GetKey(KeyCode.I))
        {
            jugador.transform.Translate(Vector3.forward * 0.2f);
        }
            // 1. mover el reigidbody 2. desactivar solo lascolisiones del charactercpntroller 3. ontrigger exit vuelvaelcharacter controller
        }   

    void OnTriggerStay(Collision col)
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {

            /*posicionjugadorcaja = new Vector3(jugador.transform.position.x, jugador.transform.position.y, jugador.transform.position.z);
            jugador.transform.position = caja.transform.position;
            jugadorcontroller.CollisionFlags = 0;*/
            controller.enabled = false;
            jugador.SetActive(false);
            camCaja.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            //StartCoroutine("Teleport");
            /*jugador.transform.position = posicionjugadorcaja;
            //controller.enabled = controller.enabled;
            controller.stepOffset = 0.3f;*/
            Debug.Log("P");
            controller.enabled = true;
            camCaja.SetActive(false);
            jugador.SetActive(true);
        }
        
    }
    IEnumerator Teleport()
    {
        /*controller.enabled = !controller.enabled;
        posicionjugadorcaja = new Vector3(jugador.transform.position.x, jugador.transform.position.y, jugador.transform.position.z);
        jugador.transform.position = caja.transform.position;
        yield return new WaitForSeconds(1f);
        controller.enabled = controller.enabled;*/
        controller.enabled = true;
        yield return new WaitForSeconds(1f);
        jugador.transform.position = posicionjugadorcaja;
        
    }
}
