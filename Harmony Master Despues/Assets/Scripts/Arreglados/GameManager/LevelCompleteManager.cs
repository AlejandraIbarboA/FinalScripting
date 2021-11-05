using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteManager : MonoBehaviour
{
    [SerializeField] ObrDestruction orb;
    [SerializeField] Animator anim;

    [SerializeField] AudioClip winSound;
    [SerializeField] AudioSource audioEffect;
    AudioSource levelAudio;
    private bool sonido = false;

    private void Awake()
    {
        levelAudio = GetComponent<AudioSource>();
    }

    void Start()
    {
        orb.destroyed += Win;
    }

    public void OnDestroy()
    {
        orb.destroyed -= Win;
    }

    private void Win()
    {
        anim.SetTrigger("LevelComplete");
        audioEffect.clip = winSound;

        if (!audioEffect.isPlaying && !sonido)
        {
            sonido = true;
            audioEffect.Play();
        }

        if (levelAudio != null)
        {
            levelAudio.volume = 0f;
        }
    }

}
