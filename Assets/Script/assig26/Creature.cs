using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{
public class Creature
{
   public virtual void Speak()
   {
   }
} 
//-------------------------------------------//
//-------------------------------------------//
public interface IRunnable{
   public void Run();
}

//-------------------------------------------//
//-------------------------------------------//
public interface IJumpable{
    public void Jump();
}
//-------------------------------------------//
//-------------------------------------------//
public interface ISwimmable{
    public void Swim();
}
//-------------------------------------------//
//-------------------------------------------//
public class Kangaroo: Creature,IJumpable,IRunnable
{
   public void Run(){
   Debug.Log("Kangaroo runs.");
  }
   public void Jump(){
   Debug.Log("Kangaroo jumps.");
  }
        public override void Speak()
        {
           Debug.Log("Kangaroo says: Hop!");
        }
    }
    
//-------------------------------------------//
//-------------------------------------------//

public class Duck: Creature,ISwimmable,IRunnable
{
   public void Run(){
     Debug.Log("Duck runs.");
  }
   public void Swim(){
      Debug.Log("Duck swims.");
  }
        public override void Speak()
        {
           Debug.Log("Duck says: Quack!");
        }
 }
    
//-------------------------------------------//
//-------------------------------------------//




} 