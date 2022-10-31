using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;
using UnityEngine.UI;

public class Laser : MonoBehaviour
{
    public GameObject spawnpoint;
    Vector3 posInicial = new Vector3(46.35f, 16.62f, 76.564f);
    Vector3 posFinal = new Vector3(46.35f, 14.88f, 76.564f);
    [SerializeField] string QueHacer = "Subir";
    [SerializeField] public static bool visto;
    [SerializeField] public Text Avistado;
    [SerializeField] GameObject player;
    public bool activado = false;

    // Start is called before the first frame update
    void Start()
    {
        QueHacer = "Subir";
        player = GameObject.FindGameObjectWithTag("Player");
        Avistado = GameObject.FindGameObjectWithTag("Avistado").GetComponent<Text>();
        spawnpoint = GameObject.FindGameObjectWithTag("SpawnPlayer");
    }

    // Update is called once per frame
    void Update()
    {   if (this.transform.position.y <= 14.88f)
        {
            QueHacer = "Subir";
        }
        else if(this.transform.position.y >= 16.62f)
        {
            QueHacer = "Bajar";
        }
        if (QueHacer == "Bajar") 
        {
            //transform.position = Vector3.Lerp(posFinal, posInicial, .000000000001f);
            transform.Translate(Vector3.down * Time.deltaTime);
        }
        else if (QueHacer ==  "Subir")
        {
            //transform.position = Vector3.Lerp(posInicial, posFinal, .000000000001f);
            transform.Translate(Vector3.up * Time.deltaTime);
        }
        if (activado)
        {
            Avistado.enabled = true;
            Time.timeScale = 0;
            //controller.enabled = false;
            visto = true;
            if (Input.GetKeyDown(KeyCode.R))
            {
                //player.GetComponent<CharacterController>().enabled = true;
                player.transform.position = spawnpoint.transform.position;
                //player.transform.eulerAngles = new Vector3 (0,0,0);
                //player.transform.localRotation = new Quaternion.euler(0,0,0);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
                Agacharse.ctime = 0.5f;
                Agacharse.deslizarsetime = 0;
                Avistado.enabled = false;
                AbrirPuertaNets.abriendoPuerta = false;
                Counter.customtiempo = 0;
            }

        }
    }
        void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            
            //col.transform.position = new Vector3(spawnpoint.transform.position.x, spawnpoint.transform.position.y, spawnpoint.transform.position.z);
            activado = true;
            
        }
    }
}
