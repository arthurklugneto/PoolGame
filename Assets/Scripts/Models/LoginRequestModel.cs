using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LoginRequestModel
{
    public string username;
    public string password;

    public string GetJson()
    {
        return JsonUtility.ToJson(this);
    }
}
