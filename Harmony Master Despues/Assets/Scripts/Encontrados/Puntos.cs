using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public PlayerHealth playerHealth;
    GameObject Player;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = Player.GetComponent<PlayerHealth>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
       if (other.gameObject.tag == "manzana")
        {
            
            Destroy(other.gameObject);
            playerHealth.currentHealth += 20;

        }
        if(other.gameObject.tag == "sandwich")
        {

            Destroy(other.gameObject);
            playerHealth.currentHealth +=25;

        }
        if (other.gameObject.tag == "agua")
        {
            Destroy(other.gameObject);
            playerHealth.currentHealth += 10; 
        }
    }
}
