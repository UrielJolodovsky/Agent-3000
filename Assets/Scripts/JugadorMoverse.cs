using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class JugadorMoverse : MonoBehaviour
{
    // Start is called before the first frame update
    public FirstPersonController jugador;
    public CharacterController controller;
    void Awake()
    {
        controller.enabled = true;
        jugador.m_MouseLook.XSensitivity = 2;
        jugador.m_MouseLook.YSensitivity = 2;
    }
}
