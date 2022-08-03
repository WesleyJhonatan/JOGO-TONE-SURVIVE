using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroNave : MonoBehaviour
{
    private Gerenciador GJ;
    private float meuTempo = 0;
    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<Gerenciador>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GJ.EstadoGame() == true)
        {
            Temporizador();
        }
    }

    void Temporizador()
    {
        meuTempo += Time.deltaTime;

        if(meuTempo > 0.005f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
            meuTempo = 0;
        }
    }

    public void Delete()
    {
        Destroy(gameObject);
    }
}
