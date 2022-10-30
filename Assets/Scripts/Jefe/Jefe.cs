using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jefe : MonoBehaviour
{
    public GameObject puertaJefe;
    [SerializeField] public bool isCounting;
    [SerializeField] Text Counter;
    [SerializeField] float rounded;
    [SerializeField] float customTime;
    [SerializeField] int puntosPerdidosNivel3;
    // Start is called before the first frame update
    void Start()
    {
        isCounting = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting)
        {
            customTime += Time.deltaTime;
            rounded = Mathf.Round(customTime * 100f) / 100f;
            // Counter.text = rounded.ToString();
        }
    }
   public void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.tag == "Player")
        {
            puertaJefe.SetActive(true);
        }
    }
    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Bala")
        {
            isCounting = false;
            puntosPerdidosNivel3 = Mathf.FloorToInt(customTime * 10f);
            PuntosTotales.Puntos3 += puntosPerdidosNivel3;
            LoadScene("Final");
        }
    }
    public void LoadScene(string Final)
    {
        SceneManager.LoadScene(Final);
    }
}
