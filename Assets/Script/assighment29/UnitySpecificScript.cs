using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Asigment29
{
    

public class UnitySpecificScript : MonoBehaviour
{

  public GameObject gameObject;
  public GameObject jokerObject;
  public Light light;
    void Start()
    {
        print("Game Started !");
       gameObject = GameObject.Find("Cube");
       jokerObject = GameObject.FindGameObjectWithTag("Joker");
       light = GameObject.FindAnyObjectByType<Light>();        
    }

    void Update()
    { 
      if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.SetActive(false);
            print("TargetObject deactivated!");
        }
        
    }
   
   void OnEnable(){
    print("GameObject Enabled");
   }
   
  void OnDisable(){

    print("GameObject Disabled");
  }

     
}
}