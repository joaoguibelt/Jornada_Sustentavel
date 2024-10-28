using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ControleCanvas : MonoBehaviour
{
    public int pontos_Total;
    public int progresso;
    public string nome;

    public TextMeshProUGUI texto1;
    public TextMeshProUGUI texto2;
    public TextMeshProUGUI texto3;


    public Canvas finalDefinitivo;

    public Canvas finalBom;
    public Canvas finalMedio;
    public Canvas finalRuim;
    public Canvas finalHorrivel;

    public Image barra;

    // Start is called before the first frame update
    void Start()
    {
        pontos_Total = 0;
        progresso = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        texto1.text = "Para começar " + nome + ", é preciso se lembrar que a economia circular se baseia em um ciclo sustentável.\r\n Desse modo, tudo começa com a extração da matéria prima, passa pela produção, consumo, precisa haver a gestão do resíduo e se possível reciclar ou voltar ao meio ambiente.";
        texto2.text = "Olá " + nome + " muito prazer, eu também gostaria de saber seu gênero.\nNão que isso seja  fundamental, mas queremos gerar indicadores reais dos nossos usuários";
        texto3.text = "Olá " + nome + "!\nEu sou a Dora, a catadora! Vamos juntos no Jogo da Jornada Circular, aprendendo sobre sustentabilidade e recebendo pontos para o nosso Clube de Benefícios Circular?";
   
        if(progresso == 4)
        {
            barra.sprite = Resources.Load<Sprite>("Barra de Progresso/barra_12,5_");
        }
        else if(progresso == 6)
        {
            barra.sprite = Resources.Load<Sprite>("Barra de Progresso/barra_25_");
        }
        else if(progresso == 9)
        {
            barra.sprite = Resources.Load<Sprite>("Barra de Progresso/barra_37,5_");
        }
        else if (progresso == 12)
        {
            barra.sprite = Resources.Load<Sprite>("Barra de Progresso/barra_50_");
        }
        else if (progresso == 15)
        {
            barra.sprite = Resources.Load<Sprite>("Barra de Progresso/barra_62,5_");
        }
        else if (progresso == 18)
        {
            barra.sprite = Resources.Load<Sprite>("Barra de Progresso/barra_75_");
        }
        else if (progresso == 21)
        {
            barra.sprite = Resources.Load<Sprite>("Barra de Progresso/barra_87,5_");
        }
        else if (progresso == 25)
        {
            barra.sprite = Resources.Load<Sprite>("Barra de Progresso/barra_100_");
        }
    }
    public void RespostaCerta()
    {
        pontos_Total += 1;
        progresso += 1;
    }
    public void RespostaErrada()
    {
        progresso += 1;
    }

    public void GuardarNome(string s)
    {
        nome = s;
        Debug.Log(nome);
    }

    public void EscolherFinal()
    {
        if(pontos_Total > 21)
        {
            finalDefinitivo = finalBom;
        }
        else if(pontos_Total > 17 & pontos_Total <= 21)
        {
            finalDefinitivo = finalMedio;
        }
        else if (pontos_Total > 12 & pontos_Total <= 27)
        {
            finalDefinitivo = finalRuim;
        }
        else
        {
            finalDefinitivo = finalHorrivel;
        }

        finalDefinitivo.gameObject.SetActive(true);
    }
    //25 total

    public void VoltaMenu()
    {
        barra.sprite = Resources.Load<Sprite>("Barra de Progresso/barra_0_");
        progresso = 1;
        pontos_Total = 0;
    }
}
