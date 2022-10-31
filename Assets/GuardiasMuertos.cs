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
        if (guardiasMuertos >=6)
        {
            SceneManager.LoadScene("Derrota");
            guardiasMuertos = 0;
        }
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Final" || scene.name == "Derrota")
        {
            Destroy(gameObject);
        }
    }
}
