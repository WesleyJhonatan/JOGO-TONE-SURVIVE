 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextoEffect : MonoBehaviour
{
    string myText1 = "Hello, I am John the captain and emissary of this operation, your mission is to destroy the enemy mother ship before it reaches Earth and does more damage.";
    string myText2 = "Good luck";
    string myText3 = "Understood captain";

    public GameObject MeuTexto1;
    public GameObject MeuTexto2;
    public GameObject MeuTexto3;

    char[] ctr1;
    char[] ctr2;
    char[] ctr3;

    public Text viewer1;
    public Text viewer2;
    public Text viewer3;

    public int count1 = 0;
    public int count2 = 0;
    public int count3 = 0;

    private bool vai1 = true;
    private bool vai2 = true;
    private bool vai3 = true;

    public GameObject BtProximo;
    private int ContaBT = 1;
    public GameObject Borda;

    public GameObject SomConversa;

    void Start()
    {
       
    }

    public void Comeca()
    {
        ctr1 = myText1.ToCharArray();
        StartCoroutine(ShowText1());
    }
    
    IEnumerator ShowText1()
    {
       
        if (vai1 == true)
        {
            while (count1 < ctr1.Length)
            {
                yield return new WaitForSeconds(0.03f);
                viewer1.text += ctr1[count1];
                count1++;
               
            }
        }

       
        if (count1 == ctr1.Length)
        {
            SomConversa.SetActive(false);
            vai1 = false;
            BtProximo.SetActive(true);
        }
    }

    IEnumerator ShowText2()
    {
        if (vai2 == true)
        {
            while (count2 < ctr2.Length)
            {
                yield return new WaitForSeconds(0.03f);
                viewer2.text += ctr2[count2];
                count2++;
            }
        }

        if (count2 == ctr2.Length)
        {
            SomConversa.SetActive(false);
            vai2 = false;
            ContaBT = 2;
            BtProximo.GetComponent<Animator>().Play("btproximo");
        }

    }

    IEnumerator ShowText3()
    {
        if (vai3 == true)
        {
            while (count3 < ctr3.Length)
            {
                yield return new WaitForSeconds(0.03f);
                viewer3.text += ctr3[count3];
                count3++;
            }
        }

        if (count3 == ctr3.Length)
        {
            SomConversa.SetActive(false);
            vai3 = false;
            Borda.SetActive(true);
        }
    }

    

    public void ChamProximaFala1()
    {
        if(ContaBT == 1)
        {
            MeuTexto1.SetActive(false);
            MeuTexto2.SetActive(true);
            ctr2 = myText2.ToCharArray();
            StartCoroutine(ShowText2());
            BtProximo.GetComponent<Animator>().Play("btproximovolta");
            SomConversa.SetActive(true);

        }

        if(ContaBT == 2)
        {
            MeuTexto2.SetActive(false);
            MeuTexto3.SetActive(true);
            ctr3 = myText3.ToCharArray();
            StartCoroutine(ShowText3());
            BtProximo.GetComponent<Animator>().Play("btproximovolta");
            SomConversa.SetActive(true);
        }

    }

    public void LimpaTudo()
    {
        count1 = 0;
        count2 = 0;
        count3 = 0;
        viewer1.text = "";
        viewer2.text = "";
        viewer3.text = "";
        vai1 = true;
        vai2 = true;
        vai3 = true;
        ContaBT = 1;
        Borda.SetActive(false);
    }


}