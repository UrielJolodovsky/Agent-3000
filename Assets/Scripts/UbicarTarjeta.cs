using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UbicarTarjeta : MonoBehaviour
{
    [SerializeField] Transform[] posTarjeta;
    [SerializeField] GameObject tarjeta;
    [SerializeField] public int num;
    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(0, 11);
        tarjeta.transform.position = posTarjeta[num].position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
