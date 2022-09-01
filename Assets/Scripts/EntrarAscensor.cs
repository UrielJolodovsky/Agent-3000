using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntrarAscensor : MonoBehaviour
{
    [SerializeField] float customTime;
    [SerializeField] bool isCounting;
    public int puntosPerdidosNivel1;
    public Text nivelCompletado;
    [SerializeField] Text Counter;
    [SerializeField] float rounded;
    public Text AbrirAscensor;
    public Text Necesita;
    public AgarrarTarjeta tarjetaAgarrada;
    [SerializeField] bool AscensorAbierto;
    [SerializeField] Text entrarAscensor;
    // Start is called before the first frame update
    void Start()
    {
        nivelCompletado.enabled = false;
        isCounting = true;
        Necesita.enabled = false;
        AbrirAscensor.enabled = false;
        entrarAscensor.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting)
        {
            customTime += Time.deltaTime;
            rounded = Mathf.Round(customTime * 100f) / 100f;
            Counter.text = rounded.ToString();
        }
    }
    void OnTriggerEnter()
    {
        if (tarjetaAgarrada.tarjetaAgarrada == true && AscensorAbierto == false)
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
    void OnTriggerStay()
    {
        if (AscensorAbierto == true)
        {
            AbrirAscensor.enabled = false;
            entrarAscensor.enabled = true;
            if (Input.GetKeyDown(KeyCode.O))
            {
                entrarAscensor.enabled = false;
                isCounting = false;
                puntosPerdidosNivel1 = Mathf.FloorToInt(customTime * 10f);
                Time.timeScale = 0;
                nivelCompletado.enabled = true;
            }
        }
        if (tarjetaAgarrada.tarjetaAgarrada == true )
        {  
            if (Input.GetKeyDown(KeyCode.E))
            {
                
                Time.timeScale = 1;
                AscensorAbierto = true;
            }
        }
        else
        {
            Necesita.enabled = true;
        }
    }
    void OnTriggerExit()
    {
        Necesita.enabled = false;
        AbrirAscensor.enabled = false;
        entrarAscensor.enabled = false;
    }
}
