using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asigment29{
public class CustomObject 
{
 int _id ;
 string _name;
 public CustomObject(int id , string name){
    _id = id;
    _name = name;
 }
   int ID{
    get {return _id;}
    set {_id = value;}
  }
   string Name{
    get {return _name;}
    set {_name = value;}
  }

        public override string ToString()
        {
            return $"Object [ID: {_id}, Name: {_name}]";
        }

    }
}