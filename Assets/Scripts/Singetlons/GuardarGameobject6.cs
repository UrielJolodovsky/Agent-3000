using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardarGameobject6 : MonoBehaviour
{
    public static GuardarGameobject6 posicion;
    void Awake() 
    {
        if (GuardarGameobject6.posicion == null)
        {
            GuardarGameobject6.posicion = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
