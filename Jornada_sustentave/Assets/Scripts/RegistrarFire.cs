using Firebase.Firestore;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RegistrarFire : MonoBehaviour
{
    [SerializeField] private string _registro = "registros/player";

    [SerializeField] private TMP_InputField _nome;

    [SerializeField] private TMP_InputField _email;

    [SerializeField] private UnityEngine.UI.Button _confirma;

    public static string AlfanumericoAleatorio(int tamanho)
    {
        string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        char[] stringChars = new char[tamanho];
        System.Random random = new System.Random();

        for (int i = 0; i < tamanho; i++)
        {
            stringChars[i] = characters[random.Next(characters.Length)];
        }

        return new string(stringChars);
    }

    private void Start()
    {
        _confirma.onClick.AddListener(() =>
        {
            var dadosRegistro = new RegistroFire
            {
                Name = _nome.text,
                Email = _email.text,
                Cupom = AlfanumericoAleatorio(10),
                Validado = false
            };

            var firestore = FirebaseFirestore.DefaultInstance;
            firestore.Document(_registro).SetAsync(dadosRegistro);
        });
    }
}
