using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesceLeva : MonoBehaviour
{
    private Gerenciador GJ;
    public float MinhaPisicao= 10;
    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<Gerenciador>();
    }

    void Update()
    {
        if (GJ.EstadoGame() == true)
        {
            if(MinhaPisicao >= 3.50f)
            {
                transform.position = new Vector3(transform.position.x, MinhaPisicao -= 0.1f, transform.position.z);
            }
           
        }
            
    }
}
