using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asigment29
{
    public class TypeManagementScript : MonoBehaviour
    {
        List<ICanFight> listofICanFight;
        void Start()
        {
         Animal animal = new Cat();
         animal.makeSound();
         animal.move();
         (animal as Cat).makeSound();
         (animal as Cat).move();

         listofICanFight = new List<ICanFight>{new Cat(), new Warrior()};
         for(int i =0 ;i<listofICanFight.Count ;i++){
            Debug.Log(listofICanFight[i].Attack());
            if(listofICanFight[i] is Cat) Debug.Log("Iam Cat");
            else Debug.Log("Iam Warrior");
         }

        }

       

    }
    public class Animal
    {
        public virtual void makeSound()
        {
            Debug.Log("Animal Voice");
        }
        public void move()
        {
            Debug.Log("Animal Move");
        }
    }
    public class Cat : Animal ,ICanFight
    {

        public override void makeSound()
        {
            Debug.Log("Meow!");
        }
        public new void move()
        {
            Debug.Log("runs quickly.");
        }
        public string Attack()
        {
            return"Cat attacks with claws!";
        }
    }

    public interface ICanFight{
        string Attack();
    }

    public class Warrior : ICanFight
    {
        public string Attack()
        {
           return "Warrior attacks with a sword!";
        }
    }

}