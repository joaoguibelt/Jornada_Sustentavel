using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCanvas : MonoBehaviour
{
    public Canvas canvas1;
    public Canvas canvas2;
    public Canvas canvas3;
    Canvas atual;
    Canvas proximo;

    // Start is called before the first frame update
    void Start()
    {
        atual = canvas1;
        proximo = canvas2;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void trocaCanvas()
    {
        atual = proximo;
        if ( proximo == canvas2)
        {
            proximo = canvas3;
        }
    }

}
