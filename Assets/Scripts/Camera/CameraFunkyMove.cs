using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class CameraFunkyMove : MonoBehaviour
{

    public Vector3 minimumPosition;
    public Vector3 maximumPosition;
    static private int lastRecalculation = -1;
    private static readonly System.Random random = new System.Random();
    private static float velocityX = 0;
    private static float velocityZ = 0;
    private static float speedDividor = 100;
    private static bool firstExecute = true;

    void Update()
    {
        if (lastRecalculation == Time.frameCount)
            return;

        int frameNumber = Time.frameCount;

        if( firstExecute || frameNumber % (60 * 5) == 0)
        {
            velocityX = Convert.ToSingle((random.NextDouble()-0.5));
            velocityZ = Convert.ToSingle((random.NextDouble()-0.5));
            Vector3 newCameraPosition = new Vector3(random.Next(-5,5), 2.6f, random.Next(-5, 5));
            transform.position = newCameraPosition;
            firstExecute = false;
        }

        Vector3 curentPosition = transform.position;
        curentPosition.x += velocityX/speedDividor;
        curentPosition.z += velocityZ/speedDividor;
        transform.position = curentPosition;

    }
}
