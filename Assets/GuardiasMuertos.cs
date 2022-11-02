using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GuardiasMuertos : MonoBehaviour
{
    [SerializeField] public static int guardiasMuertos;
    [SerializeField] Text guardiasDeath;
    // Start is called before the first frame update
    void Start()
    {
        guardiasMuertos = 0;
        guardiasDeath = GameObject.FindGameObjectWithTag("GuardiasDeath").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        guardiasDeath.text = guardiasMuertos.ToString();
        if (guardiasMuertos >=8)
        {
            SceneManager.LoadScene("Derrota");
            guardiasMuertos = 0;
            VidasJuego.cantidadVidas = 5;
        }
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Final" || scene.name == "Derrota")
        {
            Destroy(gameObject);
        }
    }
}
