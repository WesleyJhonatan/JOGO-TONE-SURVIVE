using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui_JoiasTotal : MonoBehaviour
{
    private Banco MeuBanco;
    private Text texto;
    private Gerenciador GJ;
    void Start()
    {
        MeuBanco = GameObject.FindGameObjectWithTag("GameController").GetComponent<Banco>();
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<Gerenciador>();
        texto = GetComponent<Text>();
    }

    void Update()
    {
        texto.text = MeuBanco.InformarValorBanco().ToString();
    }
}
