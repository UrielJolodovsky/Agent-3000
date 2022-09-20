using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadScene("SandBox");
            ChangeSceneToComputer.player.transform.position = ChangeSceneToComputer.posicionCompu;
        }
    }
    public void LoadScene(string SandBox)
    {
        SceneManager.LoadScene(SandBox);
    }
}
