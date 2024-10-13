using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ControleBanco : MonoBehaviour
{
    public TMP_InputField inputNome;
    public TMP_InputField inputEmail;


    public Button botaoConfirmar;


    public void ChamarRegistro()
    {

        StartCoroutine(Registrar());
    }

    IEnumerator Registrar()
    {
        WWWForm form = new WWWForm();
        form.AddField("nome", inputNome.text);
        form.AddField("email", inputEmail.text);
        UnityWebRequest www = UnityWebRequest.Post("http://jornadacircular.infinityfreeapp.com/sqlconnect/registro.php", form);
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

    public void VerificaInput()
    {
        botaoConfirmar.interactable = (inputEmail.text.Length >= 1 && inputNome.text.Length >= 1);
    }
}
