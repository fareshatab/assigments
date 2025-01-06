using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderMove : MonoBehaviour
{
public static float incremnt = 0.001f ;
public static float incremntDeg = -0.001f ;
Vector3 incrementVector = new Vector3(0f,0f,incremnt);
    // Start is called before the first frame update
    void Start()
    { 
    
        
    }

    // Update is called once per frame
    void Update()
    {
     incremnt-=incremntDeg;
     transform.position +=new Vector3(0f,0f,incremnt);// لأنها immutable

        
    }
}
