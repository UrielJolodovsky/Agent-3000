using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tpplayer : MonoBehaviour
{
    public Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name != "Computer")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                LoadScene("Nivel 1");
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                LoadScene("Nivel2");
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                LoadScene("Nivel 3");
            }
        }
        
    }
    public void LoadScene(string Nivel2)
    {
        SceneManager.LoadScene(Nivel2);
    }
}
