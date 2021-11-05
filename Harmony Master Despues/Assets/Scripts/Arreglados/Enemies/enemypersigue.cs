using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemypersigue : MonoBehaviour
{
    [SerializeField] float speed;  

    private Vector2 move;
    private bool facingri;
    private float horimput;

    private GameObject tarjet;

    Animator anim;

    private Rigidbody2D Rigidbody;

    [SerializeField] bool perseguir;


    private void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
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

        anim.SetFloat("Speed", Mathf.Abs(Rigidbody.velocity.x));

        
       
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
        this.move = this.Rigidbody.velocity;

        this.move.x = horimput * speed;

        this.Rigidbody.velocity = this.move;

    }
    void flip()
    {

        if (facingri == false)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);

        }

        else if (facingri==true)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

    }

    private void persigue()
    {
        if (perseguir == true)
        {
            speed = 1;
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
