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
    [SerializeField] GameObject Bala1;
    [SerializeField] GameObject Bala2;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        puertaAbierta = false;
        abrirPuerta = GetComponent<AbrirPuertaLevel3>();
        Bala1 = this.transform.Find("SalidaBala1").gameObject;
        Bala2 = this.transform.Find("SalidaBala2").gameObject;
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
