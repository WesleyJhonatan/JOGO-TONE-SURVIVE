using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoNavesInimigas : MonoBehaviour
{

    public GameObject Leva1;
    public float cont1 = 0;
    public bool podeir = false;
    void Start()
    {
        
    }

    void Update()
    {
        if(podeir == true)
        {
            Leva1.transform.position = new Vector3(cont1 += 0.05f, transform.position.y, transform.position.z);
        }
        
    }
}
