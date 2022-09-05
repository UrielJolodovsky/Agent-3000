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
    [SerializeField] string[] cuentas = new string[5] {"345 + 749 - 321 x 2", "112 + 90 + 76 - 4 x 5","230 + 89 + 87 + 53 x 3","491 x 2 + 15","545 + 210"};
    [SerializeField] int[] resultadosCuentas = new int [5]{ 452, 258, 565, 997, 755};
    public GameObject mapaJefe;
    public Text pisoJefe;
    public GameObject Pato;
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

}
