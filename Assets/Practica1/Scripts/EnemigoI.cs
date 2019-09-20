using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemigoI : MonoBehaviour
{
    
    public Slider[] barras;
    
    CrearEnemigo enemigo;
    // Start is called before the first frame update
    public void enemigoI()
    {
        enemigo = GetComponentInParent<CrearEnemigo>();
     
        //barras = new Slider[2];

        
        barras = GetComponentsInChildren<Slider>();
        

        barras[0].maxValue = enemigo.vida;
        barras[0].value = enemigo.vida;
        if (barras[0].maxValue == 0)
        {
            GameObject.Find("Vida_Slider").SetActive(false);

        }
        else
        {
            GameObject.Find("Vida_Slider").SetActive(true);
        }
        barras[1].maxValue = enemigo.magia;
        barras[1].value = enemigo.magia;
        if (barras[1].maxValue == 0)
        {
            GameObject.Find("Magia_Slider").SetActive(false);

        }
        else
        {
            GameObject.Find("Magia_Slider").SetActive(true);
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
