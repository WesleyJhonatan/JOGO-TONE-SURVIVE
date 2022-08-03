using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaInimigos : MonoBehaviour
{
    private Gerenciador GJ;
    public int vida = 0;
    public GameObject TiroInimigo;
    public float atira = 1;
    public bool fechasorteia = true;
    public float tempotiro1;
    public float tempotiro2;
    public bool ParaTiro = true;
    public int quantidadetirada = 1;

    public int joias = 0;
    public int pontos = 0;

    public int TempoTiroDiminiu = 11;

    public SpriteRenderer spriteRenderer;
    public GameObject MinhaExplosao;
    public GameObject MeuTurbo;

    private bool FechaDano = true;

    public Sprite sprite0;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;
    public Sprite sprite8;
    public Sprite sprite9;
    public Sprite sprite10;
    public Sprite sprite11;
    public Sprite sprite12;


    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<Gerenciador>();
    }

    void Update()
    {
       
        if (TempoTiroDiminiu <= 7)
        {
            TempoTiroDiminiu = 7;
        }


        if (GJ.EstadoGame() == true)
        {
            if (GJ.InimigoAtira == true)
            {
                if (ParaTiro == true)
                {
                    if (fechasorteia == true)
                    {
                        tempotiro1 = Random.Range(1, TempoTiroDiminiu);
                        tempotiro2 = Random.Range(1, TempoTiroDiminiu);

                    }

                    if (tempotiro1 >= tempotiro2)
                    {
                        fechasorteia = false;

                        atira += 0.009f;

                        if (atira >= tempotiro1)
                        {
                            fechasorteia = true;
                            atira = 0;
                            ChamaTiro();
                        }
                    }

                    if (tempotiro2 <= tempotiro1)
                    {
                        fechasorteia = false;

                        atira += 0.009f;

                        if (atira >= tempotiro1)
                        {
                            fechasorteia = true;
                            atira = 0;
                            ChamaTiro();
                        }

                    }
                }

            }


        }



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(FechaDano == true)
        {
            if (collision.gameObject.tag == "Tiro")
            {
                collision.gameObject.GetComponent<Animator>().Play("explosaobala");
                vida = vida - quantidadetirada;

                if (vida <= 0)
                {
                    FechaDano = false;
                    joias = joias + 5;
                    GJ.RecebeJoiasMorreu(joias);

                    pontos = pontos + 1;
                    GJ.RecebePontosRank(pontos);

                    GJ.RecebePontos(pontos);

                   // GJ.Recebeleva1(1);

                    ParaTiro = false;
                    GetComponent<SpriteRenderer>().enabled = false;
                    MeuTurbo.SetActive(false);
                    MinhaExplosao.SetActive(true);
                    Medestroi();
                }
            }

            if (collision.gameObject.tag == "MeuTiroDuplo")
            {
                collision.gameObject.GetComponent<Animator>().Play("explosaobala");
                vida = vida - quantidadetirada;

                if (vida <= 0)
                {
                    FechaDano = false;
                    joias = joias + 5;
                    GJ.RecebeJoiasMorreu(joias);

                    pontos = pontos + 1;
                    GJ.RecebePontosRank(pontos);

                    GJ.RecebePontos(pontos);

                    //GJ.Recebeleva1(1);

                    ParaTiro = false;
                    GetComponent<SpriteRenderer>().enabled = false;
                    MeuTurbo.SetActive(false);
                    MinhaExplosao.SetActive(true);
                    Medestroi();
                }
            }

            if (collision.gameObject.tag == "MissilTiro")
            {
                vida = vida - quantidadetirada;

                if (vida <= 0)
                {
                    FechaDano = false;
                    joias = joias + 5;
                    GJ.RecebeJoiasMorreu(joias);

                    pontos = pontos + 1;
                    GJ.RecebePontosRank(pontos);

                    GJ.RecebePontos(pontos);

                   // GJ.Recebeleva1(1);

                    ParaTiro = false;
                    GetComponent<SpriteRenderer>().enabled = false;
                    MeuTurbo.SetActive(false);
                    MinhaExplosao.SetActive(true);
                    Medestroi();
                }
            }

            if (collision.gameObject.tag == "LaserTiro")
            {
                vida = vida - quantidadetirada;

                if (vida <= 0)
                {
                    FechaDano = false;
                    joias = joias + 5;
                    GJ.RecebeJoiasMorreu(joias);

                    pontos = pontos + 1;
                    GJ.RecebePontosRank(pontos);

                    GJ.RecebePontos(pontos);

                   // GJ.Recebeleva1(1);

                    ParaTiro = false;
                    GetComponent<SpriteRenderer>().enabled = false;
                    MeuTurbo.SetActive(false);
                    MinhaExplosao.SetActive(true);
                    Medestroi();

                }
            }
        }
     
    }

    public void ChamaTiro()
    {
        Vector3 posTiro = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
        GameObject NovoTiro = Instantiate(TiroInimigo, posTiro, Quaternion.identity);
        Destroy(NovoTiro, 2f);

    }

    public void Medestroi()
    {
        GetComponent<AudioSource>().Play();
        Destroy(gameObject, 0.6f);
    }

    public void MudaImagem(int contador)
    {
        if(contador == 0)
        {
            spriteRenderer.sprite = sprite0;
        }

        if (contador == 1)
        {
            spriteRenderer.sprite = sprite1;
        }

        if (contador == 2)
        {
            spriteRenderer.sprite = sprite2;
        }

        if (contador == 3)
        {
            spriteRenderer.sprite = sprite3;
        }

        if (contador == 4)
        {
            spriteRenderer.sprite = sprite4;
        }

        if (contador == 5)
        {
            spriteRenderer.sprite = sprite5;
        }

        if (contador == 6)
        {
            spriteRenderer.sprite = sprite6;
        }

        if (contador == 7)
        {
            spriteRenderer.sprite = sprite7;
        }

        if (contador == 8)
        {
            spriteRenderer.sprite = sprite8;
        }

        if (contador == 9)
        {
            spriteRenderer.sprite = sprite9;
        }

        if (contador == 10)
        {
            spriteRenderer.sprite = sprite10;
        }

        if (contador == 11)
        {
            spriteRenderer.sprite = sprite11;
        }

        if (contador == 12)
        {
            spriteRenderer.sprite = sprite12;
        }

    }
}
