using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banco : MonoBehaviour
{
    public int ValorBanco;
    private int ValorBancoRank;
    private string ValorBancoNome;

    public int ValorBancoNaves;
    public int ValorCompra0;
    public int ValorCompra1;
    public int ValorCompra2;
    public int ValorCompra3;
    public int ValorCompra4;
    public int ValorCompra5;
    public int ValorCompra6;
    public int ValorCompra7;
    public int ValorCompra8;
    public int ValorCompra9;

    public SelecaoNaves ScripySelecaoNaves;
    
    void Start()
    {
       
    }

    void Update()
    {
        RetornaCompras0();
        RetornaCompras1();
        RetornaCompras2();
        RetornaCompras3();
        RetornaCompras4();
        RetornaCompras5();
        RetornaCompras6();
        RetornaCompras7();
        RetornaCompras8();
        RetornaCompras9();
        RetornaValorNaves();
    }

    public void GuardarNoBanco(int novoValor)
    {
       
        //Recebo o que eu ja tenho
        ValorBanco = PlayerPrefs.GetInt("Joia");
        //somo com novo valor
        ValorBanco = ValorBanco + novoValor;
        //Guarda valor total
        PlayerPrefs.SetInt("Joia", ValorBanco);
       
    }

    public int InformarValorBanco()
    {
        ValorBanco = PlayerPrefs.GetInt("Joia");
        return ValorBanco;
    }

    public void GuardarNoBancoRank(int novoValor2)
    {
        //Recebo o que eu ja tenho
        ValorBancoRank = PlayerPrefs.GetInt("Inimigo");
        //somo com novo valor
        ValorBancoRank = ValorBancoRank + novoValor2;
        //Guarda valor total
        PlayerPrefs.SetInt("Inimigo", ValorBancoRank);
    }

    public int InformarValorBancoRank()
    {
        ValorBancoRank = PlayerPrefs.GetInt("Inimigo");
        return ValorBancoRank;
    }

    public void GuardarNoBancoNome(string novoValor3)
    {
        //Recebo o que eu ja tenho
        ValorBancoNome = PlayerPrefs.GetString("NomeUSU");
        //somo com novo valor
        ValorBancoNome = ValorBancoNome = novoValor3;
        //Guarda valor total
        PlayerPrefs.SetString("NomeUSU", ValorBancoNome);
    }

    public string InformarValorBancoNome()
    {
        ValorBancoNome = PlayerPrefs.GetString("NomeUSU");
        return ValorBancoNome;
    }

    public void GuardarNoBancoNaves(int novoValor4)
    {

        //Recebo o que eu ja tenho
        ValorBancoNaves = PlayerPrefs.GetInt("Naves");
        //somo com novo valor
        ValorBancoNaves = ValorBancoNaves = novoValor4;
        //Guarda valor total
        PlayerPrefs.SetInt("Naves", ValorBancoNaves);

    }

    public void GuardarNoBancoCompras(int compra0, int compra1, int compra2, int compra3, int compra4, int compra5, int compra6, int compra7, int compra8, int compra9)
    {
        ValorCompra0 = PlayerPrefs.GetInt("Compras0");
        ValorCompra0 = ValorCompra0 = compra0;
        PlayerPrefs.SetInt("Compras0", ValorCompra0);

        ValorCompra1 = PlayerPrefs.GetInt("Compras1");
        ValorCompra1 = ValorCompra1 = compra1;
        PlayerPrefs.SetInt("Compras1", ValorCompra1);

        ValorCompra2 = PlayerPrefs.GetInt("Compras2");
        ValorCompra2 = ValorCompra2 = compra2;
        PlayerPrefs.SetInt("Compras2", ValorCompra2);

        ValorCompra3 = PlayerPrefs.GetInt("Compras3");
        ValorCompra3 = ValorCompra3 = compra3;
        PlayerPrefs.SetInt("Compras3", ValorCompra3);

        ValorCompra4 = PlayerPrefs.GetInt("Compras4");
        ValorCompra4 = ValorCompra4 = compra4;
        PlayerPrefs.SetInt("Compras4", ValorCompra4);

        ValorCompra5 = PlayerPrefs.GetInt("Compras5");
        ValorCompra5 = ValorCompra5 = compra5;
        PlayerPrefs.SetInt("Compras5", ValorCompra5);

        ValorCompra6 = PlayerPrefs.GetInt("Compras6");
        ValorCompra6 = ValorCompra6 = compra6;
        PlayerPrefs.SetInt("Compras6", ValorCompra6);


        ValorCompra7 = PlayerPrefs.GetInt("Compras7");
        ValorCompra7 = ValorCompra7 = compra7;
        PlayerPrefs.SetInt("Compras7", ValorCompra7);


        ValorCompra8 = PlayerPrefs.GetInt("Compras8");
        ValorCompra8 = ValorCompra8 = compra8;
        PlayerPrefs.SetInt("Compras8", ValorCompra8);

        ValorCompra9 = PlayerPrefs.GetInt("Compras9");
        ValorCompra9 = ValorCompra9 = compra9;
        PlayerPrefs.SetInt("Compras9", ValorCompra9);
    }

    public int RetornaValorNaves()
    {
        ValorBancoNaves = PlayerPrefs.GetInt("Naves");
       

        if (ValorBancoNaves == 0)
        {
            if (ValorCompra0 == 0)
            {
                ScripySelecaoNaves.Nave00visto.SetActive(true);
                ScripySelecaoNaves.comprado00 = true;
                ScripySelecaoNaves.imagecinza00.SetActive(false);
                ScripySelecaoNaves.BTcompra0.SetActive(false);

                ScripySelecaoNaves.Nave00.SetActive(true);
                ScripySelecaoNaves.Nave01.SetActive(false);
                ScripySelecaoNaves.Nave02.SetActive(false);
                ScripySelecaoNaves.Nave03.SetActive(false);
                ScripySelecaoNaves.Nave04.SetActive(false);
                ScripySelecaoNaves.Nave05.SetActive(false);
                ScripySelecaoNaves.Nave06.SetActive(false);
                ScripySelecaoNaves.Nave07.SetActive(false);
                ScripySelecaoNaves.Nave08.SetActive(false);
                ScripySelecaoNaves.Nave09.SetActive(false);
            }
            
            if (ValorCompra1 == 1)
            {
                ScripySelecaoNaves.Nave01visto.SetActive(false);
                ScripySelecaoNaves.comprado01 = true;
                ScripySelecaoNaves.imagecinza01.SetActive(true);
                ScripySelecaoNaves.BTcompra1.SetActive(false);

               
            }


            if (ValorCompra2 == 2)
            {
                ScripySelecaoNaves.Nave02visto.SetActive(false);
                ScripySelecaoNaves.comprado02 = true;
                ScripySelecaoNaves.imagecinza02.SetActive(true);
                ScripySelecaoNaves.BTcompra2.SetActive(false);

                
            }

            if (ValorCompra3 == 3)
            {
                ScripySelecaoNaves.Nave03visto.SetActive(false);
                ScripySelecaoNaves.comprado03 = true;
                ScripySelecaoNaves.imagecinza03.SetActive(true);
                ScripySelecaoNaves.BTcompra3.SetActive(false);

            }


            if (ValorCompra4 == 4)
            {
                ScripySelecaoNaves.Nave04visto.SetActive(false);
                ScripySelecaoNaves.comprado04 = true;
                ScripySelecaoNaves.imagecinza04.SetActive(true);
                ScripySelecaoNaves.BTcompra4.SetActive(false);

            }


            if (ValorCompra5 == 5)
            {
                ScripySelecaoNaves.Nave05visto.SetActive(false);
                ScripySelecaoNaves.comprado05 = true;
                ScripySelecaoNaves.imagecinza05.SetActive(true);
                ScripySelecaoNaves.BTcompra5.SetActive(false);

            }

            if (ValorCompra6 == 6)
            {
                ScripySelecaoNaves.Nave06visto.SetActive(false);
                ScripySelecaoNaves.comprado06 = true;
                ScripySelecaoNaves.imagecinza06.SetActive(true);
                ScripySelecaoNaves.BTcompra6.SetActive(false);

            }

            if (ValorCompra7 == 7)
            {
                ScripySelecaoNaves.Nave07visto.SetActive(false);
                ScripySelecaoNaves.comprado07 = true;
                ScripySelecaoNaves.imagecinza07.SetActive(true);
                ScripySelecaoNaves.BTcompra7.SetActive(false);

            }

            if (ValorCompra8 == 8)
            {
                ScripySelecaoNaves.Nave08visto.SetActive(false);
                ScripySelecaoNaves.comprado08 = true;
                ScripySelecaoNaves.imagecinza08.SetActive(true);
                ScripySelecaoNaves.BTcompra8.SetActive(false);

            
            }

            if (ValorCompra9 == 9)
            {
                ScripySelecaoNaves.Nave09visto.SetActive(false);
                ScripySelecaoNaves.comprado09 = true;
                ScripySelecaoNaves.imagecinza09.SetActive(true);
                ScripySelecaoNaves.BTcompra9.SetActive(false);

            }

        }

        if (ValorBancoNaves == 1)
        {

            if (ValorCompra0 == 0)
            {
                ScripySelecaoNaves.Nave00visto.SetActive(false);
                ScripySelecaoNaves.comprado00 = true;
                ScripySelecaoNaves.imagecinza00.SetActive(true);
                ScripySelecaoNaves.BTcompra0.SetActive(false);

            }

            if (ValorCompra1 == 1)
            {
                ScripySelecaoNaves.Nave01visto.SetActive(true);
                ScripySelecaoNaves.comprado01 = true;
                ScripySelecaoNaves.imagecinza01.SetActive(false);
                ScripySelecaoNaves.BTcompra1.SetActive(false);

                ScripySelecaoNaves.Nave00.SetActive(false);
                ScripySelecaoNaves.Nave01.SetActive(true);
                ScripySelecaoNaves.Nave02.SetActive(false);
                ScripySelecaoNaves.Nave03.SetActive(false);
                ScripySelecaoNaves.Nave04.SetActive(false);
                ScripySelecaoNaves.Nave05.SetActive(false);
                ScripySelecaoNaves.Nave06.SetActive(false);
                ScripySelecaoNaves.Nave07.SetActive(false);
                ScripySelecaoNaves.Nave08.SetActive(false);
                ScripySelecaoNaves.Nave09.SetActive(false);
            }


            if (ValorCompra2 == 2)
            {
                ScripySelecaoNaves.Nave02visto.SetActive(false);
                ScripySelecaoNaves.comprado02 = true;
                ScripySelecaoNaves.imagecinza02.SetActive(true);
                ScripySelecaoNaves.BTcompra2.SetActive(false);

               
            }

            if (ValorCompra3 == 3)
            {
                ScripySelecaoNaves.Nave03visto.SetActive(false);
                ScripySelecaoNaves.comprado03 = true;
                ScripySelecaoNaves.imagecinza03.SetActive(true);
                ScripySelecaoNaves.BTcompra3.SetActive(false);

               
            }


            if (ValorCompra4 == 4)
            {
                ScripySelecaoNaves.Nave04visto.SetActive(false);
                ScripySelecaoNaves.comprado04 = true;
                ScripySelecaoNaves.imagecinza04.SetActive(true);
                ScripySelecaoNaves.BTcompra4.SetActive(false);

                
            }


            if (ValorCompra5 == 5)
            {
                ScripySelecaoNaves.Nave05visto.SetActive(false);
                ScripySelecaoNaves.comprado05 = true;
                ScripySelecaoNaves.imagecinza05.SetActive(true);
                ScripySelecaoNaves.BTcompra5.SetActive(false);

                
            }

            if (ValorCompra6 == 6)
            {
                ScripySelecaoNaves.Nave06visto.SetActive(false);
                ScripySelecaoNaves.comprado06 = true;
                ScripySelecaoNaves.imagecinza06.SetActive(true);
                ScripySelecaoNaves.BTcompra6.SetActive(false);

               
            }

            if (ValorCompra7 == 7)
            {
                ScripySelecaoNaves.Nave07visto.SetActive(false);
                ScripySelecaoNaves.comprado07 = true;
                ScripySelecaoNaves.imagecinza07.SetActive(true);
                ScripySelecaoNaves.BTcompra7.SetActive(false);

               
            }

            if (ValorCompra8 == 8)
            {
                ScripySelecaoNaves.Nave08visto.SetActive(false);
                ScripySelecaoNaves.comprado08 = true;
                ScripySelecaoNaves.imagecinza08.SetActive(true);
                ScripySelecaoNaves.BTcompra8.SetActive(false);

                
            }

            if (ValorCompra9 == 9)
            {
                ScripySelecaoNaves.Nave09visto.SetActive(false);
                ScripySelecaoNaves.comprado09 = true;
                ScripySelecaoNaves.imagecinza09.SetActive(true);
                ScripySelecaoNaves.BTcompra9.SetActive(false);

                
            }
           
        }

        if (ValorBancoNaves == 2)
        {
            if (ValorCompra0 == 0)
            {
                ScripySelecaoNaves.Nave00visto.SetActive(false);
                ScripySelecaoNaves.comprado00 = true;
                ScripySelecaoNaves.imagecinza00.SetActive(true);
                ScripySelecaoNaves.BTcompra0.SetActive(false);
            }

            if (ValorCompra1 == 1)
            {
                ScripySelecaoNaves.Nave01visto.SetActive(false);
                ScripySelecaoNaves.comprado01 = true;
                ScripySelecaoNaves.imagecinza01.SetActive(true);
                ScripySelecaoNaves.BTcompra1.SetActive(false);

            }


            if (ValorCompra2 == 2)
            {
                ScripySelecaoNaves.Nave02visto.SetActive(true);
                ScripySelecaoNaves.comprado02 = true;
                ScripySelecaoNaves.imagecinza02.SetActive(false);
                ScripySelecaoNaves.BTcompra2.SetActive(false);

                ScripySelecaoNaves.Nave00.SetActive(false);
                ScripySelecaoNaves.Nave01.SetActive(false);
                ScripySelecaoNaves.Nave02.SetActive(true);
                ScripySelecaoNaves.Nave03.SetActive(false);
                ScripySelecaoNaves.Nave04.SetActive(false);
                ScripySelecaoNaves.Nave05.SetActive(false);
                ScripySelecaoNaves.Nave06.SetActive(false);
                ScripySelecaoNaves.Nave07.SetActive(false);
                ScripySelecaoNaves.Nave08.SetActive(false);
                ScripySelecaoNaves.Nave09.SetActive(false);
            }

            if (ValorCompra3 == 3)
            {
                ScripySelecaoNaves.Nave03visto.SetActive(false);
                ScripySelecaoNaves.comprado03 = true;
                ScripySelecaoNaves.imagecinza03.SetActive(true);
                ScripySelecaoNaves.BTcompra3.SetActive(false);

              
            }


            if (ValorCompra4 == 4)
            {
                ScripySelecaoNaves.Nave04visto.SetActive(false);
                ScripySelecaoNaves.comprado04 = true;
                ScripySelecaoNaves.imagecinza04.SetActive(true);
                ScripySelecaoNaves.BTcompra4.SetActive(false);

               
            }


            if (ValorCompra5 == 5)
            {
                ScripySelecaoNaves.Nave05visto.SetActive(false);
                ScripySelecaoNaves.comprado05 = true;
                ScripySelecaoNaves.imagecinza05.SetActive(true);
                ScripySelecaoNaves.BTcompra5.SetActive(false);

               
            }

            if (ValorCompra6 == 6)
            {
                ScripySelecaoNaves.Nave06visto.SetActive(false);
                ScripySelecaoNaves.comprado06 = true;
                ScripySelecaoNaves.imagecinza06.SetActive(true);
                ScripySelecaoNaves.BTcompra6.SetActive(false);

               
            }

            if (ValorCompra7 == 7)
            {
                ScripySelecaoNaves.Nave07visto.SetActive(false);
                ScripySelecaoNaves.comprado07 = true;
                ScripySelecaoNaves.imagecinza07.SetActive(true);
                ScripySelecaoNaves.BTcompra7.SetActive(false);

              
            }

            if (ValorCompra8 == 8)
            {
                ScripySelecaoNaves.Nave08visto.SetActive(false);
                ScripySelecaoNaves.comprado08 = true;
                ScripySelecaoNaves.imagecinza08.SetActive(true);
                ScripySelecaoNaves.BTcompra8.SetActive(false);

              
            }

            if (ValorCompra9 == 9)
            {
                ScripySelecaoNaves.Nave09visto.SetActive(false);
                ScripySelecaoNaves.comprado09 = true;
                ScripySelecaoNaves.imagecinza09.SetActive(true);
                ScripySelecaoNaves.BTcompra9.SetActive(false);

               
            }

        }

        if (ValorBancoNaves == 3)
        {
            if (ValorCompra0 == 0)
            {
                ScripySelecaoNaves.Nave00visto.SetActive(false);
                ScripySelecaoNaves.comprado00 = true;
                ScripySelecaoNaves.imagecinza00.SetActive(true);
                ScripySelecaoNaves.BTcompra0.SetActive(false);
            }

            if (ValorCompra1 == 1)
            {
                ScripySelecaoNaves.Nave01visto.SetActive(false);
                ScripySelecaoNaves.comprado01 = true;
                ScripySelecaoNaves.imagecinza01.SetActive(true);
                ScripySelecaoNaves.BTcompra1.SetActive(false);

                
            }


            if (ValorCompra2 == 2)
            {
                ScripySelecaoNaves.Nave02visto.SetActive(false);
                ScripySelecaoNaves.comprado02 = true;
                ScripySelecaoNaves.imagecinza02.SetActive(true);
                ScripySelecaoNaves.BTcompra2.SetActive(false);

              
            }

            if (ValorCompra3 == 3)
            {
                ScripySelecaoNaves.Nave03visto.SetActive(true);
                ScripySelecaoNaves.comprado03 = true;
                ScripySelecaoNaves.imagecinza03.SetActive(false);
                ScripySelecaoNaves.BTcompra3.SetActive(false);

                ScripySelecaoNaves.Nave00.SetActive(false);
                ScripySelecaoNaves.Nave01.SetActive(false);
                ScripySelecaoNaves.Nave02.SetActive(false);
                ScripySelecaoNaves.Nave03.SetActive(true);
                ScripySelecaoNaves.Nave04.SetActive(false);
                ScripySelecaoNaves.Nave05.SetActive(false);
                ScripySelecaoNaves.Nave06.SetActive(false);
                ScripySelecaoNaves.Nave07.SetActive(false);
                ScripySelecaoNaves.Nave08.SetActive(false);
                ScripySelecaoNaves.Nave09.SetActive(false);
            }


            if (ValorCompra4 == 4)
            {
                ScripySelecaoNaves.Nave04visto.SetActive(false);
                ScripySelecaoNaves.comprado04 = true;
                ScripySelecaoNaves.imagecinza04.SetActive(true);
                ScripySelecaoNaves.BTcompra4.SetActive(false);

               
            }


            if (ValorCompra5 == 5)
            {
                ScripySelecaoNaves.Nave05visto.SetActive(false);
                ScripySelecaoNaves.comprado05 = true;
                ScripySelecaoNaves.imagecinza05.SetActive(true);
                ScripySelecaoNaves.BTcompra5.SetActive(false);

               
            }

            if (ValorCompra6 == 6)
            {
                ScripySelecaoNaves.Nave06visto.SetActive(false);
                ScripySelecaoNaves.comprado06 = true;
                ScripySelecaoNaves.imagecinza06.SetActive(true);
                ScripySelecaoNaves.BTcompra6.SetActive(false);

              
            }

            if (ValorCompra7 == 7)
            {
                ScripySelecaoNaves.Nave07visto.SetActive(false);
                ScripySelecaoNaves.comprado07 = true;
                ScripySelecaoNaves.imagecinza07.SetActive(true);
                ScripySelecaoNaves.BTcompra7.SetActive(false);

               
            }

            if (ValorCompra8 == 8)
            {
                ScripySelecaoNaves.Nave08visto.SetActive(false);
                ScripySelecaoNaves.comprado08 = true;
                ScripySelecaoNaves.imagecinza08.SetActive(true);
                ScripySelecaoNaves.BTcompra8.SetActive(false);

                
            }

            if (ValorCompra9 == 9)
            {
                ScripySelecaoNaves.Nave09visto.SetActive(false);
                ScripySelecaoNaves.comprado09 = true;
                ScripySelecaoNaves.imagecinza09.SetActive(true);
                ScripySelecaoNaves.BTcompra9.SetActive(false);

               
            }

        }

        if (ValorBancoNaves == 4)
        {
            if (ValorCompra0 == 0)
            {
                ScripySelecaoNaves.Nave00visto.SetActive(false);
                ScripySelecaoNaves.comprado00 = true;
                ScripySelecaoNaves.imagecinza00.SetActive(true);
                ScripySelecaoNaves.BTcompra0.SetActive(false);
            }

            if (ValorCompra1 == 1)
            {
                ScripySelecaoNaves.Nave01visto.SetActive(false);
                ScripySelecaoNaves.comprado01 = true;
                ScripySelecaoNaves.imagecinza01.SetActive(true);
                ScripySelecaoNaves.BTcompra1.SetActive(false);

               
            }


            if (ValorCompra2 == 2)
            {
                ScripySelecaoNaves.Nave02visto.SetActive(false);
                ScripySelecaoNaves.comprado02 = true;
                ScripySelecaoNaves.imagecinza02.SetActive(true);
                ScripySelecaoNaves.BTcompra2.SetActive(false);

               
            }

            if (ValorCompra3 == 3)
            {
                ScripySelecaoNaves.Nave03visto.SetActive(false);
                ScripySelecaoNaves.comprado03 = true;
                ScripySelecaoNaves.imagecinza03.SetActive(true);
                ScripySelecaoNaves.BTcompra3.SetActive(false);

                
            }


            if (ValorCompra4 == 4)
            {
                ScripySelecaoNaves.Nave04visto.SetActive(true);
                ScripySelecaoNaves.comprado04 = true;
                ScripySelecaoNaves.imagecinza04.SetActive(false);
                ScripySelecaoNaves.BTcompra4.SetActive(false);

                ScripySelecaoNaves.Nave00.SetActive(false);
                ScripySelecaoNaves.Nave01.SetActive(false);
                ScripySelecaoNaves.Nave02.SetActive(false);
                ScripySelecaoNaves.Nave03.SetActive(false);
                ScripySelecaoNaves.Nave04.SetActive(true);
                ScripySelecaoNaves.Nave05.SetActive(false);
                ScripySelecaoNaves.Nave06.SetActive(false);
                ScripySelecaoNaves.Nave07.SetActive(false);
                ScripySelecaoNaves.Nave08.SetActive(false);
                ScripySelecaoNaves.Nave09.SetActive(false);
            }


            if (ValorCompra5 == 5)
            {
                ScripySelecaoNaves.Nave05visto.SetActive(false);
                ScripySelecaoNaves.comprado05 = true;
                ScripySelecaoNaves.imagecinza05.SetActive(true);
                ScripySelecaoNaves.BTcompra5.SetActive(false);

               
            }

            if (ValorCompra6 == 6)
            {
                ScripySelecaoNaves.Nave06visto.SetActive(false);
                ScripySelecaoNaves.comprado06 = true;
                ScripySelecaoNaves.imagecinza06.SetActive(true);
                ScripySelecaoNaves.BTcompra6.SetActive(false);

                
            }

            if (ValorCompra7 == 7)
            {
                ScripySelecaoNaves.Nave07visto.SetActive(false);
                ScripySelecaoNaves.comprado07 = true;
                ScripySelecaoNaves.imagecinza07.SetActive(true);
                ScripySelecaoNaves.BTcompra7.SetActive(false);

               
            }

            if (ValorCompra8 == 8)
            {
                ScripySelecaoNaves.Nave08visto.SetActive(false);
                ScripySelecaoNaves.comprado08 = true;
                ScripySelecaoNaves.imagecinza08.SetActive(true);
                ScripySelecaoNaves.BTcompra8.SetActive(false);

               
            }

            if (ValorCompra9 == 9)
            {
                ScripySelecaoNaves.Nave09visto.SetActive(false);
                ScripySelecaoNaves.comprado09 = true;
                ScripySelecaoNaves.imagecinza09.SetActive(true);
                ScripySelecaoNaves.BTcompra9.SetActive(false);

               
            }

        }

        if (ValorBancoNaves == 5)
        {
            if (ValorCompra0 == 0)
            {
                ScripySelecaoNaves.Nave00visto.SetActive(false);
                ScripySelecaoNaves.comprado00 = true;
                ScripySelecaoNaves.imagecinza00.SetActive(true);
                ScripySelecaoNaves.BTcompra0.SetActive(false);
            }

            if (ValorCompra1 == 1)
            {
                ScripySelecaoNaves.Nave01visto.SetActive(false);
                ScripySelecaoNaves.comprado01 = true;
                ScripySelecaoNaves.imagecinza01.SetActive(true);
                ScripySelecaoNaves.BTcompra1.SetActive(false);

              
            }


            if (ValorCompra2 == 2)
            {
                ScripySelecaoNaves.Nave02visto.SetActive(false);
                ScripySelecaoNaves.comprado02 = true;
                ScripySelecaoNaves.imagecinza02.SetActive(true);
                ScripySelecaoNaves.BTcompra2.SetActive(false);

               
            }

            if (ValorCompra3 == 3)
            {
                ScripySelecaoNaves.Nave03visto.SetActive(false);
                ScripySelecaoNaves.comprado03 = true;
                ScripySelecaoNaves.imagecinza03.SetActive(true);
                ScripySelecaoNaves.BTcompra3.SetActive(false);

              
            }


            if (ValorCompra4 == 4)
            {
                ScripySelecaoNaves.Nave04visto.SetActive(false);
                ScripySelecaoNaves.comprado04 = true;
                ScripySelecaoNaves.imagecinza04.SetActive(true);
                ScripySelecaoNaves.BTcompra4.SetActive(false);

               
            }


            if (ValorCompra5 == 5)
            {
                ScripySelecaoNaves.Nave05visto.SetActive(true);
                ScripySelecaoNaves.comprado05 = true;
                ScripySelecaoNaves.imagecinza05.SetActive(false);
                ScripySelecaoNaves.BTcompra5.SetActive(false);

                ScripySelecaoNaves.Nave00.SetActive(false);
                ScripySelecaoNaves.Nave01.SetActive(false);
                ScripySelecaoNaves.Nave02.SetActive(false);
                ScripySelecaoNaves.Nave03.SetActive(false);
                ScripySelecaoNaves.Nave04.SetActive(false);
                ScripySelecaoNaves.Nave05.SetActive(true);
                ScripySelecaoNaves.Nave06.SetActive(false);
                ScripySelecaoNaves.Nave07.SetActive(false);
                ScripySelecaoNaves.Nave08.SetActive(false);
                ScripySelecaoNaves.Nave09.SetActive(false);
            }

            if (ValorCompra6 == 6)
            {
                ScripySelecaoNaves.Nave06visto.SetActive(false);
                ScripySelecaoNaves.comprado06 = true;
                ScripySelecaoNaves.imagecinza06.SetActive(true);
                ScripySelecaoNaves.BTcompra6.SetActive(false);

                
            }

            if (ValorCompra7 == 7)
            {
                ScripySelecaoNaves.Nave07visto.SetActive(false);
                ScripySelecaoNaves.comprado07 = true;
                ScripySelecaoNaves.imagecinza07.SetActive(true);
                ScripySelecaoNaves.BTcompra7.SetActive(false);

               
            }

            if (ValorCompra8 == 8)
            {
                ScripySelecaoNaves.Nave08visto.SetActive(false);
                ScripySelecaoNaves.comprado08 = true;
                ScripySelecaoNaves.imagecinza08.SetActive(true);
                ScripySelecaoNaves.BTcompra8.SetActive(false);

               
            }

            if (ValorCompra9 == 9)
            {
                ScripySelecaoNaves.Nave09visto.SetActive(false);
                ScripySelecaoNaves.comprado09 = true;
                ScripySelecaoNaves.imagecinza09.SetActive(true);
                ScripySelecaoNaves.BTcompra9.SetActive(false);

               
            }

        }

        if (ValorBancoNaves == 6)
        {
            if (ValorCompra0 == 0)
            {
                ScripySelecaoNaves.Nave00visto.SetActive(false);
                ScripySelecaoNaves.comprado00 = true;
                ScripySelecaoNaves.imagecinza00.SetActive(true);
                ScripySelecaoNaves.BTcompra0.SetActive(false);
            }

            if (ValorCompra1 == 1)
            {
                ScripySelecaoNaves.Nave01visto.SetActive(false);
                ScripySelecaoNaves.comprado01 = true;
                ScripySelecaoNaves.imagecinza01.SetActive(true);
                ScripySelecaoNaves.BTcompra1.SetActive(false);

              
            }


            if (ValorCompra2 == 2)
            {
                ScripySelecaoNaves.Nave02visto.SetActive(false);
                ScripySelecaoNaves.comprado02 = true;
                ScripySelecaoNaves.imagecinza02.SetActive(true);
                ScripySelecaoNaves.BTcompra2.SetActive(false);

               
            }

            if (ValorCompra3 == 3)
            {
                ScripySelecaoNaves.Nave03visto.SetActive(false);
                ScripySelecaoNaves.comprado03 = true;
                ScripySelecaoNaves.imagecinza03.SetActive(true);
                ScripySelecaoNaves.BTcompra3.SetActive(false);

               
            }


            if (ValorCompra4 == 4)
            {
                ScripySelecaoNaves.Nave04visto.SetActive(false);
                ScripySelecaoNaves.comprado04 = true;
                ScripySelecaoNaves.imagecinza04.SetActive(true);
                ScripySelecaoNaves.BTcompra4.SetActive(false);

               
            }


            if (ValorCompra5 == 5)
            {
                ScripySelecaoNaves.Nave05visto.SetActive(false);
                ScripySelecaoNaves.comprado05 = true;
                ScripySelecaoNaves.imagecinza05.SetActive(true);
                ScripySelecaoNaves.BTcompra5.SetActive(false);

                
            }

            if (ValorCompra6 == 6)
            {
                ScripySelecaoNaves.Nave06visto.SetActive(true);
                ScripySelecaoNaves.comprado06 = true;
                ScripySelecaoNaves.imagecinza06.SetActive(false);
                ScripySelecaoNaves.BTcompra6.SetActive(false);

                ScripySelecaoNaves.Nave00.SetActive(false);
                ScripySelecaoNaves.Nave01.SetActive(false);
                ScripySelecaoNaves.Nave02.SetActive(false);
                ScripySelecaoNaves.Nave03.SetActive(false);
                ScripySelecaoNaves.Nave04.SetActive(false);
                ScripySelecaoNaves.Nave05.SetActive(false);
                ScripySelecaoNaves.Nave06.SetActive(true);
                ScripySelecaoNaves.Nave07.SetActive(false);
                ScripySelecaoNaves.Nave08.SetActive(false);
                ScripySelecaoNaves.Nave09.SetActive(false);
            }

            if (ValorCompra7 == 7)
            {
                ScripySelecaoNaves.Nave07visto.SetActive(false);
                ScripySelecaoNaves.comprado07 = true;
                ScripySelecaoNaves.imagecinza07.SetActive(true);
                ScripySelecaoNaves.BTcompra7.SetActive(false);

               
            }

            if (ValorCompra8 == 8)
            {
                ScripySelecaoNaves.Nave08visto.SetActive(false);
                ScripySelecaoNaves.comprado08 = true;
                ScripySelecaoNaves.imagecinza08.SetActive(true);
                ScripySelecaoNaves.BTcompra8.SetActive(false);

                
            }

            if (ValorCompra9 == 9)
            {
                ScripySelecaoNaves.Nave09visto.SetActive(false);
                ScripySelecaoNaves.comprado09 = true;
                ScripySelecaoNaves.imagecinza09.SetActive(true);
                ScripySelecaoNaves.BTcompra9.SetActive(false);

                
            }

        }

        if (ValorBancoNaves == 7)
        {
            if (ValorCompra0 == 0)
            {
                ScripySelecaoNaves.Nave00visto.SetActive(false);
                ScripySelecaoNaves.comprado00 = true;
                ScripySelecaoNaves.imagecinza00.SetActive(true);
                ScripySelecaoNaves.BTcompra0.SetActive(false);
            }

            if (ValorCompra1 == 1)
            {
                ScripySelecaoNaves.Nave01visto.SetActive(false);
                ScripySelecaoNaves.comprado01 = true;
                ScripySelecaoNaves.imagecinza01.SetActive(true);
                ScripySelecaoNaves.BTcompra1.SetActive(false);

               
            }


            if (ValorCompra2 == 2)
            {
                ScripySelecaoNaves.Nave02visto.SetActive(false);
                ScripySelecaoNaves.comprado02 = true;
                ScripySelecaoNaves.imagecinza02.SetActive(true);
                ScripySelecaoNaves.BTcompra2.SetActive(false);

               
            }

            if (ValorCompra3 == 3)
            {
                ScripySelecaoNaves.Nave03visto.SetActive(false);
                ScripySelecaoNaves.comprado03 = true;
                ScripySelecaoNaves.imagecinza03.SetActive(true);
                ScripySelecaoNaves.BTcompra3.SetActive(false);

                
            }


            if (ValorCompra4 == 4)
            {
                ScripySelecaoNaves.Nave04visto.SetActive(false);
                ScripySelecaoNaves.comprado04 = true;
                ScripySelecaoNaves.imagecinza04.SetActive(true);
                ScripySelecaoNaves.BTcompra4.SetActive(false);

                
            }


            if (ValorCompra5 == 5)
            {
                ScripySelecaoNaves.Nave05visto.SetActive(false);
                ScripySelecaoNaves.comprado05 = true;
                ScripySelecaoNaves.imagecinza05.SetActive(true);
                ScripySelecaoNaves.BTcompra5.SetActive(false);

                
            }

            if (ValorCompra6 == 6)
            {
                ScripySelecaoNaves.Nave06visto.SetActive(false);
                ScripySelecaoNaves.comprado06 = true;
                ScripySelecaoNaves.imagecinza06.SetActive(true);
                ScripySelecaoNaves.BTcompra6.SetActive(false);

               
            }

            if (ValorCompra7 == 7)
            {
                ScripySelecaoNaves.Nave07visto.SetActive(true);
                ScripySelecaoNaves.comprado07 = true;
                ScripySelecaoNaves.imagecinza07.SetActive(false);
                ScripySelecaoNaves.BTcompra7.SetActive(false);

                ScripySelecaoNaves.Nave00.SetActive(false);
                ScripySelecaoNaves.Nave01.SetActive(false);
                ScripySelecaoNaves.Nave02.SetActive(false);
                ScripySelecaoNaves.Nave03.SetActive(false);
                ScripySelecaoNaves.Nave04.SetActive(false);
                ScripySelecaoNaves.Nave05.SetActive(false);
                ScripySelecaoNaves.Nave06.SetActive(false);
                ScripySelecaoNaves.Nave07.SetActive(true);
                ScripySelecaoNaves.Nave08.SetActive(false);
                ScripySelecaoNaves.Nave09.SetActive(false);
            }

            if (ValorCompra8 == 8)
            {
                ScripySelecaoNaves.Nave08visto.SetActive(false);
                ScripySelecaoNaves.comprado08 = true;
                ScripySelecaoNaves.imagecinza08.SetActive(true);
                ScripySelecaoNaves.BTcompra8.SetActive(false);

                
            }

            if (ValorCompra9 == 9)
            {
                ScripySelecaoNaves.Nave09visto.SetActive(false);
                ScripySelecaoNaves.comprado09 = true;
                ScripySelecaoNaves.imagecinza09.SetActive(true);
                ScripySelecaoNaves.BTcompra9.SetActive(false);

                
            }

        }

        if (ValorBancoNaves == 8)
        {
            if (ValorCompra0 == 0)
            {
                ScripySelecaoNaves.Nave00visto.SetActive(false);
                ScripySelecaoNaves.comprado00 = true;
                ScripySelecaoNaves.imagecinza00.SetActive(true);
                ScripySelecaoNaves.BTcompra0.SetActive(false);
            }

            if (ValorCompra1 == 1)
            {
                ScripySelecaoNaves.Nave01visto.SetActive(false);
                ScripySelecaoNaves.comprado01 = true;
                ScripySelecaoNaves.imagecinza01.SetActive(true);
                ScripySelecaoNaves.BTcompra1.SetActive(false);

                
            }


            if (ValorCompra2 == 2)
            {
                ScripySelecaoNaves.Nave02visto.SetActive(false);
                ScripySelecaoNaves.comprado02 = true;
                ScripySelecaoNaves.imagecinza02.SetActive(true);
                ScripySelecaoNaves.BTcompra2.SetActive(false);

                
            }

            if (ValorCompra3 == 3)
            {
                ScripySelecaoNaves.Nave03visto.SetActive(false);
                ScripySelecaoNaves.comprado03 = true;
                ScripySelecaoNaves.imagecinza03.SetActive(true);
                ScripySelecaoNaves.BTcompra3.SetActive(false);

                
            }


            if (ValorCompra4 == 4)
            {
                ScripySelecaoNaves.Nave04visto.SetActive(false);
                ScripySelecaoNaves.comprado04 = true;
                ScripySelecaoNaves.imagecinza04.SetActive(true);
                ScripySelecaoNaves.BTcompra4.SetActive(false);

                
            }


            if (ValorCompra5 == 5)
            {
                ScripySelecaoNaves.Nave05visto.SetActive(false);
                ScripySelecaoNaves.comprado05 = true;
                ScripySelecaoNaves.imagecinza05.SetActive(true);
                ScripySelecaoNaves.BTcompra5.SetActive(false);

                
            }

            if (ValorCompra6 == 6)
            {
                ScripySelecaoNaves.Nave06visto.SetActive(false);
                ScripySelecaoNaves.comprado06 = true;
                ScripySelecaoNaves.imagecinza06.SetActive(true);
                ScripySelecaoNaves.BTcompra6.SetActive(false);

                
            }

            if (ValorCompra7 == 7)
            {
                ScripySelecaoNaves.Nave07visto.SetActive(false);
                ScripySelecaoNaves.comprado07 = true;
                ScripySelecaoNaves.imagecinza07.SetActive(true);
                ScripySelecaoNaves.BTcompra7.SetActive(false);

                
            }

            if (ValorCompra8 == 8)
            {
                ScripySelecaoNaves.Nave08visto.SetActive(true);
                ScripySelecaoNaves.comprado08 = true;
                ScripySelecaoNaves.imagecinza08.SetActive(false);
                ScripySelecaoNaves.BTcompra8.SetActive(false);

                ScripySelecaoNaves.Nave00.SetActive(false);
                ScripySelecaoNaves.Nave01.SetActive(false);
                ScripySelecaoNaves.Nave02.SetActive(false);
                ScripySelecaoNaves.Nave03.SetActive(false);
                ScripySelecaoNaves.Nave04.SetActive(false);
                ScripySelecaoNaves.Nave05.SetActive(false);
                ScripySelecaoNaves.Nave06.SetActive(false);
                ScripySelecaoNaves.Nave07.SetActive(false);
                ScripySelecaoNaves.Nave08.SetActive(true);
                ScripySelecaoNaves.Nave09.SetActive(false);
            }

            if (ValorCompra9 == 9)
            {
                ScripySelecaoNaves.Nave09visto.SetActive(false);
                ScripySelecaoNaves.comprado09 = true;
                ScripySelecaoNaves.imagecinza09.SetActive(true);
                ScripySelecaoNaves.BTcompra9.SetActive(false);

                
            }

        }

        if (ValorBancoNaves == 9)
        {
            if (ValorCompra0 == 0)
            {
                ScripySelecaoNaves.Nave00visto.SetActive(false);
                ScripySelecaoNaves.comprado00 = true;
                ScripySelecaoNaves.imagecinza00.SetActive(true);
                ScripySelecaoNaves.BTcompra0.SetActive(false);
            }

            if (ValorCompra1 == 1)
            {
                ScripySelecaoNaves.Nave01visto.SetActive(false);
                ScripySelecaoNaves.comprado01 = true;
                ScripySelecaoNaves.imagecinza01.SetActive(true);
                ScripySelecaoNaves.BTcompra1.SetActive(false);

                
            }


            if (ValorCompra2 == 2)
            {
                ScripySelecaoNaves.Nave02visto.SetActive(false);
                ScripySelecaoNaves.comprado02 = true;
                ScripySelecaoNaves.imagecinza02.SetActive(true);
                ScripySelecaoNaves.BTcompra2.SetActive(false);

               
            }

            if (ValorCompra3 == 3)
            {
                ScripySelecaoNaves.Nave03visto.SetActive(false);
                ScripySelecaoNaves.comprado03 = true;
                ScripySelecaoNaves.imagecinza03.SetActive(true);
                ScripySelecaoNaves.BTcompra3.SetActive(false);

              
            }


            if (ValorCompra4 == 4)
            {
                ScripySelecaoNaves.Nave04visto.SetActive(false);
                ScripySelecaoNaves.comprado04 = true;
                ScripySelecaoNaves.imagecinza04.SetActive(true);
                ScripySelecaoNaves.BTcompra4.SetActive(false);

              
            }


            if (ValorCompra5 == 5)
            {
                ScripySelecaoNaves.Nave05visto.SetActive(false);
                ScripySelecaoNaves.comprado05 = true;
                ScripySelecaoNaves.imagecinza05.SetActive(true);
                ScripySelecaoNaves.BTcompra5.SetActive(false);

               
            }

            if (ValorCompra6 == 6)
            {
                ScripySelecaoNaves.Nave06visto.SetActive(false);
                ScripySelecaoNaves.comprado06 = true;
                ScripySelecaoNaves.imagecinza06.SetActive(true);
                ScripySelecaoNaves.BTcompra6.SetActive(false);

               
            }

            if (ValorCompra7 == 7)
            {
                ScripySelecaoNaves.Nave07visto.SetActive(false);
                ScripySelecaoNaves.comprado07 = true;
                ScripySelecaoNaves.imagecinza07.SetActive(true);
                ScripySelecaoNaves.BTcompra7.SetActive(false);

                
            }

            if (ValorCompra8 == 8)
            {
                ScripySelecaoNaves.Nave08visto.SetActive(false);
                ScripySelecaoNaves.comprado08 = true;
                ScripySelecaoNaves.imagecinza08.SetActive(true);
                ScripySelecaoNaves.BTcompra8.SetActive(false);

               
            }

            if (ValorCompra9 == 9)
            {
                ScripySelecaoNaves.Nave09visto.SetActive(true);
                ScripySelecaoNaves.comprado09 = true;
                ScripySelecaoNaves.imagecinza09.SetActive(false);
                ScripySelecaoNaves.BTcompra9.SetActive(false);

                ScripySelecaoNaves.Nave00.SetActive(false);
                ScripySelecaoNaves.Nave01.SetActive(false);
                ScripySelecaoNaves.Nave02.SetActive(false);
                ScripySelecaoNaves.Nave03.SetActive(false);
                ScripySelecaoNaves.Nave04.SetActive(false);
                ScripySelecaoNaves.Nave05.SetActive(false);
                ScripySelecaoNaves.Nave06.SetActive(false);
                ScripySelecaoNaves.Nave07.SetActive(false);
                ScripySelecaoNaves.Nave08.SetActive(false);
                ScripySelecaoNaves.Nave09.SetActive(true);

            }

        }

        return ValorBancoNaves;
       
    }

    public int RetornaCompras0()
    {
        ValorCompra0 = PlayerPrefs.GetInt("Compras0");
        return ValorCompra0;
    }
    public int RetornaCompras1()
    {
        ValorCompra1 = PlayerPrefs.GetInt("Compras1");
        return ValorCompra1;
    }
    public int RetornaCompras2()
    {
        ValorCompra2 = PlayerPrefs.GetInt("Compras2");
        return ValorCompra2;
    }

    public int RetornaCompras3()
    {
        ValorCompra3 = PlayerPrefs.GetInt("Compras3");
        return ValorCompra3;
    }

    public int RetornaCompras4()
    {
        ValorCompra4 = PlayerPrefs.GetInt("Compras4");
        return ValorCompra4;
    }
    public int RetornaCompras5()
    {
        ValorCompra5 = PlayerPrefs.GetInt("Compras5");
        return ValorCompra5;
    }
    public int RetornaCompras6()
    {
        ValorCompra6 = PlayerPrefs.GetInt("Compras6");
        return ValorCompra6;
    }
    public int RetornaCompras7()
    {
        ValorCompra7 = PlayerPrefs.GetInt("Compras7");
        return ValorCompra7;
    }
    public int RetornaCompras8()
    {
        ValorCompra8 = PlayerPrefs.GetInt("Compras8");
        return ValorCompra8;
    }

    public int RetornaCompras9()
    {
        ValorCompra9 = PlayerPrefs.GetInt("Compras9");
        return ValorCompra9;
    }

}
