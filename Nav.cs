using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Nav : MonoBehaviour
{
    private GameObject Inimigos;
    private NavMeshAgent Agente;
    private Gerenciador GJ;
    public float MinhaPisicao = 0;
    public Animator Animacao;

    void Start()
    {
        Animacao = GetComponent<Animator>();
        Animacao.SetBool("Parado", true);
        Agente = GetComponent<NavMeshAgent>();
        Agente.updateRotation = false;
        Agente.updateUpAxis = false;
    }

    void Update()
    {
        

        GameObject[] MeusInimigos;
        MeusInimigos = GameObject.FindGameObjectsWithTag("Inimigo");

        for (int indice = 0; indice < MeusInimigos.Length; indice++)
        {
                Agente.SetDestination(MeusInimigos[indice].transform.position);
            
        }

        GameObject[] MeusChefes;
        MeusChefes = GameObject.FindGameObjectsWithTag("Chefe");

        for (int indice = 0; indice < MeusChefes.Length; indice++)
        {
            Agente.SetDestination(MeusChefes[indice].transform.position);

        }


    }


    public void Delete()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Inimigo")
        {
            Animacao.SetBool("Parado", false);
            GetComponent<AudioSource>().Play();

        }

        if (collision.gameObject.tag == "Chefe")
        {
            Animacao.SetBool("Parado", false);
            GetComponent<AudioSource>().Play();

        }
    }
}
