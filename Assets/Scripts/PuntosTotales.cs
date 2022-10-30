using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntosTotales : MonoBehaviour
{
    [SerializeField] public int Puntos1;
    [SerializeField] public int Puntos2;
    [SerializeField] public int Puntos3;
    [SerializeField] int TotalPuntos;
    // Start is called before the first frame update
    void Start()
    {
        TotalPuntos = Puntos1 + Puntos2 + Puntos3 + Arma.balasDisparadas*10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
