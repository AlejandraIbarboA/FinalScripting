using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOverManager : MonoBehaviour
{
  
    
    public PlayerHealth playerHealth;

    Animator anim;

    public bool GameOver;

    public AudioClip risajaja;
    AudioSource final;
    
    public musicalv1 musicalv1;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        final = GetComponent<AudioSource>();

    }

    private void Start()
    {
    }


    void Update()
    {

      if (playerHealth.cmurio==true)
       {

            GameOver = true;
            anim.SetBool("GameOver", GameOver);
            final.clip = risajaja;
            
            if(!final.isPlaying)final.Play();

            if (musicalv1 != null)
            {
                musicalv1.nivel1.volume = 0f;
            }
        }
      

    }
}
