using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaSecreta : MonoBehaviour
{
    public GameObject zona;
    public GameObject zona2;
    public AudioSource musicalv1;

    public AudioClip suspense;
    AudioSource miedo;

    private void Awake()
    {
        miedo = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            zona.SetActive(false);
            zona2.SetActive(false);

            if (musicalv1 != null)
            {
                musicalv1.volume = 0f;
            }
            miedo.clip = suspense;
            miedo.volume = 1f;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            zona.SetActive(true);
            zona2.SetActive(true);
            miedo.volume = 0f;

            if (musicalv1 != null)
            {
                musicalv1.volume = 1f;
            }
        }
    }
}
