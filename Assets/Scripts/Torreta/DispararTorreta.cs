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
    // Start is called before the first frame update
    void Start()
    {
        ctime = 2;
        Avistado.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        ctime -= Time.deltaTime;
        if (ctime <= 0 && disparar)
        {
            // Dispara
            Debug.Log("Disparo");
            Disparar();
            ctime = 5;
        }
        if (golpeado >= 5)
        {
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
