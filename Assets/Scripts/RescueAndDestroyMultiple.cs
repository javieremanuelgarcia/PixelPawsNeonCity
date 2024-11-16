using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RescueAndDestroyMultiple : MonoBehaviour
{
    public GameObject[] doorParts; 
    public string nextSceneName; 

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            gameObject.SetActive(false);

            
            foreach (GameObject part in doorParts)
            {
                Destroy(part);
            }

          
        }
    }
}

