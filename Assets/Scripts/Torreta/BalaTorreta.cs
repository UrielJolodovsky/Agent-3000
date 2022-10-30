using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class BalaTorreta : MonoBehaviour
{
    public float speed = 0.00000000005f;
    public float lifetime = 1;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Vector3.forward, speed);
    }
   
}