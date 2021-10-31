using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 10;

    Animator anim;
    GameObject Player;
    PlayerHealth playerHealth;


   public bool playerInRange;
   public  float timer;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = Player.GetComponent<PlayerHealth>();
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
      if(other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
 
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeBetweenAttacks && playerInRange)
        {
            Attack();
        }

    }
    void Attack()
    {
        timer = 0f;

        if (playerHealth.currentHealth > 0)
        {
           playerHealth.TakeDamage(attackDamage);
        }
    }

    
}
