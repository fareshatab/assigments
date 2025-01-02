using UnityEngine;

public class moveScript : MonoBehaviour
{
   public float speedScalling = 0.01f;
   public float currentYScalling=1;


    void Update()
    
    {
        
      if (Input.GetKey(KeyCode.LeftArrow))
         {
              if(transform.localScale.y<=10){
                transform.localScale = new Vector3(1,currentYScalling*speedScalling,1);
              }
              currentYScalling = currentYScalling+1/8f;

               }

        }
    }


