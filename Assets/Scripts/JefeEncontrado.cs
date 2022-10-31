using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JefeEncontrado : MonoBehaviour
{
    public Text Objetivo;
    [SerializeField] GameObject ascensor;
    // Start is called before the first frame update
    void Start()
    {
        ascensor = GameObject.FindGameObjectWithTag("Ascensor");
    }

    // Update is called once per frame
    void Update()
    {
        if (Computador.Encontrado)
        {
            Objetivo.enabled = false;
            ascensor.gameObject.tag = "AscensorAbierto";
            ascensor.GetComponent<Animation>().Play("AbrirPuerta");
        }
    }
}
