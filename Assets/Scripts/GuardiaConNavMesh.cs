using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.AI;

public class GuardiaConNavMesh : MonoBehaviour {
    
	[SerializeField] public float Vel = 1.5f;
    [SerializeField] public float Espera = .3f;
    [SerializeField] public float VelGiro = 90;
    [SerializeField] float tiempoVisto;
    [SerializeField] public float tiempoParaVer = .5f;

    [SerializeField] public Transform Camino;
    [SerializeField] public Light Linterna;
    [SerializeField] float DistanciaVista = 5f;
    [SerializeField] public LayerMask VerMask;
	[SerializeField] float VerAngulo;
    
    [SerializeField] Transform Jugador;
    [SerializeField] Color LinternaOriginal;
    
    [SerializeField] public Text Avistado;
    [SerializeField] public GameObject textos;
    public CharacterController controller;
	[SerializeField] GameObject player;
    [SerializeField] public GameObject Spawnpoint;

    [SerializeField] public Animator animator;
    [SerializeField] public GameObject muerte;
    [SerializeField] public GameObject robotCamina;
	[SerializeField] public BoxCollider collider1;
    [SerializeField] public CapsuleCollider collider2;

    [SerializeField] public bool muerto;
    [SerializeField] NavMeshAgent agent;
    public bool Chase;
    [SerializeField] Transform targetTransform;
    [SerializeField] Coroutine caminito;

    void Start() {

        muerto = false;
        Chase = false;
        Camino = transform.Find("Camino").transform;
        //Linterna = GameObject.Find("Linterna").GetComponent<Light>();
        Avistado = GameObject.FindGameObjectWithTag("Avistado").GetComponent<Text>();
        Avistado.enabled = false;
		Jugador = GameObject.FindGameObjectWithTag ("Player").transform;
		player = GameObject.FindGameObjectWithTag("Player");
        controller = player.GetComponent<CharacterController>();
        Spawnpoint = GameObject.FindGameObjectWithTag("SpawnPlayer");
        VerAngulo = Linterna.spotAngle;
		LinternaOriginal = Linterna.color;
        collider1 = GetComponent<BoxCollider>();
        collider2 = GetComponent<CapsuleCollider>();
        targetTransform = player.GetComponent<Transform>();
        animator.SetBool("Camina", false);
	}
	void Update() {
        if (Chase)
        {
            agent = GetComponent<NavMeshAgent>();
            agent.destination = targetTransform.position;
            animator.SetBool("Camina", true);
        }

        if (muerto)
        {
            //Destroy(gameObject);
            Linterna.enabled = false;
            muerte.SetActive(true);
            robotCamina.SetActive(false);
            collider2.enabled = false;
            collider1.enabled = false;
            Debug.Log("colision");
            StopAllCoroutines();
            Chase = false;
        }
		if (VerJugador()) 
		{
            tiempoVisto += Time.deltaTime;
            //Debug.Log(Linterna.color);
        }
		else 
		{
			tiempoVisto -= Time.deltaTime;
		}
        
		tiempoVisto = Mathf.Clamp(tiempoVisto, 0, tiempoParaVer);
        Linterna.color = Color.LerpUnclamped(LinternaOriginal, Color.red, tiempoVisto / tiempoParaVer);
		
        
		if (tiempoVisto >= tiempoParaVer)
        {
                Avistado.enabled = true;
                Time.timeScale = 0;
                textos.SetActive(false);
                //controller.enabled = false;
                if (Input.GetKeyDown(KeyCode.R))
                {
					//player.GetComponent<CharacterController>().enabled = true;
                    player.transform.position = Spawnpoint.transform.position;
                    //player.transform.eulerAngles = new Vector3 (0,0,0);
                    //player.transform.localRotation = new Quaternion.euler(0,0,0);
                    SceneManager.LoadScene("Nivel 1");
					Time.timeScale = 1;
				}
        }
    }

	bool VerJugador() {
		if (Vector3.Distance(transform.position,Jugador.position) < DistanciaVista && !muerto) {
			Vector3 DirAlJugador = (Jugador.position - transform.position).normalized;
			float AnguloGuardiayJugador = Vector3.Angle (transform.forward, DirAlJugador);
			if (AnguloGuardiayJugador < VerAngulo / 2f) {
				if (!Physics.Linecast (transform.position, Jugador.position, VerMask)) {
					return true;
				}
			}
		}
		return false;
	}
	 void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bala")
		{
            muerto = true;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!muerto)
            {
                Chase = true;
            }

        }
    }
}