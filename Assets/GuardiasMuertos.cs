using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuardiasMuertos : MonoBehaviour
{
    [SerializeField] public static int guardiasMuertos;
    // Start is called before the first frame update
    void Start()
    {
        guardiasMuertos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (guardiasMuertos >=10)
        {
            SceneManager.LoadScene("Derrota");
        }
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Computer" || scene.name == "Carga1" || scene.name == "Carga2" || scene.name == "Final" || scene.name == "Ranking" || scene.name == "Derrota")
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
