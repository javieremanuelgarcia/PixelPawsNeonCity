using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject targetObject; 
    public GameObject newObject; 
    public AudioSource switchSound; 
    private bool isActivated = false; 

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !isActivated)
        {
         
            ChangeObject();

            
            if (switchSound != null)
            {
                switchSound.Play();
            }

           
            isActivated = true;
        }
    }

    void ChangeObject()
    {
        
        targetObject.SetActive(false);
       
        newObject.SetActive(true);
    }
}


