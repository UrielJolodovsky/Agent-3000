using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeSceneToComputer : MonoBehaviour
{
    // usar singleton para destruir nuevo player que cargue
    // jason weimann?  buenos tutoriales respecto al tema
    public static Vector3 posicionCompu;
    public Text Usar;
    public static GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;
        DontDestroyOnLoad(player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadScene(string Computer)
    {
        SceneManager.LoadScene(Computer);
    }
    void OnTriggerStay()
    {
        Usar.enabled = true;
        posicionCompu = player.transform.position;
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            LoadScene("Computer");
            if(player.activeInHierarchy == true)
            {
                
            }
        }
    }
    void OnTriggerExit()
    {
        Usar.enabled = false;
    }
}
