using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteManager : MonoBehaviour
{
    public Enemy_vida enemyVida;

    Animator anim;
    public float tiempo;
    public bool empezatiem;
    public bool Sonidito;

    public AudioClip yey;
    public AudioSource level;

    public musicalv1 musicalv1;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        level = GetComponent<AudioSource>();
    }



    void Update()
    {
        if (enemyVida.hp <= 0)
        {
            anim.SetTrigger("LevelComplete");
            empezatiem = true;
            Sonidito = true;
            level.clip = yey;
            if (!level.isPlaying) level.Play();            

            if (musicalv1 != null)
            {
                musicalv1.nivel1.volume = 0f;
            }
        }
        else
        {

        }
        if (empezatiem)
        {
            tiempo += Time.deltaTime;
            if (tiempo >= 2)
            {
                SceneManager.LoadScene("carga 1", LoadSceneMode.Single);
            }
        }
    }
}
