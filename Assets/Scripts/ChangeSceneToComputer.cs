using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class ChangeSceneToComputer : MonoBehaviour
{
    public CharacterController controller;
    public FirstPersonController jugador;
    public GameObject player;
    public Text Usar;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;
        player = GameObject.FindGameObjectWithTag("Player");
        controller = player.GetComponent<CharacterController>();
        jugador = player.GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadScene(string Computer)
    {
        controller.enabled = false;
        jugador.m_MouseLook.XSensitivity = 0;
        jugador.m_MouseLook.YSensitivity = 0;
        SceneManager.LoadScene(Computer);
    }
void OnTriggerStay(Collider other)
    {
        Usar.enabled = true;
        if (Input.GetKeyDown(KeyCode.E) && other.gameObject.tag == "Player")
        {
            LoadScene("Computer");
        }
    }
    void OnTriggerExit()
    {
        Usar.enabled = false;
    }
}
