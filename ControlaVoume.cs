using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class ControlaVoume : MonoBehaviour
{
    public AudioMixer SomGeral;
    public float volumeGeral;
    public Slider sliderVolume;

    private float audio_ligado = 0.0f;
    private float audio_desligado = -80.0f;

    void Start()
    {

    }

    void Update()
    {
        volumeGeral = sliderVolume.value;
        SomGeral.SetFloat("VolGeral", volumeGeral);
    }

    public void LigaMusic()
    {
        SomGeral.SetFloat("VolMusic", audio_ligado);
    }

    public void DesligaMusic()
    {
        SomGeral.SetFloat("VolMusic", audio_desligado);
    }

    public void LigaSFX()
    {
        SomGeral.SetFloat("VolEfeito", audio_ligado);
    }

    public void DesligaSFX()
    {
        SomGeral.SetFloat("VolEfeito", audio_desligado);
    }
}
