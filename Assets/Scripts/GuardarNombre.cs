using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuardarNombre : MonoBehaviour
{
    public static string nombreJugador;
    public InputField nombreInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(nombreInput + nombreJugador);
    }
    public void GuardarNombreJugador()
    {
        nombreJugador = nombreInput.text;
    }
}
