using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntrarAscensor : MonoBehaviour
{
    [SerializeField] float customTime;
    [SerializeField] bool isCounting;
    public int puntosPerdidosNivel1;
    public Text nivelCompletado;
    [SerializeField] Text Counter;
    [SerializeField] float rounded;
    // Start is called before the first frame update
    void Start()
    {
        nivelCompletado.enabled = false;
        isCounting = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting)
        {
            customTime += Time.deltaTime;
            rounded = Mathf.Round(customTime * 100f) / 100f;
            Counter.text = rounded.ToString();
        }
    }
    void OnTriggerEnter()
    {
        isCounting = false;
        puntosPerdidosNivel1 = Mathf.FloorToInt(customTime * 10f);
        Time.timeScale = 0;
        nivelCompletado.enabled = true; 
    }

}
