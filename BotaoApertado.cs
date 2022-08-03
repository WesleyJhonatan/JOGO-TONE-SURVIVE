using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BotaoApertado : Button
{

    //Retorna se botao esta apertado

    public bool Apertado()
    {
        return IsPressed();
    }

}
