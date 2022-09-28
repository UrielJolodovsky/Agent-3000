using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class ChangeScene2 : MonoBehaviour
{
    public FirstPersonController jugador;
    public CharacterController controller;
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        player = GameObject.FindGameObjectWithTag("Player");
        controller = player.GetComponent<CharacterController>();
        jugador = player.GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadScene("SandBox");
            controller.enabled = true;
            jugador.m_MouseLook.XSensitivity = 2;
            jugador.m_MouseLook.YSensitivity = 2;
        }
    }
    public void LoadScene(string SandBox)
    {
        SceneManager.LoadScene(SandBox);
    }
}
