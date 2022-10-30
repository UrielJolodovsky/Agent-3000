using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CooldownVisual : MonoBehaviour
{
    public Image Imagen1;
    public float cooldown1 = 7.95f;
    bool Cooldown = false;
    public KeyCode Deslizarse;
    // Start is called before the first frame update
    void Start()
    {
        Imagen1.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        deslizarse();
    }
    public void deslizarse()
    {
        if (Input.GetKey(Deslizarse) && Cooldown == false)
        {
            Cooldown = true;
            Imagen1.fillAmount = 1;
        }
        if (Cooldown) 
        {
            Imagen1.fillAmount -= 1 / cooldown1 * Time.deltaTime;
            if (Imagen1.fillAmount <= 0)
            {
                Imagen1.fillAmount = 0;
                Cooldown = false;
            }
        }
    }
}

