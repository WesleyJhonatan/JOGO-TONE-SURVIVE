using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroChefe2 : MonoBehaviour
{
    public Chefe cf;
    void Start()
    {
        cf = GameObject.FindGameObjectWithTag("Chefe").GetComponent<Chefe>();
    }

    void Update()
    {

    }

    public void DesativaTiro1()
    {
        cf.DesativaTiro1();
    }
}
