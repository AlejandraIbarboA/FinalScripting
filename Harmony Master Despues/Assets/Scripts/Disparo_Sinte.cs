using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_Sinte : MonoBehaviour
{
    public float Speed;
    public float Lifetime;

   
    private GameObject Rotacion;
    private Rigidbody2D rb2D;
    private float direction;

    public int Damage;
   

   

    private void Start()
    {
        Invoke("DestroyProyectile", Lifetime);
        rb2D = GetComponent<Rigidbody2D>();

        Rotacion = FindObjectOfType<Player_Movement>().gameObject;

        if (Rotacion.transform.localScale.x == -1)
        {
            direction = -1;
        }

        if (Rotacion.transform.localScale.x == 1)
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
            //DestroyProyectile();
        }else

        if (other.attachedRigidbody)
        {
            DestroyProyectile();
        }
        
        
    }


    void DestroyProyectile()
    {
        
        Destroy(gameObject);
    }
}
