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
    public float time = .5f;
    public float ctime;
    public float rotationSpeed = 0;
    [SerializeField] float deslizarsetime;
    // Start is called before the first frame update


    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        colision = GetComponent<BoxCollider>();
        colision3 = GetComponent<CharacterController>();
        Altura = colision.size.y;
        Altura2 = colision3.height;
        deslizarsetime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        deslizarsetime -= Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftControl))
            Agachate();
        if (Input.GetKey(KeyCode.LeftShift) && ctime <= 0)
        {
            Levantate();
        }
        else if (Input.GetKey(KeyCode.LeftShift) && deslizarsetime <= 0)
        {
            Deslizate();
            ctime -= Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftShift) && deslizarsetime > 0)
        {
            Debug.Log("Esperá");
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Levantate();
            ctime = .5f;
            deslizarsetime = 10;
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            Levantate();
        }
    }
   private void Agachate()
    {
        colision.size = new Vector3 (Altura, AlturaAgachado, Altura);
        colision3.height = AlturaAgachado2;
        jugador.m_WalkSpeed = 2f;
        m_rigidbody.constraints = RigidbodyConstraints.None;
        jugador.m_MouseLook.XSensitivity = 2;
        jugador.m_MouseLook.YSensitivity = 2;
    }
    private void Levantate()
    {
        colision.size = new Vector3 (Altura, Altura, Altura);
        colision3.height = Altura2;
        jugador.m_WalkSpeed = 5f;
        m_rigidbody.constraints = RigidbodyConstraints.None;
        jugador.m_MouseLook.XSensitivity = 2;
        jugador.m_MouseLook.YSensitivity = 2;
    }

    private void Deslizate()
    {
        colision.size = new Vector3(Altura, AlturaAgachado, Altura);
        colision3.height = AlturaAgachado2;
        jugador.m_WalkSpeed = 15f;
        jugador.m_MouseLook.XSensitivity = 0;
        jugador.m_MouseLook.YSensitivity = 0;
        m_rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
    }
}
