using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class icone_nome_neon : MonoBehaviour
{
    private Gerenciador GJ;
    public Animator Animacao;
    public GameObject TS;
    public GameObject Nome;
    public GameObject Startt;
    public GameObject Map;
    public GameObject Exit;
    public GameObject Ranking;
    public GameObject Informacao;
    public GameObject Instagram;
    public GameObject Configuracao;
    public GameObject Loja;
    public GameObject Tone;
    public GameObject TelaPersonagems;
    public GameObject CaixaHomem;
    public GameObject CaixaMulher;
    public GameObject Proximo;
    public GameObject TelaMenu;
    public GameObject TelaLoja;
    public GameObject TelaMap;
    public GameObject TelaOpcoes;
    public GameObject BarraAudio;
    public GameObject TelaInfor;
    public GameObject TelaRank;
    public GameObject GuardaTudo;


    public bool proximoliga = false;

    private Banco BC;

    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<Gerenciador>();
        BC = GameObject.FindGameObjectWithTag("GameController").GetComponent<Banco>();
        Animacao = GetComponent<Animator>();
    }

    void Update()
    {
    }

    public void LigaNome()
    {
        Nome.SetActive(true);
    }

    public void LigaStart()
    {
        Startt.SetActive(true);
    }

    public void LigaMap()
    {
        Map.SetActive(true);
    }

    public void LigaExit()
    {
        Exit.SetActive(true);

    }

    public void LigaRanking()
    {
        Ranking.SetActive(true);
    }

    public void LigaInformacao()
    {
        Informacao.SetActive(true);
    }

    public void LigaInstagram()
    {
        Instagram.SetActive(true);
    }

    public void LigaConfiguracao()
    {
        Configuracao.SetActive(true);
    }

    public void LigaLoja()
    {
        Loja.SetActive(true);
    }

    public void LigaTone()
    {
        Tone.SetActive(true);
    }

    public void VoltaTs()
    {
        TS.GetComponent<Animator>().Play("voltats");
        proximoliga = false;

    }

    public void VoltaNome()
    {
        Nome.GetComponent<Animator>().Play("voltanome");
    }

    public void VoltaStart()
    {
        Startt.GetComponent<Animator>().Play("voltastart");
    }

    public void VoltaMap()
    {
        Map.GetComponent<Animator>().Play("voltamap");
    }

    public void VoltaExit()
    {
        Exit.GetComponent<Animator>().Play("voltaexit");
    }

    public void VoltaRanking()
    {
        Ranking.GetComponent<Animator>().Play("voltarank");
    }

    public void VoltaInformacao()
    {
        Informacao.GetComponent<Animator>().Play("voltainfo");
    }

    public void VoltaInstagram()
    {
        Instagram.GetComponent<Animator>().Play("voltainstagram");
    }

    public void VoltaConfiguracao()
    {
        Configuracao.GetComponent<Animator>().Play("voltaconfi");
    }

    public void VoltaLoja()
    {
        Loja.GetComponent<Animator>().Play("voltaloja");
    }

    public void VoltaTone()
    {
        Tone.GetComponent<Animator>().Play("voltatone");
    }

    public void VemTelaPersona()
    {
        TelaPersonagems.SetActive(true);
    }

    public void DesativaIcones()
    {
        TS.SetActive(false);
        Nome.SetActive(false);
        Startt.SetActive(false);
        Map.SetActive(false);
        Exit.SetActive(false);
        Ranking.SetActive(false);
        Informacao.SetActive(false);
        Instagram.SetActive(false);
        Configuracao.SetActive(false);
        Loja.SetActive(false);
        Tone.SetActive(false);

    }

    public void VoltaProximo()
    {
        if (proximoliga == true)
        {
            Proximo.GetComponent<Animator>().Play("voltaproximo");
        }

        if (proximoliga == false)
        {
            CaixaHomem.GetComponent<Animator>().Play("voltahomem");
            CaixaMulher.GetComponent<Animator>().Play("voltamulher");
        }

    }

    public void VoltaCaixaHomemMulher()
    {
        CaixaHomem.GetComponent<Animator>().Play("voltahomem");
        CaixaMulher.GetComponent<Animator>().Play("voltamulher");
    }

    public void VoltaTelaPersonagem()
    {
        TelaPersonagems.GetComponent<Animator>().Play("voltatelapersona");
        Proximo.SetActive(false);
    }

    public void LigaTS()
    {
        TS.SetActive(true);
        TelaPersonagems.SetActive(false);

    }

    public void ChamarLoja()
    {
        //BC.RetornaCompras0();
        //BC.RetornaCompras1();
        //BC.RetornaCompras2();
        //BC.RetornaCompras3();
        //BC.RetornaCompras4();
        //BC.RetornaCompras5();
        //BC.RetornaCompras6();
        //BC.RetornaCompras7();
        //BC.RetornaCompras8();
        //BC.RetornaCompras9();
        //BC.RetornaValorNaves();
        TelaLoja.SetActive(true);
       
       
    }

    public void ChamaVoltarLoja()
    {
        //BC.RetornaCompras0();
        //BC.RetornaCompras1();
        //BC.RetornaCompras2();
        //BC.RetornaCompras3();
        //BC.RetornaCompras4();
        //BC.RetornaCompras5();
        //BC.RetornaCompras6();
        //BC.RetornaCompras7();
        //BC.RetornaCompras8();
        //BC.RetornaCompras9();
        //BC.RetornaValorNaves();
        TelaLoja.GetComponent<Animator>().Play("voltartelaloja");
    }

    public void DesativaLoja()
    {
        TelaLoja.SetActive(false);
    }

    public void ChamarMap()
    {
        TelaMap.SetActive(true);
    }

    public void ChamaVoltarMap()
    {
        TelaMap.GetComponent<Animator>().Play("voltartelamap");
    }

    public void DesativaMap()
    {
        TelaMap.SetActive(false);
    }

    public void ChamarOpcoes()
    {
        GuardaTudo.SetActive(true);
        TelaOpcoes.SetActive(true);
        BarraAudio.SetActive(true);
    }

    public void ChamaConfAudio()
    {
        BarraAudio.GetComponent<Animator>().Play("vemaudio");
    }

    public void DesativaBarraAudio()
    {
        BarraAudio.GetComponent<Animator>().Play("saiaudio");
    }

    public void ChamaVoltarOpcoes()
    {
        TelaOpcoes.GetComponent<Animator>().Play("voltartelaopcao");
    }

    public void DesativaOpcaoes()
    {
        TelaOpcoes.SetActive(false);
    }

    public void ChamaInfor()
    {
        TelaInfor.SetActive(true);
    }

    public void ChamaVoltarInfor()
    {
        TelaInfor.GetComponent<Animator>().Play("voltartelaloja");
    }

    public void DesativaInfor()
    {
        TelaInfor.SetActive(false);
    }
    public void ChamaRank()
    {
        TelaRank.SetActive(true);
    }

    public void ChamaVoltarRank()
    {
        TelaRank.GetComponent<Animator>().Play("voltartelaloja");
    }

    public void DesativaRank()
    {
        TelaRank.SetActive(false);
    }

    public void DesativaGuardaTudo()
    {
        GuardaTudo.SetActive(false);
        TelaOpcoes.GetComponent<Animator>().Play("voltartelaopcao");
    }

}