using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
namespace Assignment27
{
public class NewBehaviourScript : MonoBehaviour
{
    
    void Start()
    {
      int a =1; 
      int b =2; 
      Debug.Log(addnum(a));
      Debug.Log(a);
      Debug.Log(addnum2(ref b));
      Debug.Log(b);
      AssignNewValue(out a);
      Debug.Log(a);
    }

    public int addnum(int a){
     return 10+a;
    }

    public int addnum2(ref int a){
     return 10+a;
    }

     void AssignNewValue(out int a)
    {
        a = 15; 
    }
    

    }

}


