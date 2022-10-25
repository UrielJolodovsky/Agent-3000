using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerificarContraseña : MonoBehaviour
{
    [SerializeField] InputField contrasenia;
    [SerializeField] int num;
    [SerializeField] bool abrirAscensor;
    [SerializeField] bool posibilidad;
    [SerializeField] VerificarEntryAscensor verificar;
    [SerializeField] bool estaAscensor;
    [SerializeField] float customTime;
    [SerializeField] bool isCounting;
    public int puntosPerdidosNivel2;
    [SerializeField] float rounded;
    [SerializeField] Text Counter;
    [SerializeField] public Text cerrarpuerta;
    [SerializeField] int intentos;
    // Start is called before the first frame update
    void Start()
    {
        isCounting = true;
        abrirAscensor = false;
        posibilidad = false;
        estaAscensor = false;
        intentos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        estaAscensor = verificar.entryAscensor;
        if (abrirAscensor)
        {
            this.GetComponent<Animation>().Play("AbrirPuerta");
            abrirAscensor = false;
        }
        if (this.gameObject.tag == "AscensorAbierto" && Input.GetKeyDown(KeyCode.O) && estaAscensor)
        {
            this.GetComponent<Animation>().Play("CerrarPuerta");
            isCounting = false;
            puntosPerdidosNivel2 = Mathf.FloorToInt(customTime * 10f);
            cerrarpuerta.enabled = false;
            Time.timeScale = 0;
        }
        if (isCounting)
        {
            customTime += Time.deltaTime;
            rounded = Mathf.Round(customTime * 100f) / 100f;
            Counter.text = rounded.ToString();
        }
        if (posibilidad && Input.GetKeyDown(KeyCode.E) && this.gameObject.tag == "Ascensor")
        {
            contrasenia.enabled = true;
        }
    }

    // Aceptar de la UI para el Input - Button
    void EnviarContrasenia()
    {
        if (contrasenia.text == num.ToString())
        {
            abrirAscensor = true;
        }
        else
        {
            intentos++;
        }
    }

    // La cruz de la UI para cerrar Input - Button
    void CerrarInput()
    {
        contrasenia.enabled = false; 
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            posibilidad = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            posibilidad = false;
        }
    }
}
