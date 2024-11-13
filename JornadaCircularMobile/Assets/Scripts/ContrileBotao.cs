using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContrileBotao : MonoBehaviour
{
    public Button botao;
    public TMP_InputField nome;
    public TMP_InputField email;
    public Toggle check;


    // Update is called once per frame
    void Update()
    {
        if(nome.text != null && email.text != null && check.isOn == true)
        {
            botao.interactable = true;
        }
        else
        {
            botao.interactable = false;
        }
       
    }
}
