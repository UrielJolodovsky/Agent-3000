using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntosTotales : MonoBehaviour
{
    [SerializeField] public static int Puntos1;
    [SerializeField] public static int Puntos2;
    [SerializeField] public static int Puntos3;
    [SerializeField] public static int TotalPuntos;
    [SerializeField] int[] Puntos;
    [SerializeField] string[] Name;
    [SerializeField] int index = 0;
    [SerializeField] Dictionary<int, string> ranking = new Dictionary<int, string>();
    // Start is called before the first frame update
    void Start()
    {
        TotalPuntos = Puntos1 + Puntos2 + Puntos3 + Arma.balasDisparadas*10;
        ranking.Add(TotalPuntos, GuardarNombre.nombreJugador);
        SortedDictionary<int, string>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
