using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

namespace Assignment26{

public class CreatureManager : MonoBehaviour
{
   public Kangaroo  kangaroo= new Kangaroo ();
   public Duck  duck= new Duck ();
    void Start()
    {
        List <Creature> animal = new List<Creature>{kangaroo,duck};
        List <IRunnable> runnables = new List<IRunnable> {kangaroo,duck};
        List <IJumpable> jmpables = new List<IJumpable> {kangaroo};
        List <ISwimmable> swimmables  = new List<ISwimmable> {duck};
        kangaroo.Speak();
        duck.Speak();
        kangaroo.Run();
        duck.Run();
        kangaroo.Jump();
        duck.Swim();
  }

   
    
}
}