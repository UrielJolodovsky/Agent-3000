using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JefeEncontrado : MonoBehaviour
{
    public Text Objetivo;
    [SerializeField] GameObject ascensor;
    public bool animacion;
    // Start is called before the first frame update
    void Start()
    {
        ascensor = GameObject.FindGameObjectWithTag("Ascensor");
        animacion = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Computador.Encontrado && !animacion)
        {
            Objetivo.enabled = false;
            ascensor.gameObject.tag = "AscensorAbierto";
            ascensor.GetComponent<Animation>().Play("AbrirPuerta");
            animacion = true;
        }
    }
}
