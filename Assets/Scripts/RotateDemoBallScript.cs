using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDemoBallScript : MonoBehaviour
{

    public GameObject poolBall;

    // Start is called before the first frame update
    void Start()
    {
        poolBall = GameObject.Find("PoolBall");
    }

    // Update is called once per frame
    void Update()
    {
        poolBall.transform.Rotate(0, 100 * Time.deltaTime, 0);
    }

}
