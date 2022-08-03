using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TS : MonoBehaviour
{
    public Image ts;
    public float contador2 = 0;
    public bool PodeComecar = false;
    public GameObject tsdesativa;
    private bool podediminuir = false;
    


    void Start()
    {
        ts = GetComponent<Image>();
    }

    void Update()
    {
       
            if (PodeComecar == true)
            {
                ts.color = new Color(1f, 1f, 1f, contador2 += 0.01f);
                if (contador2 >= 1)
                {
                    podediminuir = true;
                    PodeComecar = false;
                }
            }

            if (podediminuir == true)
            {
                ts.color = new Color(1f, 1f, 1f, contador2 -= 0.01f);

                if (contador2 <= 0)
                {
                    tsdesativa.SetActive(false);
                }
            }
        
     
    }
}