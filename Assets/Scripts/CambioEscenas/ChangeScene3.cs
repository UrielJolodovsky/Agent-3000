using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene3 : MonoBehaviour
{
    public void LoadScene(string Nivel2)
    {
        SceneManager.LoadScene(Nivel2);
    }
}
