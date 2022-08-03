using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPboss : MonoBehaviour
{
    public RectTransform ImagemHP;
    public float HP;
    private Gerenciador GJ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ImagemHP.sizeDelta = new Vector2(HP, 21.61f);
    }
}
