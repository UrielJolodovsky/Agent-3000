using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene4 : MonoBehaviour
{
    public GameObject player;
    public Transform spawnpoint;
    public void LoadScene(string Nivel3)
    {
        SceneManager.LoadScene(Nivel3);
        
    }
}
