using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemigoB : MonoBehaviour
{
    public EnemigoC conejo = new EnemigoC(100, 50, "Conejo");
    public List<EnemigoC> enemigoList;
    // Start is called before the first frame update
    void Awake()
    {

        enemigoList.Add(new EnemigoC(100, 50, "Conejo"));
        enemigoList.Add(new EnemigoC(100, 30, "StoneFire"));
        enemigoList.Add(new EnemigoC(500, 1, "Momia"));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
