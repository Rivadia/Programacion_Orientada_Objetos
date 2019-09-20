using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearEnemigo : MonoBehaviour
{
    public string Id;
    public string nombre;
    public int vida;
    public int magia;
    EnemigoB enemigo;
    EnemigoI enemigoI;
    // Start is called before the first frame update
    void Start()
    {
        enemigo = FindObjectOfType<EnemigoB>();
        enemigoI = GetComponentInChildren<EnemigoI>();
        cEnemigo(Id);
        enemigoI.enemigoI();
    }

    void cEnemigo(string id)
    {
        for (int i = 0; i < enemigo.enemigoList.Count; i++)
        {
            
            if (id==enemigo.enemigoList[i].Nombre)
            {
                nombre = enemigo.enemigoList[i].Nombre;
                vida=enemigo.enemigoList[i].Vida;
                magia = enemigo.enemigoList[i].Magia;
            }
        }


    }
}
