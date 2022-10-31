using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardarGameobject5 : MonoBehaviour
{
    public static GuardarGameobject5 posicion;
    void Awake() 
    {
        if (GuardarGameobject5.posicion == null)
        {
            GuardarGameobject5.posicion = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
