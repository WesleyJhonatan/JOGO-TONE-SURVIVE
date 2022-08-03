using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gerenciador : MonoBehaviour
{
    public bool estadoJogo;
    public GameObject TelaGameOver;
    public GameObject telaUIgame;

    public GameObject SomMenu;
    public GameObject SomJogo;
    public GameObject SomConversa;

    public GameObject ImagemHomem1;
    public GameObject ImagemHomem2;
    public GameObject BarraAmarelaHomem;
    public GameObject ReflexoHomem;

    public GameObject ImagemMulher1;
    public GameObject ImagemMulher2;
    public GameObject BarraAmarelaMulher;
    public GameObject ReflexoMulher;

    public GameObject Proximo;
    public GameObject Masculino1;
    public GameObject Masculino2;
    public GameObject Feminino1;
    public GameObject Feminino2;

    public Nave Jogador;
    public icone_nome_neon proximoliga;

    private bool sexo = true;

    public GameObject telaMenu;
    public GameObject TelaPersonagem;
    public GameObject TelaConversa;

    public GameObject ImagemHomemConversa;
    public GameObject ImagemMulherConversa;

    public int vidaGJ = 3;
    public int pontosGJ = 0;
    public GerarCoisas Gerarcoisas;

    public GameObject Leva2Inimigos;
    public GameObject Leva1Inimigos;

    public bool InimigoAtira = false;

    public GameObject MeuTexto1;
    public GameObject MeuTexto2;
    public GameObject MeuTexto3;
    public GameObject Proximo2;

    public TextoEffect ScriptyTexto;

    private Banco MeuBanco;

    public string theName;
    public GameObject inputFileld;
    public GameObject textDisplay;

    public int ContChamaChefe = 0;
    public bool Paralevas = false;
    public GameObject Perigo;

    public GameObject LevaChefe;

    private VidaInimigos ScriptVidaInimigos;

    private int somavidainimigo = 0;

    private Chefe ScriptChefe;

    private int somavidachefe = 0;

    private int diminuitempotiro = 11;

    public int ContMudaSprite = 0;

    public int contNumeroLeva = 0;

    public int ContMudaSpriteChefe = 0;

    void Start()
    {
        MeuBanco = GetComponent<Banco>();
        estadoJogo = false;
        Time.timeScale = 0;
        Jogador.transform.localPosition = new Vector3(0, -3, 0);
        //PlayerPrefs.DeleteAll();
    }

    void Update()
    {
        if (Paralevas == true)
        {
            GameObject[] MeusIni;
            MeusIni = GameObject.FindGameObjectsWithTag("Inimigo");

            for (int indic = 0; indic <= MeusIni.Length; indic++)
            {
                if (MeusIni.Length <= 0)
                {
                    ContChamaChefe = ContChamaChefe + 1;
                    if (ContChamaChefe == 4)
                    {
                        ChamaBoss();
                        Paralevas = false;
                    }

                    if(Paralevas == true)
                    {
                        LimparLevas();
                        contNumeroLeva++;
                        Recebeleva(contNumeroLeva);
                    }
                    

                }

            }
        }
    }

    public bool EstadoGame()
    {
        return estadoJogo;
    }

    public void IniciarJogo()
    {
        SomConversa.SetActive(false);
        Jogador.Impacto = true;
        Jogador.FazerTudo = true;
        Jogador.PodeMover = true;
        Jogador.PodeAtirar = true;
        SomMenu.SetActive(false);
        SomJogo.SetActive(true);
        telaUIgame.SetActive(true);
        Gerarcoisas.GerarGeral = true;


        InimigoAtira = true;
        HomemMulherNormal();
        ImagemHomemConversa.SetActive(false);
        ImagemMulherConversa.SetActive(false);
        Proximo.SetActive(false);
        Paralevas = true;

        ScriptyTexto.LimpaTudo();
        MeuTexto1.SetActive(false);
        MeuTexto2.SetActive(false);
        MeuTexto3.SetActive(false);
        Proximo2.SetActive(false);


    }

    public void BotaoHomem()
    {
        sexo = true;
        proximoliga.proximoliga = true;
        Proximo.SetActive(true);
        ReflexoHomem.SetActive(true);
        ImagemHomem1.SetActive(false);
        ImagemHomem2.SetActive(true);
        BarraAmarelaHomem.SetActive(true);
        Masculino1.SetActive(false);
        Masculino2.SetActive(true);

        ReflexoMulher.SetActive(false);
        ImagemMulher1.SetActive(true);
        ImagemMulher2.SetActive(false);
        BarraAmarelaMulher.SetActive(false);
        Feminino1.SetActive(true);
        Feminino2.SetActive(false);


    }

    public void BotaoMulher()
    {
        sexo = false;
        proximoliga.proximoliga = true;
        Proximo.SetActive(true);
        ReflexoMulher.SetActive(true);
        ImagemMulher1.SetActive(false);
        ImagemMulher2.SetActive(true);
        BarraAmarelaMulher.SetActive(true);
        Feminino1.SetActive(false);
        Feminino2.SetActive(true);

        ReflexoHomem.SetActive(false);
        ImagemHomem1.SetActive(true);
        ImagemHomem2.SetActive(false);
        BarraAmarelaHomem.SetActive(false);
        Masculino1.SetActive(true);
        Masculino2.SetActive(false);

    }

    public void HomemMulherNormal()
    {
        ReflexoHomem.SetActive(false);
        ImagemHomem1.SetActive(true);
        ImagemHomem2.SetActive(false);
        BarraAmarelaHomem.SetActive(false);
        Masculino1.SetActive(true);
        Masculino2.SetActive(false);


        ReflexoMulher.SetActive(false);
        ImagemMulher1.SetActive(true);
        ImagemMulher2.SetActive(false);
        BarraAmarelaMulher.SetActive(false);
        Feminino1.SetActive(true);
        Feminino2.SetActive(false);
    }

    public void BTstarttPersonagem()
    {
        MeuTexto1.SetActive(true);
        if (sexo == true)
        {
            estadoJogo = true;
            Time.timeScale = 1;
            telaMenu.SetActive(false);
            TelaPersonagem.SetActive(false);
            TelaConversa.SetActive(true);
            ImagemHomemConversa.SetActive(true);
            SomConversa.SetActive(true);
        }

        if (sexo == false)
        {
            estadoJogo = true;
            Time.timeScale = 1;
            telaMenu.SetActive(false);
            TelaPersonagem.SetActive(false);
            TelaConversa.SetActive(true);
            ImagemMulherConversa.SetActive(true);
            SomConversa.SetActive(true);
        }
    }

    public void Recebeleva(int cont)
    {

        if (cont % 2 == 0)
        {
            Vector3 posLeva1 = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
            GameObject Novale1 = Instantiate(Leva1Inimigos, posLeva1, Quaternion.identity);
            AumentaVidasInimigo();

        }

        else
        {
            Vector3 posLeva2 = new Vector3(transform.position.x, transform.position.y + 3.54f, transform.position.z);
            GameObject Novale2 = Instantiate(Leva2Inimigos, posLeva2, Quaternion.identity);
            AumentaVidasInimigo();
        }
        
    }

    public void RecebeVida(int vida)
    {
        vidaGJ = vidaGJ - vida;

        if (vida == 0)
        {
            vidaGJ = 0;
        }
    }

    public int RetornaVida()
    {
        return vidaGJ;
    }

    public void ChamaBoss()
    {
        Perigo.SetActive(true);
        Vector3 MeuBoss = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        GameObject NovoChefe = Instantiate(LevaChefe, MeuBoss, Quaternion.identity);
        AumentaVidaBoss();
        ContChamaChefe = 0;
    }

    public void RecebePontos(int pontos)
    {
        pontosGJ = pontosGJ - pontos;

    }

    public int RetornaPontos()
    {
        return pontosGJ;
    }

    public void ChamaTelaGameOver()
    {
        Gerarcoisas.GerarGeral = false;
        TelaGameOver.SetActive(true);

    }

    public void Reiniciar()
    {
        //Jogador.PodeAtirar = true;
        //Jogador.FazerTudo = true;
        //Jogador.Impacto = true;
        //Jogador.tomardano = true;
        //Jogador.transform.localPosition = new Vector3(0, -3, 0);
        //Jogador.GetComponent<Animator>().Play("parado");
        //vidaGJ = 3;
        //Jogador.vida = 3;
        //Jogador.GuardaNaves.SetActive(true);
        //Gerarcoisas.GerarGeral = true;

        //GameObject[] Tiros;
        //Tiros = GameObject.FindGameObjectsWithTag("TiroInimigo");

        //for (int indice = 0; indice < Tiros.Length; indice++)
        //{

        //    Destroy(Tiros[indice]);
        //}

        Jogador.PodeAtirar = true;
        Jogador.FazerTudo = true;
        Jogador.Impacto = true;
        Jogador.tomardano = true;
        Jogador.transform.localPosition = new Vector3(0, -3, 0);
        Jogador.GetComponent<Animator>().Play("parado");
        vidaGJ = 3;
        Jogador.vida = 3;
        pontosGJ = 0;
        Jogador.GuardaNaves.SetActive(true);
        Gerarcoisas.GerarGeral = true;
        TelaGameOver.SetActive(false);
        LimparLevas();

        GameObject[] Tiros;
        Tiros = GameObject.FindGameObjectsWithTag("TiroInimigo");

        for (int indice = 0; indice < Tiros.Length; indice++)
        {
            Destroy(Tiros[indice]);
        }

        GameObject[] Boss;
        Boss = GameObject.FindGameObjectsWithTag("Chefe");

        for (int indice2 = 0; indice2 < Boss.Length; indice2++)
        {
            Destroy(Boss[indice2]);
        }

        ContChamaChefe = 0;
        somavidachefe = 0;
        ContMudaSprite = ContMudaSprite = 0;
        somavidainimigo = 0;
        diminuitempotiro = 10;
        ContMudaSpriteChefe = 0;
        Paralevas = true;

    }

    public void LimparLevas()
    {
        GameObject[] Minhaslevas;
        Minhaslevas = GameObject.FindGameObjectsWithTag("Levas");

        for (int indice = 0; indice < Minhaslevas.Length; indice++)
        {
            Destroy(Minhaslevas[indice]);
        }


    }

    public void VoltarMenu()
    {
        TelaGameOver.SetActive(false);
        telaMenu.SetActive(true);
        SomMenu.SetActive(true);
        SomJogo.SetActive(false);

        pontosGJ = 0;
        vidaGJ = 3;
        Jogador.vida = 3;
        Jogador.tomardano = true;

        LimparLevas();
        Jogador.transform.localPosition = new Vector3(0, -3, 0);
        Jogador.GuardaNaves.SetActive(true);
        Jogador.GetComponent<Animator>().Play("parado");

        GameObject[] Tiros;
        Tiros = GameObject.FindGameObjectsWithTag("TiroInimigo");

        for (int indice = 0; indice < Tiros.Length; indice++)
        {
            Destroy(Tiros[indice]);
        }

        GameObject[] Boss;
        Boss = GameObject.FindGameObjectsWithTag("Chefe");

        for (int indice2 = 0; indice2 < Boss.Length; indice2++)
        {
            Destroy(Boss[indice2]);
        }

        ContChamaChefe = 0;
        somavidachefe = 0;
        ContMudaSprite = ContMudaSprite = 0;
        somavidainimigo = 0;
        diminuitempotiro = 10;
        ContMudaSpriteChefe = 0;

        Paralevas = false;
        Time.timeScale = 0;
        estadoJogo = false;
    }

    public void RecebeJoiasMorreu(int n_joia)
    {
        MeuBanco.GuardarNoBanco(n_joia);
    }

    public void RecebePontosRank(int n_pontos)
    {
        MeuBanco.GuardarNoBancoRank(n_pontos);
    }

    public void URLinstagram()
    {
        Application.OpenURL("https://www.instagram.com/orbita_games/");
    }

    public void SairJogo()
    {
        Application.Quit();
    }

    public void StoreName()
    {
        theName = inputFileld.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Welcome" + theName + "to the game";
        MeuBanco.GuardarNoBancoNome(theName);

    }

    public void GamePauseOn()
    {
        Jogador.FazerTudo = false;
        Jogador.PodeMover = false;
        Jogador.PodeAtirar = false;
        Time.timeScale = 0;
    }

    public void AumentaVidasInimigo()
    {
        ContMudaSprite = ContMudaSprite + 1;
        somavidainimigo = somavidainimigo + 1;
        diminuitempotiro = diminuitempotiro - 1;

        if (ContMudaSprite > 12)
        {
            ContMudaSprite = 0;
        }

        GameObject[] MeusIni;
        MeusIni = GameObject.FindGameObjectsWithTag("Inimigo");
        
        for (int indic = 0; indic < MeusIni.Length; indic++)
        {
            ScriptVidaInimigos = MeusIni[indic].GetComponent<VidaInimigos>();
            ScriptVidaInimigos.spriteRenderer = MeusIni[indic].GetComponent<SpriteRenderer>();
            ScriptVidaInimigos.vida += somavidainimigo;
            ScriptVidaInimigos.TempoTiroDiminiu = diminuitempotiro;
            ScriptVidaInimigos.MudaImagem(ContMudaSprite);

        }


    }

    public void AumentaVidaBoss()
    {
        somavidachefe = somavidachefe + 10;
        ContMudaSpriteChefe = ContMudaSpriteChefe + 1;

        if (ContMudaSpriteChefe > 5)
        {
            ContMudaSpriteChefe = 0;
        }

        GameObject[] MeusBoss;
        MeusBoss = GameObject.FindGameObjectsWithTag("Chefe");

        for (int indic = 0; indic < MeusBoss.Length; indic++)
        {
            ScriptChefe = MeusBoss[indic].GetComponent<Chefe>();
            ScriptChefe.vida += somavidachefe;
            ScriptChefe.MudaImagemC(ContMudaSpriteChefe);
        }


    }

    public void RecebeSelecaoNaves(int n_naves)
    {
        MeuBanco.GuardarNoBancoNaves(n_naves);
    }

    public void RecebeCompra1(int compra0, int compra1, int compra2, int compra3, int compra4, int compra5, int compra6, int compra7, int compra8, int compra9)
    {
        MeuBanco.GuardarNoBancoCompras(compra0, compra1, compra2, compra3, compra4, compra5, compra6, compra7, compra8, compra9);
    }

}

