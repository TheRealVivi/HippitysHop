using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hippity : Enemy
{
    public static bool HippityIsDead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HippityIsDead = hp <= 0;


    }
}
