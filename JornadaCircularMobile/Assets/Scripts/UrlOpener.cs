using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrlOpener : MonoBehaviour
{
    public string url;


    public void Open()
    {
        Application.OpenURL(url);
    }

    public void AbriNoMesmoGuia()
    {
        Application.ExternalEval("window.open('" + url + "','_self')");
    }
}
