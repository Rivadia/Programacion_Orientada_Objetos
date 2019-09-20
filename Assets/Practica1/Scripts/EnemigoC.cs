using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class EnemigoC 
{
    int vida;
    int magia;
    string nombre;

    public string Nombre
    {
        get
        {
            return nombre;
        }
        set
        {
            nombre = value;
        }
    }

    public int Vida
    {
        get { return vida; }
        set { vida = value; }
    }

    public int Magia
    {
        get { return magia; }
        set { magia = value; }
    }
    public EnemigoC(int v, int m, string n)
    {
        this.Nombre = n;
        this.Vida = v;
        this.Magia = m;

    }
}
