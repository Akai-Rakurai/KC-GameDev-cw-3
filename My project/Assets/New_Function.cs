using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Function : MonoBehaviour
{
    float playerspeed = 12.3f;
    void Start()
    {
        print(playerspeed);
        setspeed(2.5f);
        print(playerspeed);
    }

    void Update()
    {

    }

    void setspeed(float speed)
    {
        playerspeed = speed;

    }

}

