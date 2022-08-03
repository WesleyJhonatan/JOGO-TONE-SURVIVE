using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroChefeBos : MonoBehaviour
{
    public Chefe cf;
    void Start()
    {
       cf = GameObject.FindGameObjectWithTag("Chefe").GetComponent<Chefe>();
    }

    void Update()
    {
        
    }

    public void Desativa()
    {
        cf.DesativaAlertas();
    }
}
