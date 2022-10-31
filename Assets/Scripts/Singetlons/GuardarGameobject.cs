using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardarGameobject : MonoBehaviour
{
    public static GuardarGameobject posicion;
    void Awake() 
    {
        if (GuardarGameobject.posicion == null)
        {
            GuardarGameobject.posicion = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
