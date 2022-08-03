using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class if_statements : MonoBehaviour
{
    string HeroName = ("Daniel");
    int HeroLv = 124;
    string VillainName = ("Dio");
    int VillainLv = 130;
    void Start()
    {
        if (HeroLv > VillainLv)
        {
            print(HeroName + " is stronger than " + VillainName);
        }
        else
        {
            print(VillainName + " is stronger than " + HeroName);
        }
    }

    void Update()
    {
        
    }
}
