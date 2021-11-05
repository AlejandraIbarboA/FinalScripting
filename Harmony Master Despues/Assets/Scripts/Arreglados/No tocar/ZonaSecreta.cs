using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaSecreta : MonoBehaviour
{
    [SerializeField] GameObject[] zonas;
    [SerializeField] AudioSource musicalv1;

    [SerializeField] AudioClip suspense;
    AudioSource miedo;

    private void Awake()
    {
        miedo = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < zonas.Length; i++)
            {
                zonas[i].SetActive(false);
            }

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
            for (int i = 0; i < zonas.Length; i++)
            {
                zonas[i].SetActive(true);
            }
            miedo.volume = 0f;

            if (musicalv1 != null)
            {
                musicalv1.volume = 1f;
            }
        }
    }
}
