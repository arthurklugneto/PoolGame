using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAtGameObjectScript : MonoBehaviour
{

    public GameObject targetObject;

    void Update()
    {
        if( targetObject != null)
        {
            Vector3 targetPosition = targetObject.transform.position;
            transform.LookAt(targetPosition);
        }
    }
}
