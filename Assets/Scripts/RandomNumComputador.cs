using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumComputador : MonoBehaviour
{
    public static int num;
    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(0, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
