using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconeInicial : MonoBehaviour
{
    public Image iconeimage;
    public float contador2 = 0;
    public bool PodeComecar = false;
    public GameObject Iconedesativa;
    public GameObject TelaMenu;
    private bool podediminuir = false;
    public GameObject TelaEmpresa;

    public GameObject TelaNome;


    void Start()
    {
        iconeimage = GetComponent<Image>();
    }

    void Update()
    {
        if (PodeComecar == true)
        {
            iconeimage.color = new Color(1f, 1f, 1f, contador2 += 0.01f);
            if (contador2 >= 1)
            {
                podediminuir = true;
                PodeComecar = false;
            }
        }

        if(podediminuir == true)
        {
            iconeimage.color = new Color(1f, 1f, 1f, contador2 -= 0.01f);

            if (contador2 <= 0)
            {
                Iconedesativa.SetActive(false);
                TelaEmpresa.SetActive(false);
                TelaNome.SetActive(true);
               
            }
        }
    }
}
