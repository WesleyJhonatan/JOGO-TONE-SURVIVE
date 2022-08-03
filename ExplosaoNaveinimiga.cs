using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosaoNaveinimiga : MonoBehaviour
{
    public VidaInimigos ScripyInimigos;
    void Start()
    {
        ScripyInimigos = GameObject.FindGameObjectWithTag("Inimigo").GetComponent<VidaInimigos>();
    }

    void Update()
    {
        
    }

    public void ChamaDestroyNave()
    {
        ScripyInimigos.Medestroi();
    }
}
