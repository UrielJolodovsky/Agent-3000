using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Computador : MonoBehaviour
{
    
    public GameObject Computadora;
    [SerializeField] int num;
    public GameObject volver;
    public Text cuentaContraseña;
    [SerializeField] string[] cuentas = new string[] {"345 + 749 - 321 x 2", "112 + 90 + 76 - 4 x 5","230 + 89 + 87 + 53 x 3","491 x 2 + 15","545 + 210"};
    [SerializeField] string [] resultadosCuentas = new string [] {"452", "258", "565", "997", "755"};
    public GameObject mapaJefe;
    public Text pisoJefe;
    public GameObject Pato;
    public InputField contraseniaPoner;
    public Text contraseniaEscrita;
    public Text ingresarContrasenia;
    public GameObject enviarContrasenia;
    public GameObject Encriptado;
    public Text Intentos;
    public Text informacionClasificada;

    [SerializeField] int cantidadIntentos = 0;
    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(0, 5);
        cuentaContraseña.text = cuentas[num];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Application.LoadLevel("SandBox");
            LoadScene("Sandbox");
        }
    }
    public void LoadScene(string Sandbox)
    {
        SceneManager.LoadScene(Sandbox);
    }
    public void contraseniaAscensor()
    {
        Computadora.SetActive(false);
        volver.SetActive(true);
        cuentaContraseña.enabled = true;

    }
    public void MainScreen()
    {
        Computadora.SetActive(true);
        volver.SetActive(false);
        cuentaContraseña.enabled = false;
        pisoJefe.enabled = false;
        mapaJefe.SetActive(false);
        Pato.SetActive(false);
        Encriptado.SetActive(false);
        Intentos.enabled = false;
        informacionClasificada.enabled = false;
    }
    public void LocalizacionJefe()
    {
        Computadora.SetActive(false);
        volver.SetActive(true);
        pisoJefe.enabled = true;
        mapaJefe.SetActive(true);
    }
    public void FotoAmenaza()
    {
        Computadora.SetActive(false);
        volver.SetActive(true);
        Pato.SetActive(true);
    }
    public void InformacionClasificada()
    {
        Computadora.SetActive(false);
        Encriptado.SetActive(true);
        volver.SetActive(true);
    }
    public void VerificarContrasenia()
    {
        if (contraseniaEscrita.text == resultadosCuentas[num])
        {
            Debug.Log("Contraseña correcta");
            Encriptado.SetActive(false);
            informacionClasificada.enabled = true;
        }
        else
        {
            Debug.Log("Contraseña incorrecta");
            cantidadIntentos++;
        }
        if (cantidadIntentos >= 5)
        {
            contraseniaPoner.enabled = false;
            enviarContrasenia.SetActive(false);
            Intentos.enabled = true;
        }
    }

}
