using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPontos : MonoBehaviour
{
    private Text texto;
    private Gerenciador GJ;
    void Start()
    {
        texto = GetComponent<Text>();
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<Gerenciador>();

    }

    void Update()
    {
        texto.text = GJ.RetornaPontos().ToString();
    }
}
