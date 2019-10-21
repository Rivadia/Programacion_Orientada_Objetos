using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour
{
    CEnemigo dañoEnemigo;
    // Start is called before the first frame update
    void Start()
    {
        dañoEnemigo = GetComponentInParent<CEnemigo>();
        Debug.Log(dañoEnemigo.name);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dañoEnemigo.vida -=10;
        }
    }
}
