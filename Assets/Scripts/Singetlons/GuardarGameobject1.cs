using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardarGameobject1 : MonoBehaviour
{
    public static GuardarGameobject1 posicion;
    void Awake() 
    {
        if (GuardarGameobject1.posicion == null)
        {
            GuardarGameobject1.posicion = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
