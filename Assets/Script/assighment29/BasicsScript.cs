using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Asigment29
{
    

public class BasicsScript : MonoBehaviour
{
    void Start()
    {
        var x =10;
        var y ="Fwares1";
        var Z =true;

        var WhatamI =  x % 2 == 0 ?"Iam Even number" : "Iam Odd number";
        Debug.Log(WhatamI);
        Debug.Log($"The number {x} is {WhatamI}");
        DateTime dateTime =DateTime.Now;
        Debug.Log(dateTime.Date);
        Debug.Log(dateTime.TimeOfDay);
        Debug.Log(dateTime.DayOfWeek);
       

    }

    void Update()
    {
        
    }
}
}