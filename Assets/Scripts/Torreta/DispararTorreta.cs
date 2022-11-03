using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DispararTorreta : MonoBehaviour
{
    [SerializeField] float counter;
    public static bool disparar;
    public GameObject bala;
    [SerializeField] float ctime;
    public static int golpeado = 0;
    [SerializeField] Text Avistado;
    [SerializeField] RawImage fondoavistado;
    // Start is called before the first frame update
    void Start()
    {
        ctime = 2;
        Avistado = GameObject.FindGameObjectWithTag("Avistado").GetComponent<Text>();
        Avistado.enabled = false;
        fondoavistado = GameObject.FindGameObjectWithTag("FondoAvistado").GetComponent<RawImage>();
        fondoavistado.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        ctime -= Time.deltaTime;
        if (ctime <= 0 && disparar)
        {
            // Dispara
            Debug.Log("Disparo");
            this.GetComponent<AudioSource>().Play();
            Disparar();
            ctime = 5;
        }
        if (golpeado >= 3)
        {
            fondoavistado.enabled = true;
            Avistado.enabled = true;
            Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.R))
            {
                VidasJuego.cantidadVidas -= 1;
                if (VidasJuego.cantidadVidas > 0)
                {
                    SceneManager.LoadScene("Nivel 3");
                    Time.timeScale = 1;
                    Agacharse.ctime = 0.5f;
                    Agacharse.deslizarsetime = 0;
                    AbrirPuertaNets.abriendoPuerta = false;
                    Counter.customtiempo = 0;
                    Debug.Log("moriste");
                    golpeado = 0;
                    Avistado.enabled = false;
                    fondoavistado.enabled = false;
                }
                else
                {
                    SceneManager.LoadScene("Derrota");
                    Time.timeScale = 1;
                    Agacharse.ctime = 0.5f;
                    Agacharse.deslizarsetime = 0;
                    AbrirPuertaNets.abriendoPuerta = false;
                    Counter.customtiempo = 0;
                    Debug.Log("moriste");
                    golpeado = 0;
                    Avistado.enabled = false;
                    fondoavistado.enabled = false;
                }
                
            }
        }
        







        /*if(disparar)
        {
            InvokeRepeating("Disparar", 0f, 10f);
        }*/
    }
    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            disparar = true;
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            disparar = false;
        }
    }
    //public void OnCollisionEnter(Collision collider)
    //{
    //    {
    //        if (collider.gameObject.tag == "Player")
    //        {
    //            golpeado++;
    //        }
    //    }
    //}
    void Disparar()
    {
        Instantiate(bala, transform.position, transform.rotation);
    }
}
