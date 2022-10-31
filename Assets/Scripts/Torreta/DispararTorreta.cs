using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DispararTorreta : MonoBehaviour
{
    [SerializeField] float counter;
    public static bool disparar;
    public GameObject bala;
    [SerializeField] float ctime;
    public static int golpeado = 0;
    // Start is called before the first frame update
    void Start()
    {
        ctime = 2;
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
            SceneManager.LoadScene("Nivel 3");
            Time.timeScale = 1;
            Agacharse.ctime = 0.5f;
            Agacharse.deslizarsetime = 0;
            AbrirPuertaNets.abriendoPuerta = false;
            Counter.customtiempo = 0;
            Debug.Log("moriste");
            golpeado = 0;
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
