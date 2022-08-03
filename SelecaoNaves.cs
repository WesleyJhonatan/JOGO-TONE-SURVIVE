using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelecaoNaves : MonoBehaviour
{
    private Gerenciador GJ;
    private Banco BC;
    public GameObject Nave00visto;
    public GameObject Nave01visto;
    public GameObject Nave02visto;
    public GameObject Nave03visto;
    public GameObject Nave04visto;
    public GameObject Nave05visto;
    public GameObject Nave06visto;
    public GameObject Nave07visto;
    public GameObject Nave08visto;
    public GameObject Nave09visto;

    public GameObject imagecinza00;
    public GameObject imagecinza01;
    public GameObject imagecinza02;
    public GameObject imagecinza03;
    public GameObject imagecinza04;
    public GameObject imagecinza05;
    public GameObject imagecinza06;
    public GameObject imagecinza07;
    public GameObject imagecinza08;
    public GameObject imagecinza09;

    public GameObject Nave00;
    public GameObject Nave01;
    public GameObject Nave02;
    public GameObject Nave03;
    public GameObject Nave04;
    public GameObject Nave05;
    public GameObject Nave06;
    public GameObject Nave07;
    public GameObject Nave08;
    public GameObject Nave09;

    public GameObject BTcompra0;
    public GameObject BTcompra1;
    public GameObject BTcompra2;
    public GameObject BTcompra3;
    public GameObject BTcompra4;
    public GameObject BTcompra5;
    public GameObject BTcompra6;
    public GameObject BTcompra7;
    public GameObject BTcompra8;
    public GameObject BTcompra9;

    public bool comprado00 = false;
    public bool comprado01 = false;
    public bool comprado02 = false;
    public bool comprado03 = false;
    public bool comprado04 = false;
    public bool comprado05 = false;
    public bool comprado06 = false;
    public bool comprado07 = false;
    public bool comprado08 = false;
    public bool comprado09 = false;

    public int OURO = 0;

    public GameObject TelaAviso;
    public int Valor;
    public int ValorQualComprei0;
    public int ValorQualComprei1;
    public int ValorQualComprei2;
    public int ValorQualComprei3;
    public int ValorQualComprei4;
    public int ValorQualComprei5;
    public int ValorQualComprei6;
    public int ValorQualComprei7;
    public int ValorQualComprei8;
    public int ValorQualComprei9;

    void Start()
    {

        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<Gerenciador>();
        BC = GameObject.FindGameObjectWithTag("GameController").GetComponent<Banco>();


    }

    void Update()
    {
        OURO = BC.InformarValorBanco();
        ValorQualComprei0 = BC.ValorCompra0;
        ValorQualComprei1 = BC.ValorCompra1;
        ValorQualComprei2 = BC.ValorCompra2;
        ValorQualComprei3 = BC.ValorCompra3;
        ValorQualComprei4 = BC.ValorCompra4;
        ValorQualComprei5 = BC.ValorCompra5;
        ValorQualComprei6 = BC.ValorCompra6;
        ValorQualComprei7 = BC.ValorCompra7;
        ValorQualComprei8 = BC.ValorCompra8;
        ValorQualComprei9 = BC.ValorCompra9;
    }
    public void BT00()
    {

            Nave00visto.SetActive(true);
            Nave01visto.SetActive(false);
            Nave02visto.SetActive(false);
            Nave03visto.SetActive(false);
            Nave04visto.SetActive(false);
            Nave05visto.SetActive(false);
            Nave06visto.SetActive(false);
            Nave07visto.SetActive(false);
            Nave08visto.SetActive(false);
            Nave09visto.SetActive(false);

            imagecinza00.SetActive(false);
            imagecinza01.SetActive(true);
            imagecinza02.SetActive(true);
            imagecinza03.SetActive(true);
            imagecinza04.SetActive(true);
            imagecinza05.SetActive(true);
            imagecinza06.SetActive(true);
            imagecinza07.SetActive(true);
            imagecinza08.SetActive(true);
            imagecinza09.SetActive(true);

            Nave00.SetActive(true);
            Nave01.SetActive(false);
            Nave02.SetActive(false);
            Nave03.SetActive(false);
            Nave04.SetActive(false);
            Nave05.SetActive(false);
            Nave06.SetActive(false);
            Nave07.SetActive(false);
            Nave08.SetActive(false);
            Nave09.SetActive(false);

        Valor = 0;
        ValorQualComprei0 = 0;
        GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);
        GJ.RecebeSelecaoNaves(Valor);




    }
    public void BT01()
    {
        if (comprado01 == false)
        {
            TelaAviso.SetActive(true);
            Valor = 1;
        }
            

        if(comprado01 == true)
        {
            Nave01visto.SetActive(true);
            Nave00visto.SetActive(false);
            Nave02visto.SetActive(false);
            Nave03visto.SetActive(false);
            Nave04visto.SetActive(false);
            Nave05visto.SetActive(false);
            Nave06visto.SetActive(false);
            Nave07visto.SetActive(false);
            Nave08visto.SetActive(false);
            Nave09visto.SetActive(false);

            imagecinza00.SetActive(true);
            imagecinza01.SetActive(false);
            imagecinza02.SetActive(true);
            imagecinza03.SetActive(true);
            imagecinza04.SetActive(true);
            imagecinza05.SetActive(true);
            imagecinza06.SetActive(true);
            imagecinza07.SetActive(true);
            imagecinza08.SetActive(true);
            imagecinza09.SetActive(true);

            Nave00.SetActive(false);
            Nave01.SetActive(true);
            Nave02.SetActive(false);
            Nave03.SetActive(false);
            Nave04.SetActive(false);
            Nave05.SetActive(false);
            Nave06.SetActive(false);
            Nave07.SetActive(false);
            Nave08.SetActive(false);
            Nave09.SetActive(false);

            Valor = 1;
            ValorQualComprei1 = 1;
            GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);
            GJ.RecebeSelecaoNaves(Valor);
        }
    }

    public void BT02()
    {
        if (comprado02 == false)
        {
            TelaAviso.SetActive(true);
            Valor = 2;
        }
           

        if(comprado02 == true)
        {
            Nave02visto.SetActive(true);
            Nave00visto.SetActive(false);
            Nave01visto.SetActive(false);
            Nave03visto.SetActive(false);
            Nave04visto.SetActive(false);
            Nave05visto.SetActive(false);
            Nave06visto.SetActive(false);
            Nave07visto.SetActive(false);
            Nave08visto.SetActive(false);
            Nave09visto.SetActive(false);

            imagecinza00.SetActive(true);
            imagecinza01.SetActive(true);
            imagecinza02.SetActive(false);
            imagecinza03.SetActive(true);
            imagecinza04.SetActive(true);
            imagecinza05.SetActive(true);
            imagecinza06.SetActive(true);
            imagecinza07.SetActive(true);
            imagecinza08.SetActive(true);
            imagecinza09.SetActive(true);

            Nave00.SetActive(false);
            Nave01.SetActive(false);
            Nave02.SetActive(true);
            Nave03.SetActive(false);
            Nave04.SetActive(false);
            Nave05.SetActive(false);
            Nave06.SetActive(false);
            Nave07.SetActive(false);
            Nave08.SetActive(false);
            Nave09.SetActive(false);

            Valor = 2;
            ValorQualComprei2 = 2;
            GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);
            GJ.RecebeSelecaoNaves(Valor);
        }
    }

    public void BT03()
    {
        if (comprado03 == false)
        {
            TelaAviso.SetActive(true);
            Valor = 3;

        }

        if (comprado03 == true)
        {
            Nave03visto.SetActive(true);
            Nave00visto.SetActive(false);
            Nave01visto.SetActive(false);
            Nave02visto.SetActive(false);
            Nave04visto.SetActive(false);
            Nave05visto.SetActive(false);
            Nave06visto.SetActive(false);
            Nave07visto.SetActive(false);
            Nave08visto.SetActive(false);
            Nave09visto.SetActive(false);

            imagecinza00.SetActive(true);
            imagecinza01.SetActive(true);
            imagecinza02.SetActive(true);
            imagecinza03.SetActive(false);
            imagecinza04.SetActive(true);
            imagecinza05.SetActive(true);
            imagecinza06.SetActive(true);
            imagecinza07.SetActive(true);
            imagecinza08.SetActive(true);
            imagecinza09.SetActive(true);

            Nave00.SetActive(false);
            Nave01.SetActive(false);
            Nave02.SetActive(false);
            Nave03.SetActive(true);
            Nave04.SetActive(false);
            Nave05.SetActive(false);
            Nave06.SetActive(false);
            Nave07.SetActive(false);
            Nave08.SetActive(false);
            Nave09.SetActive(false);

            Valor = 3;
            ValorQualComprei3 = 3;
            GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);
            GJ.RecebeSelecaoNaves(Valor);
        }
    }

    public void BT04()
    {

        if (comprado04 == false)
        {
            TelaAviso.SetActive(true);
            Valor = 4;
        }
           

        if(comprado04 == true)
        {
            Nave04visto.SetActive(true);
            Nave00visto.SetActive(false);
            Nave01visto.SetActive(false);
            Nave02visto.SetActive(false);
            Nave03visto.SetActive(false);
            Nave05visto.SetActive(false);
            Nave06visto.SetActive(false);
            Nave07visto.SetActive(false);
            Nave08visto.SetActive(false);
            Nave09visto.SetActive(false);

            imagecinza00.SetActive(true);
            imagecinza01.SetActive(true);
            imagecinza02.SetActive(true);
            imagecinza03.SetActive(true);
            imagecinza04.SetActive(false);
            imagecinza05.SetActive(true);
            imagecinza06.SetActive(true);
            imagecinza07.SetActive(true);
            imagecinza08.SetActive(true);
            imagecinza09.SetActive(true);

            Nave00.SetActive(false);
            Nave01.SetActive(false);
            Nave02.SetActive(false);
            Nave03.SetActive(false);
            Nave04.SetActive(true);
            Nave05.SetActive(false);
            Nave06.SetActive(false);
            Nave07.SetActive(false);
            Nave08.SetActive(false);
            Nave09.SetActive(false);

            Valor = 4;
            ValorQualComprei4 = 4;
            GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);
            GJ.RecebeSelecaoNaves(Valor);
        }
    }

    public void BT05()
    {
        if (comprado05 == false)
        {

            TelaAviso.SetActive(true);
            Valor = 5;
        }

        if(comprado05 == true)
        {
            Nave05visto.SetActive(true);
            Nave00visto.SetActive(false);
            Nave01visto.SetActive(false);
            Nave02visto.SetActive(false);
            Nave03visto.SetActive(false);
            Nave04visto.SetActive(false);
            Nave06visto.SetActive(false);
            Nave07visto.SetActive(false);
            Nave08visto.SetActive(false);
            Nave09visto.SetActive(false);

            imagecinza00.SetActive(true);
            imagecinza01.SetActive(true);
            imagecinza02.SetActive(true);
            imagecinza03.SetActive(true);
            imagecinza04.SetActive(true);
            imagecinza05.SetActive(false);
            imagecinza06.SetActive(true);
            imagecinza07.SetActive(true);
            imagecinza08.SetActive(true);
            imagecinza09.SetActive(true);

            Nave00.SetActive(false);
            Nave01.SetActive(false);
            Nave02.SetActive(false);
            Nave03.SetActive(false);
            Nave04.SetActive(false);
            Nave05.SetActive(true);
            Nave06.SetActive(false);
            Nave07.SetActive(false);
            Nave08.SetActive(false);
            Nave09.SetActive(false);

            Valor = 5;
            ValorQualComprei5 = 5;
            GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);
            GJ.RecebeSelecaoNaves(Valor);
        }
    }

    public void BT06()
    {
        if (comprado06 == false)
        {
            TelaAviso.SetActive(true);
            Valor = 6;
        }
            

        if(comprado06 == true)
        {
            Nave06visto.SetActive(true);
            Nave00visto.SetActive(false);
            Nave01visto.SetActive(false);
            Nave02visto.SetActive(false);
            Nave03visto.SetActive(false);
            Nave04visto.SetActive(false);
            Nave05visto.SetActive(false);
            Nave07visto.SetActive(false);
            Nave08visto.SetActive(false);
            Nave09visto.SetActive(false);

            imagecinza00.SetActive(true);
            imagecinza01.SetActive(true);
            imagecinza02.SetActive(true);
            imagecinza03.SetActive(true);
            imagecinza04.SetActive(true);
            imagecinza05.SetActive(true);
            imagecinza06.SetActive(false);
            imagecinza07.SetActive(true);
            imagecinza08.SetActive(true);
            imagecinza09.SetActive(true);

            Nave00.SetActive(false);
            Nave01.SetActive(false);
            Nave02.SetActive(false);
            Nave03.SetActive(false);
            Nave04.SetActive(false);
            Nave05.SetActive(false);
            Nave06.SetActive(true);
            Nave07.SetActive(false);
            Nave08.SetActive(false);
            Nave09.SetActive(false);

            Valor = 6;
            ValorQualComprei6 = 6;
            GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);
            GJ.RecebeSelecaoNaves(Valor);
        }
    }

    public void BT07()
    {
        if (comprado07 == false)
        {

            TelaAviso.SetActive(true);
            Valor = 7;
        }


        if(comprado07 == true)
        {
            Nave07visto.SetActive(true);
            Nave00visto.SetActive(false);
            Nave01visto.SetActive(false);
            Nave02visto.SetActive(false);
            Nave03visto.SetActive(false);
            Nave04visto.SetActive(false);
            Nave05visto.SetActive(false);
            Nave06visto.SetActive(false);
            Nave08visto.SetActive(false);
            Nave09visto.SetActive(false);

            imagecinza00.SetActive(true);
            imagecinza01.SetActive(true);
            imagecinza02.SetActive(true);
            imagecinza03.SetActive(true);
            imagecinza04.SetActive(true);
            imagecinza05.SetActive(true);
            imagecinza06.SetActive(true);
            imagecinza07.SetActive(false);
            imagecinza08.SetActive(true);
            imagecinza09.SetActive(true);

            Nave00.SetActive(false);
            Nave01.SetActive(false);
            Nave02.SetActive(false);
            Nave03.SetActive(false);
            Nave04.SetActive(false);
            Nave05.SetActive(false);
            Nave06.SetActive(false);
            Nave07.SetActive(true);
            Nave08.SetActive(false);
            Nave09.SetActive(false);

            Valor = 7;
            ValorQualComprei7 = 7;
            GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);
            GJ.RecebeSelecaoNaves(Valor);
        }
    }

    public void BT08()
    {
        if (comprado08 == false)
        {

            TelaAviso.SetActive(true);
            Valor = 8;
        }

        if(comprado08 == true)
        {
            Nave08visto.SetActive(true);
            Nave00visto.SetActive(false);
            Nave01visto.SetActive(false);
            Nave02visto.SetActive(false);
            Nave03visto.SetActive(false);
            Nave04visto.SetActive(false);
            Nave05visto.SetActive(false);
            Nave06visto.SetActive(false);
            Nave07visto.SetActive(false);
            Nave09visto.SetActive(false);

            imagecinza00.SetActive(true);
            imagecinza01.SetActive(true);
            imagecinza02.SetActive(true);
            imagecinza03.SetActive(true);
            imagecinza04.SetActive(true);
            imagecinza05.SetActive(true);
            imagecinza06.SetActive(true);
            imagecinza07.SetActive(true);
            imagecinza08.SetActive(false);
            imagecinza09.SetActive(true);

            Nave00.SetActive(false);
            Nave01.SetActive(false);
            Nave02.SetActive(false);
            Nave03.SetActive(false);
            Nave04.SetActive(false);
            Nave05.SetActive(false);
            Nave06.SetActive(false);
            Nave07.SetActive(false);
            Nave08.SetActive(true);
            Nave09.SetActive(false);

            Valor = 8;
            ValorQualComprei8 = 8;
            GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);
            GJ.RecebeSelecaoNaves(Valor);

        }
    }

    public void BT09()
    {
        if (comprado09 == false)
        {
            TelaAviso.SetActive(true);
            Valor = 9;

        }


        if (comprado09 == true)
        {
            Nave09visto.SetActive(true);
            Nave00visto.SetActive(false);
            Nave01visto.SetActive(false);
            Nave02visto.SetActive(false);
            Nave03visto.SetActive(false);
            Nave04visto.SetActive(false);
            Nave05visto.SetActive(false);
            Nave06visto.SetActive(false);
            Nave07visto.SetActive(false);
            Nave08visto.SetActive(false);

            imagecinza00.SetActive(true);
            imagecinza01.SetActive(true);
            imagecinza02.SetActive(true);
            imagecinza03.SetActive(true);
            imagecinza04.SetActive(true);
            imagecinza05.SetActive(true);
            imagecinza06.SetActive(true);
            imagecinza07.SetActive(true);
            imagecinza08.SetActive(true);
            imagecinza09.SetActive(false);

            Nave00.SetActive(false);
            Nave01.SetActive(false);
            Nave02.SetActive(false);
            Nave03.SetActive(false);
            Nave04.SetActive(false);
            Nave05.SetActive(false);
            Nave06.SetActive(false);
            Nave07.SetActive(false);
            Nave08.SetActive(false);
            Nave09.SetActive(true);

            Valor = 9;
            ValorQualComprei9 = 9;
            GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);
            GJ.RecebeSelecaoNaves(Valor);
        }
    }


    public void BTComprasim()
    {
        if (comprado01 == false)
        {
            if (Valor == 1)
            {
                if (OURO >= 500)
                {
                    GJ.RecebeJoiasMorreu(-500);
                    comprado01 = true;

                    Nave01visto.SetActive(true);
                    Nave00visto.SetActive(false);
                    Nave02visto.SetActive(false);
                    Nave03visto.SetActive(false);
                    Nave04visto.SetActive(false);
                    Nave05visto.SetActive(false);
                    Nave06visto.SetActive(false);
                    Nave07visto.SetActive(false);
                    Nave08visto.SetActive(false);
                    Nave09visto.SetActive(false);

                    imagecinza00.SetActive(true);
                    imagecinza01.SetActive(false);
                    imagecinza02.SetActive(true);
                    imagecinza03.SetActive(true);
                    imagecinza04.SetActive(true);
                    imagecinza05.SetActive(true);
                    imagecinza06.SetActive(true);
                    imagecinza07.SetActive(true);
                    imagecinza08.SetActive(true);
                    imagecinza09.SetActive(true);

                    Nave00.SetActive(false);
                    Nave01.SetActive(true);
                    Nave02.SetActive(false);
                    Nave03.SetActive(false);
                    Nave04.SetActive(false);
                    Nave05.SetActive(false);
                    Nave06.SetActive(false);
                    Nave07.SetActive(false);
                    Nave08.SetActive(false);
                    Nave09.SetActive(false);

                    BTcompra1.SetActive(false);
                    TelaAviso.SetActive(false);

                    GJ.RecebeSelecaoNaves(Valor);

                    ValorQualComprei1 = 1;
                    GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);
                }
            }


        }

        if (comprado02 == false)
        {
            if (Valor == 2)
            {
                if (OURO >= 600)
                {
                    GJ.RecebeJoiasMorreu(-600);
                    OURO = OURO - 50;
                    comprado02 = true;

                    Nave02visto.SetActive(true);
                    Nave00visto.SetActive(false);
                    Nave01visto.SetActive(false);
                    Nave03visto.SetActive(false);
                    Nave04visto.SetActive(false);
                    Nave05visto.SetActive(false);
                    Nave06visto.SetActive(false);
                    Nave07visto.SetActive(false);
                    Nave08visto.SetActive(false);
                    Nave09visto.SetActive(false);

                    imagecinza00.SetActive(true);
                    imagecinza01.SetActive(true);
                    imagecinza02.SetActive(false);
                    imagecinza03.SetActive(true);
                    imagecinza04.SetActive(true);
                    imagecinza05.SetActive(true);
                    imagecinza06.SetActive(true);
                    imagecinza07.SetActive(true);
                    imagecinza08.SetActive(true);
                    imagecinza09.SetActive(true);

                    Nave00.SetActive(false);
                    Nave01.SetActive(false);
                    Nave02.SetActive(true);
                    Nave03.SetActive(false);
                    Nave04.SetActive(false);
                    Nave05.SetActive(false);
                    Nave06.SetActive(false);
                    Nave07.SetActive(false);
                    Nave08.SetActive(false);
                    Nave09.SetActive(false);

                    BTcompra2.SetActive(false);
                    TelaAviso.SetActive(false);

                    GJ.RecebeSelecaoNaves(Valor);

                    ValorQualComprei2 = 2;
                    GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);
                }
            }


        }

        if (comprado03 == false)
        {
            if (Valor == 3)
            {
                if (OURO >= 700)
                {
                    GJ.RecebeJoiasMorreu(-700);
                    comprado03 = true;

                    Nave03visto.SetActive(true);
                    Nave00visto.SetActive(false);
                    Nave01visto.SetActive(false);
                    Nave02visto.SetActive(false);
                    Nave04visto.SetActive(false);
                    Nave05visto.SetActive(false);
                    Nave06visto.SetActive(false);
                    Nave07visto.SetActive(false);
                    Nave08visto.SetActive(false);
                    Nave09visto.SetActive(false);

                    imagecinza00.SetActive(true);
                    imagecinza01.SetActive(true);
                    imagecinza02.SetActive(true);
                    imagecinza03.SetActive(false);
                    imagecinza04.SetActive(true);
                    imagecinza05.SetActive(true);
                    imagecinza06.SetActive(true);
                    imagecinza07.SetActive(true);
                    imagecinza08.SetActive(true);
                    imagecinza09.SetActive(true);

                    Nave00.SetActive(false);
                    Nave01.SetActive(false);
                    Nave02.SetActive(false);
                    Nave03.SetActive(true);
                    Nave04.SetActive(false);
                    Nave05.SetActive(false);
                    Nave06.SetActive(false);
                    Nave07.SetActive(false);
                    Nave08.SetActive(false);
                    Nave09.SetActive(false);

                    BTcompra3.SetActive(false);
                    TelaAviso.SetActive(false);

                    GJ.RecebeSelecaoNaves(Valor);

                    ValorQualComprei3 = 3;
                    GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);
                }
            }


        }

        if (comprado04 == false)
        {
            if (Valor == 4)
            {
                if (OURO >= 800)
                {
                    GJ.RecebeJoiasMorreu(-800);
                    comprado04 = true;

                    Nave04visto.SetActive(true);
                    Nave00visto.SetActive(false);
                    Nave01visto.SetActive(false);
                    Nave02visto.SetActive(false);
                    Nave03visto.SetActive(false);
                    Nave05visto.SetActive(false);
                    Nave06visto.SetActive(false);
                    Nave07visto.SetActive(false);
                    Nave08visto.SetActive(false);
                    Nave09visto.SetActive(false);

                    imagecinza00.SetActive(true);
                    imagecinza01.SetActive(true);
                    imagecinza02.SetActive(true);
                    imagecinza03.SetActive(true);
                    imagecinza04.SetActive(false);
                    imagecinza05.SetActive(true);
                    imagecinza06.SetActive(true);
                    imagecinza07.SetActive(true);
                    imagecinza08.SetActive(true);
                    imagecinza09.SetActive(true);

                    Nave00.SetActive(false);
                    Nave01.SetActive(false);
                    Nave02.SetActive(false);
                    Nave03.SetActive(false);
                    Nave04.SetActive(true);
                    Nave05.SetActive(false);
                    Nave06.SetActive(false);
                    Nave07.SetActive(false);
                    Nave08.SetActive(false);
                    Nave09.SetActive(false);

                    BTcompra4.SetActive(false);
                    TelaAviso.SetActive(false);

                    GJ.RecebeSelecaoNaves(Valor);

                    ValorQualComprei4 = 4;
                    GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);
                }
            }


        }

        if (comprado05 == false)
        {
            if (Valor == 5)
            {
                if (OURO >= 900)
                {
                    GJ.RecebeJoiasMorreu(-900);
                    comprado05 = true;

                    Nave05visto.SetActive(true);
                    Nave00visto.SetActive(false);
                    Nave01visto.SetActive(false);
                    Nave02visto.SetActive(false);
                    Nave03visto.SetActive(false);
                    Nave04visto.SetActive(false);
                    Nave06visto.SetActive(false);
                    Nave07visto.SetActive(false);
                    Nave08visto.SetActive(false);
                    Nave09visto.SetActive(false);

                    imagecinza00.SetActive(true);
                    imagecinza01.SetActive(true);
                    imagecinza02.SetActive(true);
                    imagecinza03.SetActive(true);
                    imagecinza04.SetActive(true);
                    imagecinza05.SetActive(false);
                    imagecinza06.SetActive(true);
                    imagecinza07.SetActive(true);
                    imagecinza08.SetActive(true);
                    imagecinza09.SetActive(true);

                    Nave00.SetActive(false);
                    Nave01.SetActive(false);
                    Nave02.SetActive(false);
                    Nave03.SetActive(false);
                    Nave04.SetActive(false);
                    Nave05.SetActive(true);
                    Nave06.SetActive(false);
                    Nave07.SetActive(false);
                    Nave08.SetActive(false);
                    Nave09.SetActive(false);

                    BTcompra5.SetActive(false);
                    TelaAviso.SetActive(false);

                    GJ.RecebeSelecaoNaves(Valor);

                    ValorQualComprei5 = 5;
                    GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);
                }
            }


        }

        if (comprado06 == false)
        {
            if (Valor == 6)
            {
                if (OURO >= 1000)
                {
                    GJ.RecebeJoiasMorreu(-1000);
                    comprado06 = true;

                    Nave06visto.SetActive(true);
                    Nave00visto.SetActive(false);
                    Nave01visto.SetActive(false);
                    Nave02visto.SetActive(false);
                    Nave03visto.SetActive(false);
                    Nave04visto.SetActive(false);
                    Nave05visto.SetActive(false);
                    Nave07visto.SetActive(false);
                    Nave08visto.SetActive(false);
                    Nave09visto.SetActive(false);

                    imagecinza00.SetActive(true);
                    imagecinza01.SetActive(true);
                    imagecinza02.SetActive(true);
                    imagecinza03.SetActive(true);
                    imagecinza04.SetActive(true);
                    imagecinza05.SetActive(true);
                    imagecinza06.SetActive(false);
                    imagecinza07.SetActive(true);
                    imagecinza08.SetActive(true);
                    imagecinza09.SetActive(true);

                    Nave00.SetActive(false);
                    Nave01.SetActive(false);
                    Nave02.SetActive(false);
                    Nave03.SetActive(false);
                    Nave04.SetActive(false);
                    Nave05.SetActive(false);
                    Nave06.SetActive(true);
                    Nave07.SetActive(false);
                    Nave08.SetActive(false);
                    Nave09.SetActive(false);

                    BTcompra6.SetActive(false);
                    TelaAviso.SetActive(false);

                    GJ.RecebeSelecaoNaves(Valor);

                    ValorQualComprei6 = 6;
                    GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);
                }
            }


        }

        if (comprado07 == false)
        {
            if (Valor == 7)
            {
                if (OURO >= 1100)
                {
                    GJ.RecebeJoiasMorreu(-1100);
                    comprado07 = true;

                    Nave07visto.SetActive(true);
                    Nave00visto.SetActive(false);
                    Nave01visto.SetActive(false);
                    Nave02visto.SetActive(false);
                    Nave03visto.SetActive(false);
                    Nave04visto.SetActive(false);
                    Nave05visto.SetActive(false);
                    Nave06visto.SetActive(false);
                    Nave08visto.SetActive(false);
                    Nave09visto.SetActive(false);

                    imagecinza00.SetActive(true);
                    imagecinza01.SetActive(true);
                    imagecinza02.SetActive(true);
                    imagecinza03.SetActive(true);
                    imagecinza04.SetActive(true);
                    imagecinza05.SetActive(true);
                    imagecinza06.SetActive(true);
                    imagecinza07.SetActive(false);
                    imagecinza08.SetActive(true);
                    imagecinza09.SetActive(true);

                    Nave00.SetActive(false);
                    Nave01.SetActive(false);
                    Nave02.SetActive(false);
                    Nave03.SetActive(false);
                    Nave04.SetActive(false);
                    Nave05.SetActive(false);
                    Nave06.SetActive(false);
                    Nave07.SetActive(true);
                    Nave08.SetActive(false);
                    Nave09.SetActive(false);

                    BTcompra7.SetActive(false);
                    TelaAviso.SetActive(false);

                    GJ.RecebeSelecaoNaves(Valor);

                    ValorQualComprei7 = 7;
                    GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);
                }
            }


        }

        if (comprado08 == false)
        {
            if (Valor == 8)
            {
                if (OURO >= 1200)
                {
                    GJ.RecebeJoiasMorreu(-1200);
                    comprado08 = true;


                    Nave08visto.SetActive(true);
                    Nave00visto.SetActive(false);
                    Nave01visto.SetActive(false);
                    Nave02visto.SetActive(false);
                    Nave03visto.SetActive(false);
                    Nave04visto.SetActive(false);
                    Nave05visto.SetActive(false);
                    Nave06visto.SetActive(false);
                    Nave07visto.SetActive(false);
                    Nave09visto.SetActive(false);

                    imagecinza00.SetActive(true);
                    imagecinza01.SetActive(true);
                    imagecinza02.SetActive(true);
                    imagecinza03.SetActive(true);
                    imagecinza04.SetActive(true);
                    imagecinza05.SetActive(true);
                    imagecinza06.SetActive(true);
                    imagecinza07.SetActive(true);
                    imagecinza08.SetActive(false);
                    imagecinza09.SetActive(true);

                    Nave00.SetActive(false);
                    Nave01.SetActive(false);
                    Nave02.SetActive(false);
                    Nave03.SetActive(false);
                    Nave04.SetActive(false);
                    Nave05.SetActive(false);
                    Nave06.SetActive(false);
                    Nave07.SetActive(false);
                    Nave08.SetActive(true);
                    Nave09.SetActive(false);

                    BTcompra8.SetActive(false);
                    TelaAviso.SetActive(false);

                    GJ.RecebeSelecaoNaves(Valor);

                    ValorQualComprei8 = 8;
                    GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);

                }
            }


        }

        if (comprado09 == false)
        {
            if (Valor == 9)
            {
                if (OURO >= 1300)
                {
                    GJ.RecebeJoiasMorreu(-1300);
                    comprado09 = true;

                    Nave09visto.SetActive(true);
                    Nave00visto.SetActive(false);
                    Nave01visto.SetActive(false);
                    Nave02visto.SetActive(false);
                    Nave03visto.SetActive(false);
                    Nave04visto.SetActive(false);
                    Nave05visto.SetActive(false);
                    Nave06visto.SetActive(false);
                    Nave07visto.SetActive(false);
                    Nave08visto.SetActive(false);

                    imagecinza00.SetActive(true);
                    imagecinza01.SetActive(true);
                    imagecinza02.SetActive(true);
                    imagecinza03.SetActive(true);
                    imagecinza04.SetActive(true);
                    imagecinza05.SetActive(true);
                    imagecinza06.SetActive(true);
                    imagecinza07.SetActive(true);
                    imagecinza08.SetActive(true);
                    imagecinza09.SetActive(false);

                    Nave00.SetActive(false);
                    Nave01.SetActive(false);
                    Nave02.SetActive(false);
                    Nave03.SetActive(false);
                    Nave04.SetActive(false);
                    Nave05.SetActive(false);
                    Nave06.SetActive(false);
                    Nave07.SetActive(false);
                    Nave08.SetActive(false);
                    Nave09.SetActive(true);

                    BTcompra9.SetActive(false);
                    TelaAviso.SetActive(false);

                    GJ.RecebeSelecaoNaves(Valor);

                    ValorQualComprei9 = 9;
                    GJ.RecebeCompra1(ValorQualComprei0, ValorQualComprei1, ValorQualComprei2, ValorQualComprei3, ValorQualComprei4, ValorQualComprei5, ValorQualComprei6, ValorQualComprei7, ValorQualComprei8, ValorQualComprei9);
                }
            }


        }
    }

    public void BTCompranao()
    {
        TelaAviso.SetActive(false);
    }

}