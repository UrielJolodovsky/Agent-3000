using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    float speed = 2;
    float lifetime = 2;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this);
    }
}
