using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_clarinete : MonoBehaviour
{
    [SerializeField] float Speed;
    [SerializeField] float Lifetime;

    private GameObject Rotacion;
    private Rigidbody2D rb2D;
    private float direction;

    [SerializeField] int Damage;
    private GameObject Player;


    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Start()
    {
        Invoke("DestroyProyectile", Lifetime);
        rb2D = GetComponent<Rigidbody2D>();

        Rotacion = FindObjectOfType<Player_Movement>().gameObject;

        if (Player.transform.localScale.x == -1)
        {
            direction = -1;
        }

        if (Player.transform.localScale.x == 1)
        {
            direction = 1;
        }

        rb2D.AddForce(Vector2.right * Speed * direction);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.SendMessage("hurt", this.Damage);
            
        }
      

    }


    void DestroyProyectile()
    {

        Destroy(gameObject);
    }
}
