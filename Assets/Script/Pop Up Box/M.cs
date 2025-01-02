using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M : MonoBehaviour
{

  public float rotationSpeed = 50f;
  public float maxRotationAngle = 180f;
  private float currentRotation = 0f;
   void Update()

  {

    if (Input.GetKey(KeyCode.LeftArrow))
    {

      // تغير موقع ال z Rotation
      if (currentRotation <= maxRotationAngle)
      {
        float rotationStep =rotationSpeed * Time.deltaTime;
        transform.Rotate(-rotationStep, 0, 0);
        currentRotation += rotationStep;

      }


    }

  }
}
