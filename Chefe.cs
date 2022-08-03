using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chefe : MonoBehaviour
{
    public Animator Animacao;
    private Gerenciador GJ;
    private float meuTempo = 0;
    public GameObject Tiro2;
    public bool PodeAtirar = false;

    public bool fechasorteiaposicao = true;
    public float posicao1;
    public float posicao2;
    public bool ParaPosicao = true;

    public GameObject Alertas;
    public GameObject Tiro1;

    public float tempoespecial1 = 0;

    public int vida = 10;
    public int quantidadetirada = 1;
    public int joias = 0;
    public int pontos = 0;

    public bool ParaColsoes = false;

    public GameObject Turbo;
    public bool ParaTudo = false;

    public GameObject MeuChefeImagem;

    public Sprite sprite0;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;

    public GameObject SomLaserChefe;

    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<Gerenciador>();
        Animacao = GetComponent<Animator>();
    }
    void Update()
    {
        if (GJ.EstadoGame() == true)
        {
            if(ParaTudo == true)
            {
                if (ParaPosicao == true)
                {
                    if (fechasorteiaposicao == true)
                    {
                        posicao1 = Random.Range(-2, 2);
                        posicao2 = Random.Range(-2, 2);

                    }

                    if (posicao1 >= posicao2)
                    {
                        fechasorteiaposicao = false;

                        Vector3 posPersonagem = new Vector3(posicao1, 2);
                        transform.position = Vector3.MoveTowards(transform.position, posPersonagem, 0.02f);

                        if (transform.position == posPersonagem)
                        {
                            fechasorteiaposicao = true;
                        }
                    }


                    if (posicao2 >= posicao1)
                    {
                        fechasorteiaposicao = false;


                        Vector3 posPersonagem = new Vector3(posicao2, 2);
                        transform.position = Vector3.MoveTowards(transform.position, posPersonagem, 0.02f);

                        if (transform.position == posPersonagem)
                        {
                            fechasorteiaposicao = true;
                        }
                    }

                }

                if (PodeAtirar == true)
                {
                    Temporizador();
                }

                tempoespecial1 += Time.deltaTime;
                if (tempoespecial1 >= 20)
                {

                    PodeAtirar = false;
                    ParaPosicao = false;
                    Alertas.SetActive(true);
                    tempoespecial1 = 0;
                }

            }

        }



    }

    public void DesativaAlertas()
    {
        SomLaserChefe.SetActive(true);
        Tiro1.SetActive(true);
        Alertas.SetActive(false);
    }

    public void DesativaTiro1()
    {
        PodeAtirar = true;
        ParaPosicao = true;
        Tiro1.SetActive(false);
        SomLaserChefe.SetActive(false);
    }

    void Temporizador()
    {
        meuTempo += Time.deltaTime;

        if (meuTempo > 5f)
        {
            CriarTiro();
            //CriarTiro2();
            //CriarTiro3();
            meuTempo = 0;
        }
    }


    void CriarTiro()
    {
        Vector3 posTiro = new Vector3(transform.position.x, transform.position.y + -1.8f, transform.position.z);
        GameObject NovoTiro = Instantiate(Tiro2, posTiro, Quaternion.identity);
        Destroy(NovoTiro, 3f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(ParaTudo == true)
        {
            if (collision.gameObject.tag == "Tiro")
            {
                vida = vida - quantidadetirada;
                collision.gameObject.GetComponent<Animator>().Play("explosaobala");


                if (vida <= 0)
                {
                    Morri();
                    joias = joias + 1;
                    GJ.RecebeJoiasMorreu(joias);

                    pontos = pontos + 1;
                    GJ.RecebePontosRank(pontos);

                    GJ.RecebePontos(pontos);

                }
            }

            if (collision.gameObject.tag == "MeuTiroDuplo")
            {
                vida = vida - quantidadetirada;
                collision.gameObject.GetComponent<Animator>().Play("explosaobala");

                if (vida <= 0)
                {
                    Morri();
                    joias = joias + 1;
                    GJ.RecebeJoiasMorreu(joias);

                    pontos = pontos + 1;
                    GJ.RecebePontosRank(pontos);

                    GJ.RecebePontos(pontos);

                }
            }

            if (collision.gameObject.tag == "MissilTiro")
            {
                vida = vida - quantidadetirada;

                if (vida <= 0)
                {
                    Morri();
                    joias = joias + 1;
                    GJ.RecebeJoiasMorreu(joias);

                    pontos = pontos + 1;
                    GJ.RecebePontosRank(pontos);

                    GJ.RecebePontos(pontos);

                }
            }

            if (collision.gameObject.tag == "LaserTiro")
            {
                vida = vida - quantidadetirada;

                if (vida <= 0)
                {
                    Morri();
                    joias = joias + 1;
                    GJ.RecebeJoiasMorreu(joias);

                    pontos = pontos + 1;
                    GJ.RecebePontosRank(pontos);

                    GJ.RecebePontos(pontos);

                }
            }
        }
        
    }

    public void DesligaAnimator()
    {
        GetComponent<Animator>().applyRootMotion = true;
        GJ.Perigo.SetActive(false);
        ParaTudo = true;
        PodeAtirar = true;
    }

    public void Morri()
    {
        SomLaserChefe.SetActive(false);
        MeuChefeImagem.SetActive(false);
        Turbo.SetActive(false);
        Alertas.SetActive(false);
        Tiro1.SetActive(false);
        ParaTudo = false;
        PodeAtirar = false;
        GetComponent<Animator>().enabled = true;
        GetComponent<AudioSource>().Play();
        Animacao.SetTrigger("Explode");
    }

    public void Medestroy()
    {
        GJ.Paralevas = true;
        Destroy(gameObject);
    }

    public void MudaImagemC(int contador)
    {
        if (contador == 0)
        {
            MeuChefeImagem.gameObject.GetComponent<SpriteRenderer>().sprite = sprite0;
        }

        if (contador == 1)
        {
            MeuChefeImagem.gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
        }

        if (contador == 2)
        {
            MeuChefeImagem.gameObject.GetComponent<SpriteRenderer>().sprite = sprite2;
        }

        if (contador == 3)
        {
            MeuChefeImagem.gameObject.GetComponent<SpriteRenderer>().sprite = sprite3;
        }

        if (contador == 4)
        {
            MeuChefeImagem.gameObject.GetComponent<SpriteRenderer>().sprite = sprite4;
        }

        if (contador == 5)
        {
            MeuChefeImagem.gameObject.GetComponent<SpriteRenderer>().sprite = sprite5;
        }


    }


}
