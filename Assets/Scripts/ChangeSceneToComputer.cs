using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeSceneToComputer : MonoBehaviour
{
    public Text Usar;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
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
        if (Input.GetKeyDown(KeyCode.E))
        {
            LoadScene("Computer");
        }
    }
    void OnTriggerExit()
    {
        Usar.enabled = false;
    }
}
