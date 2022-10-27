using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionPlayer : MonoBehaviour
{
    public GameObject jugador;
    public GameObject spawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        jugador.transform.position = new Vector3(spawnpoint.transform.position.x, spawnpoint.transform.position.y, spawnpoint.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
