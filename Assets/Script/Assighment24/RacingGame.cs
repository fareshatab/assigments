using System.Collections;
using System.Collections.Generic;

using assi24;
using UnityEngine;

public class RacingGame : MonoBehaviour
{
 public RaceState raceState;

 public void SimulateRace()
 {
  switch (raceState)
  {
    case RaceState.Start:
    Debug.Log("The race is about to begin. Get ready!");
    break;
    case RaceState.Accelerate:
    Debug.Log("You press the gas pedal. The car speeds up!");
    break;
    case RaceState.Turn:
    Debug.Log("You approach a sharp turn. Be careful not to crash!");
    break;
    case RaceState.Crash:
    Debug.Log("You hit a barrier. The race is over.");
    break;
    case RaceState.Finish:
    Debug.Log("You crossed the finish line. Well done!");
    break;
    
    
  }
 }
    
    void Start()
    {
        
    }

   
    void Update()
    {
        SimulateRace();
    }
}