using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicalv1 : MonoBehaviour
{
    public AudioClip lv1;
    public AudioSource nivel1;

    private void Awake()
    {
        nivel1 = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        nivel1.clip = lv1;
        if (!nivel1.isPlaying) nivel1.Play(); 
    }
}
