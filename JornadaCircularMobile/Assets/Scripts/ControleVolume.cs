using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControleVolume : MonoBehaviour
{
    public AudioSource auidio;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        auidio.volume = 0.5f;
        slider.onValueChanged.AddListener((v) =>
        {
            auidio.volume = v;
        });
    }
}
