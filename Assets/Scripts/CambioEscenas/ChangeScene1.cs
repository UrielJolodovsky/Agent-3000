using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class ChangeScene1 : MonoBehaviour
{
    [SerializeField] float ctime = 9.5f;
    void Update()
    {
        ctime -= Time.deltaTime;
        if (ctime <= 0)
        {
            SceneManager.LoadScene("Nivel 1");
        }
    }
    public void LoadScene(string Nivel1)
    {
        SceneManager.LoadScene(Nivel1);
    }
}