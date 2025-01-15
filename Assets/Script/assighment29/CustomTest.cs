using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asigment29{
public class CustomTest : MonoBehaviour
{
    CustomObject Object1 ;
   
    void Start()
    {
        Object1 = new CustomObject(1,"fwares");
        print(Object1);
    }

  
    void Update()
    {
        
    }
}
}