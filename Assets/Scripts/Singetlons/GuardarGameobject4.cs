using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardarGameobject4 : MonoBehaviour
{
    public static GuardarGameobject4 posicion;
    void Awake() 
    {
        if (GuardarGameobject4.posicion == null)
        {
            GuardarGameobject4.posicion = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
