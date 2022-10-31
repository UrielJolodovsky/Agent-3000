using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tpplayernivel3 : MonoBehaviour
{
    public GameObject player;
    public Transform spawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        spawnpoint = GameObject.FindGameObjectWithTag("SpawnPlayer").GetComponent<Transform>();
        player.transform.position = spawnpoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
