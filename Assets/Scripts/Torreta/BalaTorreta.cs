using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class BalaTorreta : MonoBehaviour
{
    public float speed = 0.00000000005f;
    public float lifetime = 2;

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
    public void OnCollisionEnter(Collision collider)
    {
        {
            if (collider.gameObject.tag == "Player")
            {
                DispararTorreta.golpeado++;
                Debug.Log("hit");
            }
        }
    }
}