using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UbicarTarjeta : MonoBehaviour
{
    [SerializeField] public GameObject[] posTarjeta;
    [SerializeField] GameObject tarjeta;
    [SerializeField] public int num;
    // Start is called before the first frame update
    void Start()
    {
        asignarposicion();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void asignarposicion()
    {
        tarjeta = GameObject.FindObjectOfType<AgarrarTarjeta>().gameObject;
        posTarjeta = GameObject.FindGameObjectsWithTag("PosicionesTarjeta");
        num = Random.Range(0, 8);
        tarjeta.transform.position = posTarjeta[num].transform.position;
        Debug.Log("Ejecutando");
    }
}
