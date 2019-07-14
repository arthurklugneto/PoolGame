using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;
using UnityEngine.Networking;
using System.Linq;
using System.Linq.Expressions;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LoginScript : MonoBehaviour
{

    public InputField Username { get; set; }
    public InputField Password { get; set; }
    public Text Response { get; set; }

    public void Authenticate()
    {
        Username = GameUI.GetInputField("UserNameTextField");
        Password = GameUI.GetInputField("PasswordTextField");
        Response = GameUI.GetTextField("ResponseText");

        if( string.IsNullOrEmpty(Username.text.Trim()) || string.IsNullOrEmpty(Password.text.Trim()))
        {
            Response.text = "É necessário informar o usuário e senha para entrar.";
            return;
        }
        
        StartCoroutine(AuthenticateWithApi());
    }

    IEnumerator AuthenticateWithApi()
    {

        LoginRequestModel loginRequest = new LoginRequestModel();
        loginRequest.username = Username.text;
        loginRequest.password = Password.text;

        string jsonBody = loginRequest.GetJson();
        string serverUri = GameParameters.ServerAddress() + GameParameters.AuthenticationRoute();

        using (UnityWebRequest request = UnityWebRequest.Put(serverUri, jsonBody))
        {
            request.method = "Post";
            request.SetRequestHeader("Content-Type", "application/json");
            yield return request.SendWebRequest();

            if (!request.isNetworkError && request.responseCode == 200 )
            {
                // o login foi efetuado com sucesso
                LoginData loginData = new LoginData().CreateFromJSON(request.downloadHandler.text);

                if( loginData.token != null && loginData.userName != null)
                {
                    PlayerPrefs.SetString(GameParameters.LocalStorageNameAccessToken(), loginData.token);
                    /*
                     TODO : FIX THIS UGLY SHIT!!!
                     */
                    PlayerPrefs.SetString(GameParameters.LocalStorageNameUsername(), Username.text);
                    PlayerPrefs.SetString(GameParameters.LocalStorageNamePassword(), Password.text);                    

                    SceneManager.LoadScene(1);
                }
                
            }
            else
            {
                if( GameParameters.AllowAcessToLobbyWithoutLogin() )
                {
                    // permitir o accesso ao lobby mesmo que o
                    // login tenha falhado isso deve ser utilizado
                    // apenas para testes e desenvolvimento e nunca
                    // em produção
                }
                // erro de usuário e senha ou api
                // indisponível
                Response.text = "Usuário ou senha incorretos.";
            }

        }

    }

}
