using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VidasJuego : MonoBehaviour
{
    [SerializeField] public static int cantidadVidas;
    [SerializeField] RawImage vida1;
    [SerializeField] RawImage vida2;
    [SerializeField] RawImage vida3;
    [SerializeField] RawImage vida4;
    [SerializeField] RawImage vida5;
    // Start is called before the first frame update
    void Start()
    {
        cantidadVidas = 5;
    }

    // Update is called once per frame
    void Update()
    {
        vida1 = GameObject.FindGameObjectWithTag("Vida1").GetComponent<RawImage>();
        vida2 = GameObject.FindGameObjectWithTag("Vida2").GetComponent<RawImage>();
        vida3 = GameObject.FindGameObjectWithTag("Vida3").GetComponent<RawImage>();
        vida4 = GameObject.FindGameObjectWithTag("Vida4").GetComponent<RawImage>();
        vida5 = GameObject.FindGameObjectWithTag("Vida5").GetComponent<RawImage>();
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Final" || scene.name == "Derrota")
        {
            Destroy(gameObject);
        }
        if (cantidadVidas == 0)
        {
            SceneManager.LoadScene("Derrota");
        }
        if (cantidadVidas == 5)
        {
            vida1.enabled = true;
            vida2.enabled = true;
            vida3.enabled = true;
            vida4.enabled = true;
            vida5.enabled = true;
        }
        else if (cantidadVidas == 4)
        {
            vida1.enabled = true;
            vida2.enabled = true;
            vida3.enabled = true;
            vida4.enabled = true;
            vida5.enabled = false;
        }
        else if (cantidadVidas == 3)
        {
            vida1.enabled = true;
            vida2.enabled = true;
            vida3.enabled = true;
            vida4.enabled = false;
            vida5.enabled = false;
        }
        else if (cantidadVidas == 2)
        {
            vida1.enabled = true;
            vida2.enabled = true;
            vida3.enabled = false;
            vida4.enabled = false;
            vida5.enabled = false;
        }
        else if (cantidadVidas == 1)
        {
            vida1.enabled = true;
            vida2.enabled = false;
            vida3.enabled = false;
            vida4.enabled = false;
            vida5.enabled = false;
        }
    }
}
