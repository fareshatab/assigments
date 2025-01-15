using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Asigment29
{
    

public static class Uitilies 
{
    private static int sum =0;
    public static int Add(params int[] num){
     for (int i=0; i<= num.Length ;i++ ){
        sum += num[i];
     }
     return sum;
    }    
    
}
}