using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoInicial : MonoBehaviour
{
    public Image logoimage;
    public float contador = 1;

    public GameObject LogoDesativa;

    public IconeInicial Icone;
    public TS ts;


    void Start()
    {
        logoimage = GetComponent<Image>();
        
    }

    void Update()
    {
            logoimage.color = new Color(1f, 1f, 1f, contador -= 0.01f);

            if (contador <= 0)
            {
                Icone.PodeComecar = true;
                ts.PodeComecar = true;
                LogoDesativa.SetActive(false);
            }
        
           

    }
}
