using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    //tamal la comida?  :v 
    [SerializeField] public static float customtiempo;
    [SerializeField] public static bool isCounting;
    [SerializeField] float rounded;
    public Text counter;

    // Start is called before the first frame update
    void Start()
    {
        isCounting = true;
    }

    // Update is called once per frame
    void Update()
    {
        counter = GameObject.FindGameObjectWithTag("counter").GetComponent<Text>();
        if (isCounting)
        {
            customtiempo += Time.deltaTime;
            rounded = Mathf.Round(customtiempo * 100f) / 100f; 
            counter.text = rounded.ToString();
        }
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Final" || scene.name == "Derrota")
        {
            Destroy(gameObject);
        }
    }
}
