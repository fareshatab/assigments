using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Asigment29
{
    

public class tryCatchExampele : MonoBehaviour
{
    int playerScore = 100;
    int diviser = 0;
    
    void Start()
    {
        try{
          Debug.Log("Attempting to calculate score multiplier..");
           playerScore= playerScore/diviser;
        }
        catch(Exception e)
        {
          Debug.LogError(e.Message); //////////
        }
        finally{
            Debug.Log("Score calculation complete. Cleaning up resources");
        }
    }

    void Update()
    {
        
    }
}
}