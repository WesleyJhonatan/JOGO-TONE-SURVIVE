using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarCoisas : MonoBehaviour
{
      private Gerenciador GJ;

    public GameObject TiroRapido;
    public float tirinho = 0;
    public bool fechasorteiatiro = true;
    public float tempotiro1;
    public float tempotiro2;
    public bool GerarTudo2 = true;

    public GameObject TiroDuplo;
    public float tirinhoDuplo = 0;
    public bool fechasorteiatiroDuplo = true;
    public float tempotiroDuplo1;
    public float tempotiroDuplo2;
    public bool GerarTudo3 = true;

    public GameObject Meteoro;
    public float meteorinho = 0;
    public bool fechasortemeteoro = true;
    public float tempometeoro1;
    public float tempometeoro2;
    public bool GerarTudo4 = true;

    public GameObject MissilSegue;
    public float missinho = 0;
    public bool fechasortemissil = true;
    public float tempomissil1;
    public float tempomissil2;
    public bool GerarTudo5 = true;

    public GameObject Laser1;
    public float lasersinho1 = 0;
    public bool fechasortelaser1 = true;
    public float tempolaser1;
    public float tempolaser2;
    public bool GerarTudo6 = true;

    public GameObject Escudo1;
    public float escudozinho = 0;
    public bool fechasorteescudo1 = true;
    public float tempoescudo1;
    public float tempoescudo2;
    public bool GerarTudo7 = true;

    public bool GerarGeral = false;

    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<Gerenciador>();
    }

    void Update()
    {
        if (GJ.EstadoGame() == true)
        {
              if(GerarGeral == true)
              {
                
                if (GerarTudo2 == true)
                {
                    if (fechasorteiatiro == true)
                    {
                        tempotiro1 = Random.Range(1, 10);
                        tempotiro2 = Random.Range(1, 10);

                    }

                    if (tempotiro1 >= tempotiro2)
                    {
                        fechasorteiatiro = false;

                        tirinho += 0.005f;

                        if (tirinho >= tempotiro1)
                        {
                            fechasorteiatiro = true;
                            tirinho = 0;
                            ChamaTiroRapido();
                        }
                    }

                    if (tempotiro2 >= tempotiro1)
                    {
                        fechasorteiatiro = false;

                        tirinho += 0.005f;

                        if (tirinho >= tempotiro2)
                        {
                            fechasorteiatiro = true;
                            tirinho = 0;
                            ChamaTiroRapido();
                        }

                    }

                }

                if (GerarTudo3 == true)
                {
                    if (fechasorteiatiroDuplo == true)
                    {
                        tempotiroDuplo1 = Random.Range(10, 14);
                        tempotiroDuplo2 = Random.Range(10, 14);

                    }

                    if (tempotiroDuplo1 >= tempotiroDuplo2)
                    {
                        fechasorteiatiroDuplo = false;

                        tirinhoDuplo += 0.005f;

                        if (tirinhoDuplo >= tempotiroDuplo1)
                        {
                            fechasorteiatiroDuplo = true;
                            tirinhoDuplo = 0;
                            ChamaTiroDuplo();
                        }
                    }

                    if (tempotiroDuplo2 >= tempotiroDuplo1)
                    {
                        fechasorteiatiroDuplo = false;

                        tirinhoDuplo += 0.005f;

                        if (tirinhoDuplo >= tempotiroDuplo2)
                        {
                            fechasorteiatiroDuplo = true;
                            tirinhoDuplo = 0;
                            ChamaTiroDuplo();
                        }

                    }

                }

                if (GerarTudo4 == true)
                {
                    if (fechasortemeteoro == true)
                    {
                        tempometeoro1 = Random.Range(15, 20);
                        tempometeoro2 = Random.Range(15, 20);

                    }

                    if (tempometeoro1 >= tempometeoro2)
                    {
                        fechasortemeteoro = false;

                        meteorinho += 0.005f;

                        if (meteorinho >= tempometeoro1)
                        {
                            fechasortemeteoro = true;
                            meteorinho = 0;
                            ChamaMeteoro();
                        }
                    }

                    if (tempometeoro2 >= tempometeoro1)
                    {
                        fechasortemeteoro = false;

                        meteorinho += 0.005f;

                        if (meteorinho >= tempometeoro2)
                        {
                            fechasortemeteoro = true;
                            meteorinho = 0;
                            ChamaMeteoro();
                        }

                    }

                }

                if (GerarTudo5 == true)
                {
                    if (fechasortemissil == true)
                    {
                        tempomissil1 = Random.Range(15, 18);
                        tempomissil2 = Random.Range(15, 18);

                    }

                    if (tempomissil1 >= tempomissil2)
                    {
                        fechasortemissil = false;

                        missinho += 0.005f;

                        if (missinho >= tempomissil1)
                        {
                            fechasortemissil = true;
                            missinho = 0;
                            ChamaMissil();
                        }
                    }

                    if (tempomissil2 >= tempomissil1)
                    {
                        fechasortemissil = false;

                        missinho += 0.005f;

                        if (missinho >= tempomissil2)
                        {
                            fechasortemissil = true;
                            missinho = 0;
                            ChamaMissil();
                        }

                    }

                }

                if (GerarTudo6 == true)
                {
                    if (fechasortelaser1 == true)
                    {
                        tempolaser1 = Random.Range(20, 25);
                        tempolaser2 = Random.Range(20, 25);

                    }

                    if (tempolaser1 >= tempolaser2)
                    {
                        fechasortelaser1 = false;

                        lasersinho1 += 0.005f;

                        if (lasersinho1 >= tempolaser1)
                        {
                            fechasortelaser1 = true;
                            lasersinho1 = 0;
                            ChamaLaser1();
                        }
                    }

                    if (tempolaser2 >= tempolaser1)
                    {
                        fechasortelaser1 = false;

                        lasersinho1 += 0.005f;

                        if (lasersinho1 >= tempolaser2)
                        {
                            fechasortelaser1 = true;
                            lasersinho1 = 0;
                            ChamaLaser1();
                        }

                    }

                }

                if (GerarTudo7 == true)
                {
                    if (fechasorteescudo1 == true)
                    {
                        tempoescudo1 = Random.Range(30, 30);
                        tempoescudo2 = Random.Range(30, 30);

                    }

                    if (tempoescudo1 >= tempoescudo2)
                    {
                        fechasorteescudo1 = false;

                        escudozinho += 0.005f;

                        if (escudozinho >= tempoescudo1)
                        {
                            fechasorteescudo1 = true;
                            escudozinho = 0;
                            ChamaEscudo();
                        }
                    }

                    if (tempoescudo2 >= tempoescudo1)
                    {
                        fechasorteescudo1 = false;

                        escudozinho += 0.005f;

                        if (escudozinho >= tempoescudo2)
                        {
                            fechasorteescudo1 = true;
                            escudozinho = 0;
                            ChamaEscudo();
                        }

                    }

                }
            }
           
        }
    }

    //public void ChamaJoia1()
    //{
    //    float px = Random.Range(-2, 2);
    //    Vector3 posicao = new Vector3(px, 8, 0);

    //    GameObject PontoJoia = Instantiate(Joia1, posicao, Quaternion.identity);
    //    Destroy(PontoJoia, 5f);

    //}

    public void ChamaTiroRapido()
        {
            float px = Random.Range(-2, 2);
            Vector3 posicao = new Vector3(px, 8, 0);

            GameObject TiroObe = Instantiate(TiroRapido, posicao, Quaternion.identity);
            Destroy(TiroObe, 5f);

        }

        public void ChamaTiroDuplo()
    {
        float px = Random.Range(-2, 2);
        Vector3 posicao = new Vector3(px, 8, 0);

        GameObject TiroObe = Instantiate(TiroDuplo, posicao, Quaternion.identity);
        Destroy(TiroObe, 5f);

    }

        public void ChamaMeteoro()
    {
        float px = Random.Range(-2, 2);
        Vector3 posicao = new Vector3(px, 8, 0);

        GameObject TiroObe = Instantiate(Meteoro, posicao, Quaternion.identity);
        Destroy(TiroObe, 5f);

    }

        public void ChamaMissil()
    {
        float px = Random.Range(-2, 2);
        Vector3 posicao = new Vector3(px, 8, 0);

        GameObject TiroObe = Instantiate(MissilSegue, posicao, Quaternion.identity);
        Destroy(TiroObe, 5f);

    }

        public void ChamaLaser1()
        {
            float px = Random.Range(-2, 2);
            Vector3 posicao = new Vector3(px, 8, 0);

            GameObject TiroObe = Instantiate(Laser1, posicao, Quaternion.identity);
            Destroy(TiroObe, 5f);

        }

    public void ChamaEscudo()
    {
        float px = Random.Range(-2, 2);
        Vector3 posicao = new Vector3(px, 8, 0);

        GameObject TiroObe = Instantiate(Escudo1, posicao, Quaternion.identity);
        Destroy(TiroObe, 5f);

    }

}
