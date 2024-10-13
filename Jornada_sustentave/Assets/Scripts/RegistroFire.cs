using Firebase.Firestore;

[FirestoreData]

public struct RegistroFire
{
    [FirestoreProperty]
    public string Name { get; set; }

    [FirestoreProperty]
    public string Email { get; set; }

    [FirestoreProperty]
    public string Cupom { get; set; }

    [FirestoreProperty]
    public bool Validado { get; set; }
}
