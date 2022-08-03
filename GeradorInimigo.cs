using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorInimigo : MonoBehaviour
{
    //private Gerenciador GJ;
    //public GameObject Alien;
    //public GameObject Asteroid;

    //public float contador = 0;

    //public float contadorA = 0;
    //void Start()
    //{
    //    GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<Gerenciador>();
    //    GJ.tempo_criacao = 150;
    //}

    //void Update()
    //{
    //    CriarInimigoVermelho();
    //    CriarArteroid();
    //}

    //void CriarInimigoVermelho()
    //{
    //    if (GJ.EstadoGame())
    //    {
    //        if (GJ.iniciaInimigos == true)
    //        {

    //            contador++;

    //            if (contador > GJ.tempo_criacao)
    //            {
    //                float px = Random.Range(-2, 2);
    //                Vector3 posicao = new Vector3(px, 8, 0);

    //                GameObject Inimigo = Instantiate(Alien, posicao, Quaternion.identity);
    //                Destroy(Inimigo, 5f);

    //                contador = 0;
    //                GJ.tempo_criacao = GJ.tempo_criacao - 1f;
    //                if (GJ.tempo_criacao < 20)
    //                {
    //                    GJ.tempo_criacao = 20;
    //                }

    //            }
    //        }
    //    }
    //}

    //void CriarArteroid()
    //{
    //    if (GJ.EstadoGame())
    //    {
    //        if (GJ.iniciaInimigos == true)
    //        {

    //            contadorA++;

    //            if (contadorA > 3500)
    //            {
    //                float px = Random.Range(-2, 2);
    //                Vector3 posicao = new Vector3(px, 8, 0);

    //                GameObject Inimigo = Instantiate(Asteroid, posicao, Quaternion.identity);
    //                Destroy(Inimigo, 5f);

    //                contadorA = 0;
    //            }
    //        }
    //    }
    //}
}
