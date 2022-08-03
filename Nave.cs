using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Nave : MonoBehaviour
{

    public GameObject SomMissilSegue;
    private Gerenciador GJ;
    public GameObject SomCoisas;
    public GameObject SomLase;
    public bool PodeMover = false;
    public bool MoverDedo = true;
    public float speed = 6;

    private float meuTempo = 0;
    public GameObject Tiro;
    public bool PodeAtirar = false;
   


    public GameObject BTmaoOn;
    public GameObject BTmaoOff;
    public GameObject Imagemao1;
    public GameObject Imagemao2;

    public GameObject BTjoyOn;
    public GameObject BTjoyOff;
    public GameObject Imagejoy1;
    public GameObject Imagejoy2;

    public GameObject MeuJoyy;
    public int vida = 3;

    public GameObject GuardaNaves;
    public bool FazerTudo = true;
    public bool tomardano = true;

    public bool TiroRapido = false;
    public float meuTempo2 = 0;
    public float meuTempo3 = 0;
    public bool TiroDuplo = false;
    public float meuTempo4 = 0;
    public float meuTempo5 = 0;
    public GameObject TiroDuploOB;
    public bool TiroMissil = false;
    public float meuTempo6 = 0;
    public float meuTempo7 = 0;
    public GameObject TiroMissilOB;

    public GameObject TiroLaser1OB;
    public bool TiroLaser1 = false;
    public float meuTempo8 = 0;

    public GameObject MeuEscudo;
    public bool LigaEscudo = false;
    public float meuTempo9 = 0;

    public bool Impacto = true;

    //public int joias = 0;


    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<Gerenciador>();
    }

    void Update()
    {
        if (GJ.EstadoGame() == true)
        {
            if(FazerTudo == true)
            {
                if (MoverDedo == true)
                {
                    MoverNaveDedo();
                }

                if (MoverDedo == false)
                {
                    MoverNaveJoy();
                }

                if (PodeAtirar == true)
                {
                    TiroRapido = false;
                    TiroDuplo = false;
                    TiroMissil = false;
                    TiroLaser1 = false;
                    Temporizador();
                }

                if (TiroRapido == true)
                {
                    TemporizadorTiroRapido();

                    meuTempo3 += Time.deltaTime;
                    if (meuTempo3 > 10f)
                    {
                        PodeAtirar = true;
                        TiroRapido = false;
                        TiroDuplo = false;
                        TiroMissil = false;
                        TiroLaser1 = false;
                        meuTempo3 = 0;
                    }

                }

                if (TiroDuplo == true)
                {
                    TemporizadorTiroDuplo();

                    meuTempo4 += Time.deltaTime;
                    if (meuTempo4 > 10f)
                    {
                        PodeAtirar = true;
                        TiroRapido = false;
                        TiroDuplo = false;
                        TiroMissil = false;
                        TiroLaser1 = false;
                        meuTempo4 = 0;
                    }

                }

                if (TiroMissil == true)
                {
                    TemporizadorTiroMissil();

                    meuTempo6 += Time.deltaTime;
                    if (meuTempo6 > 10f)
                    {
                        SomMissilSegue.SetActive(false);
                        PodeAtirar = true;
                        TiroRapido = false;
                        TiroDuplo = false;
                        TiroMissil = false;
                        TiroLaser1 = false;
                        meuTempo6 = 0;
                    }

                }

                if (TiroLaser1 == true)
                {
                    TiroLaser1OB.SetActive(true);
                    meuTempo8 += Time.deltaTime;
                    if (meuTempo8 > 10f)
                    {
                        SomLase.SetActive(false);
                        TiroLaser1OB.SetActive(false);
                        PodeAtirar = true;
                        TiroRapido = false;
                        TiroDuplo = false;
                        TiroMissil = false;
                        TiroLaser1 = false;
                        meuTempo8 = 0;

                       
                    }

                }

                if (LigaEscudo == true)
                {
                    meuTempo9 += Time.deltaTime;
                    if (meuTempo9 > 10f)
                    {
                        MeuEscudo.SetActive(false);
                        LigaEscudo = false;
                        tomardano = true;
                        meuTempo9 = 0;

                    }

                }
            }
               
         
        }
        
    }


    void MoverNaveDedo()
    {
        if (PodeMover == true)
        {


            if (Input.GetMouseButton(0))
            {                
                Vector3 posMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector3 posPersonagem = new Vector3(posMouse.x, posMouse.y+1, transform.position.z);


                if (posPersonagem.x < -2)
                {
                    posPersonagem.x = -2;
                }
                if (posPersonagem.x > 2)
                {
                    posPersonagem.x = 2;
                }
                if (posPersonagem.y < -3f)
                {
                    posPersonagem.y = -3f;
                }
                if (posPersonagem.y > 3.84f)
                {
                    posPersonagem.y = 3.84f;
                }

                transform.position = Vector3.MoveTowards(transform.position, posPersonagem, 1);

            }
        }
    }

    public void MoverNaveJoy()
    {
        if (PodeMover == true)
        {
            Vector2 input = new Vector2(MSJoystickController.joystickInput.x, MSJoystickController.joystickInput.y);
            float x = Mathf.Clamp(transform.position.x + input.x * Time.deltaTime * speed, -2.2f, 2.2f);
            float y = Mathf.Clamp(transform.position.y + input.y * Time.deltaTime * speed, -4.5F, 4);
            transform.position = new Vector3(x, y);
            //transform.Translate(input.x * Time.deltaTime * speed, input.y * Time.deltaTime * speed, 0);

        }

    }
   

    void Temporizador()
    {
        meuTempo += Time.deltaTime;

        if (meuTempo > 0.5f)
        {
            CriarTiro();
            meuTempo = 0;
        }
    }

    void TemporizadorTiroRapido()
    {
        meuTempo2 += Time.deltaTime;
        if (meuTempo2 > 0.3f)
        {
            CriarTiro();
            meuTempo2 = 0;
        }
    }

    void TemporizadorTiroDuplo()
    {
        meuTempo5 += Time.deltaTime;
        if (meuTempo5 > 0.4f)
        {
            CriarTiroDuplo();
            meuTempo5 = 0;
        }
    }

    void TemporizadorTiroMissil()
    {
        meuTempo7 += Time.deltaTime;
        if (meuTempo7 > 1f)
        {
            CriarTiroMissil();
            meuTempo7 = 0;
        }
    }

    void CriarTiro()
    {
        Vector3 posTiro = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
        GameObject NovoTiro = Instantiate(Tiro, posTiro, Quaternion.identity);
        Destroy(NovoTiro, 3f);
    }

    void CriarTiroDuplo()
    {
        Vector3 posTiro2 = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
        GameObject NovoTiro2 = Instantiate(TiroDuploOB, posTiro2, Quaternion.identity);
        Destroy(NovoTiro2, 3f);
    }

    void CriarTiroMissil()
    {
        Vector3 posTiro2 = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
        GameObject NovoTiro2 = Instantiate(TiroMissilOB, posTiro2, Quaternion.identity);
        Destroy(NovoTiro2, 5f);
    }


    public void BTMaoonn()
    {
        Imagemao1.SetActive(false);
        Imagemao2.SetActive(true);
        BTmaoOn.SetActive(false);
        BTmaoOff.SetActive(true);

        Imagejoy1.SetActive(true);
        Imagejoy2.SetActive(false);
        BTjoyOn.SetActive(true);
        BTjoyOff.SetActive(false);

        MeuJoyy.SetActive(true);
        MoverDedo = false;
    }

    public void BTMaoof()
    {
        Imagemao1.SetActive(true);
        Imagemao2.SetActive(false);
        BTmaoOn.SetActive(true);
        BTmaoOff.SetActive(false);

        Imagejoy1.SetActive(false);
        Imagejoy2.SetActive(true);
        BTjoyOn.SetActive(false);
        BTjoyOff.SetActive(true);

        MeuJoyy.SetActive(false);
        MoverDedo = true;
    }

    public void BTJoyonn()
    {
        Imagejoy1.SetActive(false);
        Imagejoy2.SetActive(true);
        BTjoyOn.SetActive(false);
        BTjoyOff.SetActive(true);


        Imagemao1.SetActive(true);
        Imagemao2.SetActive(false);
        BTmaoOn.SetActive(true);
        BTmaoOff.SetActive(false);

        MeuJoyy.SetActive(false);
        MoverDedo = true;
    }

    public void BTJoyoff()
    {
        Imagejoy1.SetActive(true);
        Imagejoy2.SetActive(false);
        BTjoyOn.SetActive(true);
        BTjoyOff.SetActive(false);

        Imagemao1.SetActive(false);
        Imagemao2.SetActive(true);
        BTmaoOn.SetActive(false);
        BTmaoOff.SetActive(true);

        MeuJoyy.SetActive(true);
        MoverDedo = false;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        Impacto = true;
        if (Impacto == true)
        {
            if (collision.gameObject.tag == "Meteoro")
            {
                Destroy(collision.gameObject);
                if (tomardano == true)
                {
                    vida = 0;
                    GJ.RecebeVida(0);
                    tomardano = false;
                    GuardaNaves.SetActive(false);
                    GetComponent<AudioSource>().Play();
                    GetComponent<Animator>().Play("Explodiu");
                    SomMissilSegue.SetActive(false);
                    SomLase.SetActive(false);

                }


            }

            if (collision.gameObject.tag == "TiroInimigo")
            {
                Destroy(collision.gameObject);

                if (tomardano == true)
                {
                    vida = vida - 1;
                    GJ.RecebeVida(1);
                }

                if (vida <= 0)
                {
                    tomardano = false;
                    GuardaNaves.SetActive(false);
                    GetComponent<AudioSource>().Play();
                    GetComponent<Animator>().Play("Explodiu");
                    SomMissilSegue.SetActive(false);
                    SomLase.SetActive(false);
                }
            }

            if (collision.gameObject.tag == "Tirorapido")
            {
                SomCoisas.GetComponent<AudioSource>().Play();
                collision.gameObject.GetComponent<Rigidbody2D>().simulated = false;
                collision.gameObject.GetComponent<Animator>().Play("explosaopontos");
                TiroRapido = true;
                TiroDuplo = false;
                PodeAtirar = false;
                TiroMissil = false;
                TiroLaser1 = false;
                Destroy(collision.gameObject, 0.5f);

                meuTempo3 = 0;
                meuTempo8 = 0;
                meuTempo6 = 0;
                meuTempo4 = 0;
                TiroLaser1OB.SetActive(false);
                SomMissilSegue.SetActive(false);
                SomLase.SetActive(false);
            }

            if (collision.gameObject.tag == "TiroDuplo")
            {
                SomCoisas.GetComponent<AudioSource>().Play();
                TiroDuplo = true;
                TiroRapido = false;
                PodeAtirar = false;
                TiroMissil = false;
                TiroLaser1 = false;
                collision.gameObject.GetComponent<Rigidbody2D>().simulated = false;
                collision.gameObject.GetComponent<Animator>().Play("explosaopontos");
                Destroy(collision.gameObject, 0.5f);

                meuTempo3 = 0;
                meuTempo8 = 0;
                meuTempo6 = 0;
                meuTempo4 = 0;
                TiroLaser1OB.SetActive(false);
                SomMissilSegue.SetActive(false);
                SomLase.SetActive(false);

            }

            if (collision.gameObject.tag == "MissilObjeto")
            {
                SomMissilSegue.SetActive(true);
                SomCoisas.GetComponent<AudioSource>().Play();
                collision.gameObject.GetComponent<Rigidbody2D>().simulated = false;
                collision.gameObject.GetComponent<Animator>().Play("explosaopontos");
                TiroMissil = true;
                TiroDuplo = false;
                TiroRapido = false;
                PodeAtirar = false;
                TiroLaser1 = false;


                meuTempo3 = 0;
                meuTempo8 = 0;
                meuTempo6 = 0;
                meuTempo4 = 0;
                TiroLaser1OB.SetActive(false);
                Destroy(collision.gameObject, 0.5f);
                SomLase.SetActive(false);
            }

            if (collision.gameObject.tag == "Laser1Objeto")
            {
                SomLase.SetActive(true);
                SomCoisas.GetComponent<AudioSource>().Play();
                collision.gameObject.GetComponent<Rigidbody2D>().simulated = false;
                collision.gameObject.GetComponent<Animator>().Play("explosaopontos");
                TiroLaser1 = true;
                TiroMissil = false;
                TiroDuplo = false;
                TiroRapido = false;
                PodeAtirar = false;

                meuTempo3 = 0;
                meuTempo8 = 0;
                meuTempo6 = 0;
                meuTempo4 = 0;
                TiroLaser1OB.SetActive(false);
                Destroy(collision.gameObject, 0.5f);
                SomMissilSegue.SetActive(false);
            }

            if (collision.gameObject.tag == "EscudoObjeto")
            {
                SomCoisas.GetComponent<AudioSource>().Play();
                tomardano = false;
                MeuEscudo.SetActive(true);
                LigaEscudo = true;
                collision.gameObject.GetComponent<Rigidbody2D>().simulated = false;
                collision.gameObject.GetComponent<Animator>().Play("explosaopontos");
                Destroy(collision.gameObject, 0.5f);

            }

            if (collision.gameObject.tag == "TiroLaserChefe")
            {
                if (tomardano == true)
                {
                    vida = 0;
                    GJ.RecebeVida(0);
                    tomardano = false;
                    GuardaNaves.SetActive(false);
                    GetComponent<AudioSource>().Play();
                    GetComponent<Animator>().Play("Explodiu");
                    SomMissilSegue.SetActive(false);
                    SomLase.SetActive(false);
                }


            }
        }
        
    }

    public void ChamaGameover()
    {
        FazerTudo = false;
        Impacto = false;
        TiroLaser1 = false;
        TiroMissil = false;
        TiroDuplo = false;
        TiroRapido = false;
        TiroLaser1OB.SetActive(false);
        MeuEscudo.SetActive(false);
        meuTempo3 = 0;
        meuTempo8 = 0;
        meuTempo6 = 0;
        meuTempo4 = 0;

        GJ.ChamaTelaGameOver();
    }

    public void GamePauseOn()
    {
        PodeAtirar = false;
        PodeMover = false;
        Time.timeScale = 0;
    }

    public void GamePauseOff()
    {
        PodeAtirar = true;
        PodeMover = true;
        Time.timeScale = 1;
    }
    

}


