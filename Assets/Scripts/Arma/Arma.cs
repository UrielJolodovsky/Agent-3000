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
    [SerializeField] int InstanciasNivel1;
    [SerializeField] int InstanciasNivel2;
    [SerializeField] int InstanciasNivel3;
    [SerializeField] EntrarAscensor ascensor;
    [SerializeField] PuntosTotales puntos;
    [SerializeField] VerificarContraseña nivelito2;
    [SerializeField] Jefe nivelito3;
    // Start is called before the first frame update
    void Start()
    {
        InstanciasNivel1 = 0;
        InstanciasNivel2 = 0;
        InstanciasNivel3 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!ascensor.isCounting)
        {
            puntos.Puntos1 += InstanciasNivel1 * 100;
        }
        if (!nivelito2.isCounting)
        {
            puntos.Puntos2 += InstanciasNivel2 * 100;
        }
        if (!nivelito3.isCounting)
        {
            puntos.Puntos3 += InstanciasNivel3 * 100;
        }
        Scene scene = SceneManager.GetActiveScene();
        if (currReloadTime > 0)
        {
            currReloadTime -= Time.deltaTime;
        }
        if (Input.GetMouseButton(0) && currReloadTime <= 0 && scene.name != "Computer")
        {
            var b = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
            b.tag = "Bala";
            b.transform.eulerAngles += new Vector3(Random.Range(-inacuracy, inacuracy), Random.Range(-inacuracy, inacuracy), Random.Range(-inacuracy, inacuracy));
            currReloadTime = reloadTime;
            if (scene.name == "Nivel 1")
            {
                InstanciasNivel1++;
            }
            else if (scene.name == "Nivel 2")
            {
                InstanciasNivel2++;
            }
            else if (scene.name == "Nivel 3")
            {
                InstanciasNivel3++;
            }
        }
        
    }
}
