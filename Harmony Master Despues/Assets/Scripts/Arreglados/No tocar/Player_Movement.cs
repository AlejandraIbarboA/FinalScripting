using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float MaxSpeed;
    public bool grounded;
    [SerializeField] float JumpPower;

    [SerializeField] bool jump;
    [SerializeField] PlayerHealth playerHealth;

    Animator anim;
    
    [SerializeField] Rigidbody2D PlayerRigidbody;


    private void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update(){
        anim.SetFloat("Speed", Mathf.Abs(PlayerRigidbody.velocity.x));
        anim.SetBool("Grounded", grounded);
        this.anim.SetFloat("Saltospeed", Mathf.Abs(this.PlayerRigidbody.velocity.y));
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (grounded)
            {
                jump = true;
                
            }
            
        }

    }

    
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        
        PlayerRigidbody.AddForce(Vector2.right * speed * h);

        float limitedSpeed = Mathf.Clamp(PlayerRigidbody.velocity.x, -MaxSpeed, MaxSpeed);
        PlayerRigidbody.velocity = new Vector2(limitedSpeed, PlayerRigidbody.velocity.y);

        if (h > 0.1f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);

        }

        if (h < -0.1f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }


        if (jump)
        {
            PlayerRigidbody.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
            jump = false;
        }

    }

   
}
