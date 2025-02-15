﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AbrirPuertaNets : MonoBehaviour
{
    [SerializeField] bool abrirPuerta;
    public static bool abriendoPuerta;
    [SerializeField] public Text necesitaTarjeta;
    [SerializeField] public Text presionaTecla;
    [SerializeField] public RawImage logo;
    public bool puertaAbierta;
    // Start is called before the first frame update
    void Start()
    {
        abrirPuerta = false;
        necesitaTarjeta.enabled = false;
        presionaTecla.enabled = false;
        abriendoPuerta = false;
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Final")
        {
            Destroy(gameObject);
        }
        necesitaTarjeta = GameObject.FindGameObjectWithTag("necesitaTarjeta").GetComponent<Text>();
        presionaTecla = GameObject.FindGameObjectWithTag("presionaTecla").GetComponent<Text>();
        logo = GameObject.FindGameObjectWithTag("logo").GetComponent<RawImage>();
        if (abrirPuerta && Input.GetKeyDown(KeyCode.E))
        {
            abriendoPuerta = true;
            this.GetComponent<AudioSource>().Play();
            presionaTecla.enabled = false;
            logo.enabled = false;
            puertaAbierta = true;
        }
        if (abriendoPuerta)
        {
            gameObject.transform.position += new Vector3(0.08f, 0, 0f);
        }
        if (Computador.activada)
        {
            abrirPuerta = false;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (!AgarrarLlave.tarjetaAgarrada)
            {
                necesitaTarjeta.enabled = true;
            }
            else
            {
                abrirPuerta = true;
                presionaTecla.enabled = true;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        necesitaTarjeta.enabled = false;
        abrirPuerta = false;
        presionaTecla.enabled = false;
    }
}
