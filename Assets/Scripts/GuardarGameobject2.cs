using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardarGameobject2 : MonoBehaviour
{
    public static GuardarGameobject2 posicion;
    void Awake() 
    {
        if (GuardarGameobject2.posicion == null)
        {
            GuardarGameobject2.posicion = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
