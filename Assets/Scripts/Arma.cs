using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public GameObject bala;
    public GameObject armajugador;
    float speed = 2;
    float lifetime = 2;
    public float reloadTime;
    public float inacuracy;
    float currReloadTime;
    public GameObject bullet;
    public Transform bulletSpawn = null;
    bool canShoot = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currReloadTime > 0)
        {
            currReloadTime -= Time.deltaTime;
        }
        if (Input.GetMouseButton(0) && currReloadTime <= 0)
        {
            var b = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
            b.tag = "Bala";
            b.transform.eulerAngles += new Vector3(Random.Range(-inacuracy, inacuracy), Random.Range(-inacuracy, inacuracy), Random.Range(-inacuracy, inacuracy));
            currReloadTime = reloadTime;
        }
        
    }
}
