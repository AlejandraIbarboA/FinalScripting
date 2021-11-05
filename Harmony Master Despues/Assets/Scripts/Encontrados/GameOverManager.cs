using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOverManager : MonoBehaviour
{
    [SerializeField] PlayerHealth playerHealth;
    [SerializeField] Animator hudAnim;

    [SerializeField] AudioClip gameoverSound;
    [SerializeField] AudioSource audioEffect;
    AudioSource levelAudio;

    private bool sonido = false;

    private void Awake()
    {
        levelAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (playerHealth.cmurio == true)
        {
            hudAnim.SetBool("GameOver", true);
            audioEffect.clip = gameoverSound;

            if (!audioEffect.isPlaying && !sonido)
            {
                audioEffect.Play();
                sonido = true;
            }

            if (levelAudio != null)
            {
                levelAudio.pitch = 0.6f;
            }
        }
    }
}
