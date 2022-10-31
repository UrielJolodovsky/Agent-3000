using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    [SerializeField] public static int balasDisparadas;
    // Start is called before the first frame update
    void Start()
    {

        balasDisparadas = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (currReloadTime > 0)
        {
            currReloadTime -= Time.deltaTime;
        }
        if (Input.GetMouseButton(0) && currReloadTime <= 0 && scene.name != "Computer" && scene.name != "Carga1" && scene.name != "Carga2" && scene.name != "Final" && scene.name != "Derrota" )
        {
            var b = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
            b.tag = "Bala";
            b.transform.eulerAngles += new Vector3(Random.Range(-inacuracy, inacuracy), Random.Range(-inacuracy, inacuracy), Random.Range(-inacuracy, inacuracy));
            currReloadTime = reloadTime;
            balasDisparadas++;
            this.GetComponent<AudioSource>().Play();
        }
        
    }
}
