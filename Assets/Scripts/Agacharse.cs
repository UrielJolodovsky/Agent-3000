using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Agacharse : MonoBehaviour
{
    float Altura = 1;
    float AlturaAgachado = .5f;
    float Altura2 = 1;
    float AlturaAgachado2 = .5f;
    BoxCollider colision;
    CharacterController colision3;
    public FirstPersonController jugador;
    private bool SlideDebounce;
    private int TimeStamp;
    Rigidbody m_rigidbody;
    public float time;
    public float ctime;
    // Start is called before the first frame update


    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        colision = GetComponent<BoxCollider>();
        colision3 = GetComponent<CharacterController>();
        Altura = colision.size.y;
        Altura2 = colision3.height;
    }

    // Update is called once per frame
    void Update()
    {
        ctime -= Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftControl))
            Agachate();
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            Deslizate();
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
            Levantate();
        

    }
   private void Agachate()
    {
        colision.size = new Vector3 (Altura, AlturaAgachado, Altura);
        colision3.height = AlturaAgachado2;
        jugador.m_RunSpeed = 10f;
        m_rigidbody.constraints = RigidbodyConstraints.None;
    }
    private void Levantate()
    {
        colision.size = new Vector3 (Altura, Altura, Altura);
        colision3.height = Altura2;
        jugador.m_RunSpeed = 10f;
        m_rigidbody.constraints = RigidbodyConstraints.None;
    }

    private void Deslizate()
    {
        
        if(ctime > 0)
        {
        colision.size = new Vector3(Altura, AlturaAgachado, Altura);
        colision3.height = AlturaAgachado2;
        jugador.m_RunSpeed = 15f;
        m_rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        }
        else if(ctime < 0)
        {
            ctime = time;
            Levantate();
        }   
        
    }
}
