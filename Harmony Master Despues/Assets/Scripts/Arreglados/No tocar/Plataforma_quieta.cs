using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma_quieta : MonoBehaviour
{
   
    [SerializeField] GameObject plataforma;
    private Rigidbody2D plata;

    private void Start()
    {
        plata = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")||other.CompareTag("Enemy"))
        {
            plata.constraints = RigidbodyConstraints2D.FreezeAll;

            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            plata.constraints = RigidbodyConstraints2D.None;
            
        }
           
    }

}
