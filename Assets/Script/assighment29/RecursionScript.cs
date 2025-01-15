using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asigment29
{


    public class RecursionScript : MonoBehaviour
    {

        void Start()
        {
          Debug.Log(FibonacciRecursive(10));
          Debug.Log(FibonacciIterative(30));
        }


        void Update()
        {

        }

        public int FibonacciRecursive(int n)
        {
            if(n == 0) return 0;
            else if(n==1|| n==2) return 1;
            else
            return FibonacciRecursive(n-1)+FibonacciRecursive(n-2);

        }
        public int FibonacciIterative(int n){
            int x = 0, y = 1;
            int fibo = 0;
            if (n == 0) return 0;
            if (n == 1) return 1;
            for(int i=2 ; i<=n ; i++){
                fibo = x+y;
                x=y;
                y = fibo;
               
            }
             return fibo;
        }
    }
}