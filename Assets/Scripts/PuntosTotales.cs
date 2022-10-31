using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntosTotales : MonoBehaviour
{
    [SerializeField] public static int Puntos1;
    [SerializeField] public static int Puntos2;
    [SerializeField] public static int Puntos3;
    [SerializeField] public static int TotalPuntos;
    [SerializeField] int[] Puntos;
    [SerializeField] string[] Name;
    [SerializeField] int[] Puntos5;
    [SerializeField] string[] Name1;
    [SerializeField] int index = 0;
    [SerializeField] Dictionary<int, string> ranking = new Dictionary<int, string>();
    public Text name1;
    public Text name2;
    public Text name3;
    public Text name4;
    public Text name5;
    public Text puntos1;
    public Text puntos2;
    public Text puntos3;
    public Text puntos4;
    public Text puntos5;
    public int index1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        TotalPuntos = 100000 - (Puntos1 + Puntos2 + Puntos3 + Arma.balasDisparadas * 10);
        Puntos[index1 + 1] = 100000 - TotalPuntos;
        Name[index1 + 1] = GuardarNombre.nombreJugador;
        index1++;
        for (int i = 0; i < Puntos.Length; i++)
        {
            int maximo = 0;
            if (Puntos[i] > maximo)
            {
                maximo = Puntos[i];
                index = i;
            }
        }
       Puntos5[0] = Puntos[index];
        Name1[0] = Name1[index];
        Puntos[index] = 0;
        Name[index] = "";
        for (int i = 0; i < Puntos.Length; i++)
        {
            int maximo = 0;
            if (Puntos[i] > maximo)
            {
                maximo = Puntos[i];
                index = i;
            }
        }
        Puntos5[1] = Puntos[index];
        Name1[1] = Name1[index];
        Puntos[index] = 0;
        Name[index] = "";
        for (int i = 0; i < Puntos.Length; i++)
        {
            int maximo = 0;
            if (Puntos[i] > maximo)
            {
                maximo = Puntos[i];
                index = i;
            }
        }
        Puntos5[2] = Puntos[index];
        Name1[2] = Name1[index];
        Puntos[index] = 0;
        Name[index] = "";
        for (int i = 0; i < Puntos.Length; i++)
        {
            int maximo = 0;
            if (Puntos[i] > maximo)
            {
                maximo = Puntos[i];
                index = i;
            }
        }
        Puntos5[3] = Puntos[index];
        Name1[3] = Name1[index];
        Puntos[index] = 0;
        Name[index] = "";
        for (int i = 0; i < Puntos.Length; i++)
        {
            int maximo = 0;
            if (Puntos[i] > maximo)
            {
                maximo = Puntos[i];
                index = i;
            }
        }
        Puntos5[4] = Puntos[index];
        Name1[4] = Name1[index];
        Puntos[index] = 0;
        Name[index] = "";
        for (int i = 0; i < Puntos.Length; i++)
        {
            int maximo = 0;
            if (Puntos[i] > maximo)
            {
                maximo = Puntos[i];
                index = i;
            }
        }
        Puntos5[5] = Puntos[index];
        Name1[5] = Name1[index];
        Puntos[index] = 0;
        Name[index] = "";

        name1.text = Name1[0].ToString();
        name2.text = Name1[1].ToString();
        name3.text = Name1[2].ToString();
        name4.text = Name1[3].ToString();
        name5.text = Name1[4].ToString();
        puntos1.text = Puntos5[0].ToString();
        puntos2.text = Puntos5[1].ToString();
        puntos3.text = Puntos5[2].ToString();
        puntos4.text = Puntos5[3].ToString();
        puntos5.text = Puntos5[4].ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
