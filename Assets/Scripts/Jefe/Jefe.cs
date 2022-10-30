using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jefe : MonoBehaviour
{
    public GameObject puertaJefe;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
            LoadScene("Final");
        }
    }
    public void LoadScene(string Final)
    {
        SceneManager.LoadScene(Final);
    }
}
