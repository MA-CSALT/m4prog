using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
   public float speed = 5f;
   public float timeLeft = 20f;
   private int score = 0;

   void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ).normalized * speed * Time.deltaTime;
        
        transform.Translate(move);

        if (timeLeft <= 0)
         {
           
            Debug.Log("Game Over! Eindscore: " + score);

            enabled = false; 
            return;          
        }

    
        timeLeft -= Time.deltaTime;


        Debug.Log("Tijd: " + Mathf.Round(timeLeft) + " | Score: " + score);
    }

    void OnTriggerEnter(Collider other)
    {

        
        if (other.gameObject.name == "Coin")
         {
         
            score += 10;
          
            Debug.Log("Munt opgepakt, nieuwe score: " + score);
            
            Destroy(other.gameObject);
        }
    }
}


