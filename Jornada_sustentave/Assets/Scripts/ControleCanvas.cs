using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControleCanvas : MonoBehaviour
{
    public int pontos_Total;
    public string nome;

    public TextMeshProUGUI texto1;

    // Start is called before the first frame update
    void Start()
    {
        pontos_Total = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        texto1.text = "Ok " + nome + ", vamos começar  nossa Jornada sustentavel em parceria!! Vamos reconhecer sua rotina e habitos ?";
    }

    public void RespostaCerta()
    {
        pontos_Total += 5;
    }
    public void RespostaErrada()
    {
        pontos_Total -= 3;
    }
    public void RespostaNeutra()
    {
        pontos_Total += 1;
    }

    public void GuardarNome(string s)
    {
        nome = s;
        Debug.Log(nome);
    }

}
