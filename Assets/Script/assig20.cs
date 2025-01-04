using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
namespace assig19
{
    

public class assig20 : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        float x = 0f;
        
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.position+=new Vector3(x+=0.015f,transform.position.z,transform.position.z);
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.position+=new Vector3(x-=0.015f,transform.position.z,transform.position.z);
        }
    }
}
}