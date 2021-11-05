using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemypersigueGargola : MonoBehaviour
{

    public float speed;
   

    private Vector2 move;
    public bool facingri;
    public float horimput;

    private GameObject tarjet;

    Animator anim;

    public Rigidbody2D enemigorb;
    

    public bool perseguir;


    private void Start()
    {
        enemigorb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        this.move = new Vector2();
        this.facingri = true;
        tarjet = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
       


        if (horimput<0)
        {
            this.facingri = false;
            this.flip();
        }

        if (this.horimput > 0)
        {
            this.facingri = true;
            this.flip();
        }

        anim.SetFloat("Speed", Mathf.Abs(enemigorb.velocity.x));

        
       
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            perseguir = true;
            persigue();           
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            perseguir = false;
            persigue();
        }
    }

    void FixedUpdate()
    {
        this.move = this.enemigorb.velocity;

        this.move.x = horimput * speed;

        this.enemigorb.velocity = this.move;

    }
    void flip()
    {

        if (facingri == true)
        {
            transform.localScale = new Vector3(1.5f, 1.5f, 1f);

        }

        else if (facingri==false)
        {
            transform.localScale = new Vector3(-1.5f, 1.5f, 1f);
        }

    }

    private void persigue()
    {
        if (perseguir == true)
        {
            speed = 0.5f;
            if (transform.position.x < tarjet.transform.position.x)
            {
                horimput = 1;
            }
            else if (transform.position.x > tarjet.transform.position.x)
            {
                horimput = -1;
            }
        } else if (perseguir == false)
        {
            speed = 0.0f;
        }

    }

}
