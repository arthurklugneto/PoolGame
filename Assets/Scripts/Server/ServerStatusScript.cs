using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Linq;
using System.Linq.Expressions;
using Assets.Scripts;

public class ServerStatusScript : MonoBehaviour
{

    public void TestServerAvailability()
    {
        StartCoroutine(GetServerStatusWithApi());
    }

    IEnumerator GetServerStatusWithApi()
    {
        /*
        using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(GameParameters.ServerAddress() + GameParameters.AuthenticationRoute());
        {
            yield return unityWebRequest.Send();

            if (unityWebRequest.isNetworkError || unityWebRequest.isHttpError)
            {
                Debug.Log(unityWebRequest.error);
            }

            if ( unityWebRequest.isDone )
            {
                var jsonResult = System.Text.Encoding.UTF8.GetString(unityWebRequest.downloadHandler.data);
                Debug.Log(jsonResult);
            }
        }
        */
        return null;
    }

}
