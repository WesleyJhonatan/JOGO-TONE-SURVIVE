using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float velocidade_bg;

    private MeshRenderer renderizador;
    // Start is called before the first frame update
    void Start()
    {
        renderizador = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float posY = Mathf.Repeat(Time.time * velocidade_bg, 1);
        Vector2 offset = new Vector2(0, posY);
        renderizador.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
