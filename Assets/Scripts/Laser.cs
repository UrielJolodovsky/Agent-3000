using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameObject spawnpoint;
    Vector3 posInicial = new Vector3(46.35f, 16.62f, 76.564f);
    Vector3 posFinal = new Vector3(46.35f, 14.88f, 76.564f);
    [SerializeField] string QueHacer = "Subir";
    // Start is called before the first frame update
    void Start()
    {
        QueHacer = "Subir";
    }

    // Update is called once per frame
    void Update()
    {   if (this.transform.position.y <= 14.88f)
        {
            QueHacer = "Subir";
        }
        else if(this.transform.position.y >= 16.62f)
        {
            QueHacer = "Bajar";
        }
        if (QueHacer == "Bajar") 
        {
            //transform.position = Vector3.Lerp(posFinal, posInicial, .000000000001f);
            transform.Translate(Vector3.down * Time.deltaTime);
        }
        else if (QueHacer ==  "Subir")
        {
            //transform.position = Vector3.Lerp(posInicial, posFinal, .000000000001f);
            transform.Translate(Vector3.up * Time.deltaTime);
        }

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.transform.position = new Vector3(spawnpoint.transform.position.x, spawnpoint.transform.position.y, spawnpoint.transform.position.z);
        }
    }
}
