using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretaDispara : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Vector3 posJugador;
    [SerializeField] AbrirPuertaLevel3 abrirPuerta;
    [SerializeField] public bool puertaAbierta;
    [SerializeField] public bool activadas;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        puertaAbierta = false;
        abrirPuerta = GetComponent<AbrirPuertaLevel3>();
    }

    // Update is called once per frame
    void Update()
    {
        posJugador = player.transform.position;
        puertaAbierta = abrirPuerta.puertaAbierta;
        if (puertaAbierta)
        {
            activadas = true;
        }
        if (activadas)
        {
            // Funcionamiento de las torretas
            this.transform.LookAt(posJugador);
        }
    }
}
