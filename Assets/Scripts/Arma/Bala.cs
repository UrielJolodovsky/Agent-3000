﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float speed = 0.5f;
    public float lifetime = 2;
    public GameObject bala;
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += transform.forward * speed;
    }
    public void OnCollisionEnter(Collision collision)
    {
            Destroy(gameObject);
    }
}
