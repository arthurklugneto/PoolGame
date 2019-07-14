using UnityEngine;

[System.Serializable]
public class LoginData
{

    public string id;
    public string email;
    public string userName;
    public string token;

    public LoginData CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<LoginData>(jsonString);
    }

}
