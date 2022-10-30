using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EntrarAscensor : MonoBehaviour
{
    [SerializeField] float customTime;
    [SerializeField] public bool isCounting;
    public int puntosPerdidosNivel1;
    public Text nivelCompletado;
    [SerializeField] Text Counter;
    [SerializeField] float rounded;
    public Text AbrirAscensor;
    public Text Necesita;
    public AgarrarTarjeta tarjetaAgarrada;
    [SerializeField] bool AscensorAbierto;
    [SerializeField] Text entrarAscensor;
    [SerializeField] bool posibilidadAbrir;
    public GameObject tarjeta;
    [SerializeField] Animation animacion;
    [SerializeField] VerificarEntryAscensor verificar;
    [SerializeField] bool estaAscensor;
    public CharacterController controller;
    [SerializeField] public BoxCollider collider2;
    [SerializeField] PuntosTotales puntos;
    // Start is called before the first frame update
    void Start()
    {
        nivelCompletado.enabled = false;
        isCounting = true;
        posibilidadAbrir = false;
        Necesita.enabled = false;
        AbrirAscensor.enabled = false;
        entrarAscensor.enabled = false;
        posibilidadAbrir = false;
        animacion = GetComponent<Animation>();
        collider2 = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        estaAscensor = verificar.entryAscensor;
        if (posibilidadAbrir && Input.GetKeyDown(KeyCode.E))
        {
            AscensorAbierto = true;
            Time.timeScale = 1;
            posibilidadAbrir = false;
            animacion.Play("AbrirPuertaLevel1");
            this.gameObject.tag = "AscensorAbierto";
        }
        if (AscensorAbierto && Input.GetKeyDown(KeyCode.O) && estaAscensor)
        {
            entrarAscensor.enabled = false;
            isCounting = false;
            puntosPerdidosNivel1 = Mathf.FloorToInt(customTime * 10f);
            puntos.Puntos1 = puntosPerdidosNivel1;
            Time.timeScale = 0;
            nivelCompletado.enabled = true;
            animacion.Play("CerrarPuerta");
            LoadScene("Carga1");
            
        }
        if (isCounting)
        {
            customTime += Time.deltaTime;
            rounded = Mathf.Round(customTime * 100f) / 100f;
            Counter.text = rounded.ToString();
        }
        if (AscensorAbierto)
        {
            AbrirAscensor.enabled = false;
            collider2.enabled = false;
        }
    }
    void OnTriggerEnter()
    {
        if (tarjeta.activeInHierarchy == false && AscensorAbierto == false)
        {
            AbrirAscensor.enabled = true;
        }
        /* if (AscensorAbierto == true)
         {
             if (Input.GetKeyDown(KeyCode.E))
             {
                 isCounting = false;
                 puntosPerdidosNivel1 = Mathf.FloorToInt(customTime * 10f);
                 Time.timeScale = 0;
                 nivelCompletado.enabled = true; 
             }
         }*/
    }
    void OnTriggerStay(Collider other)
    {
        if (tarjeta.activeInHierarchy == false && !AscensorAbierto && other.gameObject.tag == "Player")
        {
            posibilidadAbrir = true;
        }
        else if (tarjeta.activeInHierarchy && other.gameObject.tag == "Player")
        {
            Necesita.enabled = true;
        }
    }
    void OnTriggerExit()
    {
        Necesita.enabled = false;
        AbrirAscensor.enabled = false;
        entrarAscensor.enabled = false;
        posibilidadAbrir = false;
    }
    public void LoadScene(string Carga1)
    {
        //controller.enabled = false;
        SceneManager.LoadScene(Carga1);
        //Cursor.visible = true;
        //Cursor.lockState = CursorLockMode.Locked;
    }
}
