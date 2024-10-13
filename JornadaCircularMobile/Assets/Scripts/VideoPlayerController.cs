using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer dimensao;

    public ControleCanvas controle;

    public Canvas telaVideo;
    public Canvas proximaTela;

    public AudioSource musicaJogo;

    private bool startou;

    public int importancia; //1 = primeiro  , 2 = meio todo , 3 = ultimo



    // Start is called before the first frame update
    void Start()
    {
        startou = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (dimensao.isPlaying)
        {
            startou = true;
        }

        if (startou)
        {
            if (!dimensao.isPlaying)
            {
                if (importancia ==  2)
                {
                    telaVideo.gameObject.SetActive(false);
                    proximaTela.gameObject.SetActive(true);
                    musicaJogo.Play();
                }
                else if(importancia == 1)
                {
                    telaVideo.gameObject.SetActive(false);
                    proximaTela.gameObject.SetActive(true);
                }
                else if(importancia == 3)
                {
                    telaVideo.gameObject.SetActive(false);
                    musicaJogo.Stop();
                    controle.EscolherFinal();
                }
            }
        }
    }
}
