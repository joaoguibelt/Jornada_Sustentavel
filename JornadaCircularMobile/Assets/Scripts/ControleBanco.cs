using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ControleBanco : MonoBehaviour
{
    public TMP_InputField Nome;
    public TMP_InputField Email;
    public TMP_Dropdown dropdowm;
    public string inputGenero;
    public string inputNome;
    public string inputEmail;
    public ControleCanvas controle;
    private string venceu = "false";
    private int pontosEu;
    private int pontosFamilia;
    private int pontosTrabalho;
    private int pontosSociedade;
    public void ChamarRegistro()
    {
        pontosSociedade = controle.pontos_Total - pontosEu - pontosFamilia - pontosTrabalho;
        if(controle.pontos_Total > 21)
        {
            venceu = "true";
        }
        StartCoroutine(Registrar());
    }

    IEnumerator Registrar()
    {
        WWWForm form = new WWWForm();
        form.AddField("nome", inputNome);
        form.AddField("email", inputEmail);
        form.AddField("genero", inputGenero);
        form.AddField("pontosEu", pontosEu);
        form.AddField("pontosFamilia", pontosFamilia);
        form.AddField("pontosTrabalho", pontosTrabalho);
        form.AddField("pontosSociedade", pontosSociedade);
        form.AddField("ganhou", venceu);
        UnityWebRequest www = UnityWebRequest.Post("https://conexaocircular.com/quiz/registro.php", form); //botar a url da onde está o arquivo php
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log(www.downloadHandler.text);
        }
    }

    public void GetValorDropdowm()
    {
        int indexDropdowm = dropdowm.value;
        if (indexDropdowm == 0)
        {
            inputGenero = "Homem Cis";
        }
        else if(indexDropdowm == 1)
        {
            inputGenero = "Homem Trans";
        }
        else if(indexDropdowm == 2)
        {
            inputGenero = "Mulher Cis";
        }
        else if(indexDropdowm == 3)
        {
            inputGenero = "Mulher Trans";
        }
        else if(indexDropdowm == 4)
        {
            inputGenero = "Nao-Binario";
        }
    }

    public void GuardarTextos()
    {
        inputNome = Nome.text;
        inputEmail = Email.text;
    }

    public void GuardarPontosEu()
    {
        pontosEu = controle.pontos_Total;
    }
    public void GuardarPontosFamilia()
    {
        pontosFamilia = controle.pontos_Total - pontosEu;
    }
    public void GuardarPontosTrabalho()
    {
        pontosTrabalho = controle.pontos_Total - pontosEu - pontosFamilia;
    }
}
