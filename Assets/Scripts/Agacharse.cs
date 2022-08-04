using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agacharse : MonoBehaviour
{
    float Altura = 1;
    float AlturaAgachado = .5f;
    float Altura2 = 1;
    float AlturaAgachado2 = .5f;
    BoxCollider colision;
    CharacterController colision3;
    // Start is called before the first frame update
    void Start()
    {
        colision = GetComponent<BoxCollider>();
        colision3 = GetComponent<CharacterController>();
        Altura = colision.size.y;
        Altura2 = colision3.height;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
            Agachate();
        else if (Input.GetKeyUp(KeyCode.LeftControl))
            Levantate();

        
    }
    void Agachate()
    {
        colision.size = new Vector3 (Altura, AlturaAgachado, Altura);
        colision3.height = AlturaAgachado2;
    }
    void Levantate()
    {
        colision.size = new Vector3 (Altura, Altura, Altura);
        colision3.height = Altura2;
    }
}
