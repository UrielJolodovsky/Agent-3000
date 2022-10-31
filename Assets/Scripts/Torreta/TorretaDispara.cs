using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretaDispara : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Vector3 posJugador;
    [SerializeField] public bool puertaAbierta;
    [SerializeField] public bool activadas;
    [SerializeField] GameObject Bala1;
    [SerializeField] GameObject Bala2;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        puertaAbierta = AbrirPuertaLevel3.puertaAbierta;
        //Bala1 = gameObject.transform.Find("SalidaBala1").gameObject;
        //Bala2 = gameObject.transform.Find("SalidaBala2").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        posJugador = player.transform.position;
        puertaAbierta = AbrirPuertaLevel3.puertaAbierta;
        if (puertaAbierta)
        {
            activadas = true;
        }
        if (activadas)
        {
            Bala1.SetActive(true);
            Bala2.SetActive(true);
            gameObject.transform.LookAt(player.transform);
            // Funcionamiento de las torretas
            //var b = Instantiate(Bala1, Bala1.transform.position, Bala1.transform.rotation);
            //var c = Instantiate(Bala2, Bala2.transform.position, Bala2.transform.rotation);
        }
    }
}
