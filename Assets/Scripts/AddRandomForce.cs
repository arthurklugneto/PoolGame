using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRandomForce : MonoBehaviour
{
    private Rigidbody rb;
    public int minimum = -10;
    public int maximum = 10;
    private static readonly System.Random random = new System.Random();

    void FixedUpdate()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Random force added to object");
            rb = GetComponent<Rigidbody>();
            rb.AddForce(random.Next(minimum,maximum), 0, random.Next(minimum, maximum));
        }
    }
}
