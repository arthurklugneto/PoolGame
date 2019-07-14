using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class CameraCinematicMovementScript : MonoBehaviour
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
            velocityX = getRandomFloat(-0.5f,0.5f);
            velocityZ = getRandomFloat(-0.5f,0.5f);

            Vector3 newCameraPosition = new Vector3(
                getRandomFloat(minimumPosition.x,maximumPosition.x), 
                getRandomFloat(minimumPosition.y, maximumPosition.y),
                getRandomFloat(minimumPosition.z, maximumPosition.z));
            transform.position = newCameraPosition;
            firstExecute = false;
        }

        Vector3 curentPosition = transform.position;
        curentPosition.x += velocityX/speedDividor;
        curentPosition.z += velocityZ/speedDividor;
        transform.position = curentPosition;

    }

    private float getRandomFloat(float minimum, float maximum)
    {
        return Convert.ToSingle(random.NextDouble() * (maximum - minimum) + minimum);
    }

}
