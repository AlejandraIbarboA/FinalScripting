using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackAng : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 10;

    Animator anim;
    GameObject Player;
    PlayerHealth playerHealth;


   public bool playerInRange;
   public  float timer;

    public LayerMask Golpeo;
    public Transform rango;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = Player.GetComponent<PlayerHealth>();
        anim = GetComponent<Animator>();
    }

   
 
    void Update()
    {
        timer += Time.deltaTime;
        
        if (Physics2D.OverlapCircle(rango.position, 0.34f, this.Golpeo))
        {
            playerInRange = true;
            anim.SetBool("Range", playerInRange);
        }
        else
        {
            playerInRange = false;
            anim.SetBool("Range", playerInRange);
        }
    }
    void Attack()
    {
        if (timer >= timeBetweenAttacks && playerInRange)
        {


            timer = 0f;

            if (playerHealth.currentHealth > 0)
            {
                playerHealth.TakeDamage(attackDamage);
            }
            playerInRange = false;
        }
    }


    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(rango.position, 0.34f);


    }
}
