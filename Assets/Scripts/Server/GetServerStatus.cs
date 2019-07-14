using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Linq;
using System.Linq.Expressions;

public class GetServerStatus : MonoBehaviour
{

    public void TestServerAvailability()
    {
        StartCoroutine(GetServerStatusWithApi());
        //Debug.Log("iuahuiahia");
    }

    IEnumerator GetServerStatusWithApi()
    {
        string apiUri = @"http://localhost:5000/";
        using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(apiUri))
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
    }

}
