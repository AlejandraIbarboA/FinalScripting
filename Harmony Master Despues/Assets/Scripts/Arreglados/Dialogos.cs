using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogos : MonoBehaviour
{
    [SerializeField] GameObject[] dialogos;
    public bool poderHablar;
    AudioSource audio;
    private int contador = 0;


    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            poderHablar = true;       
        }
    }

    private void Update()
    {
        if (poderHablar)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                if(contador >= 1)
                {
                    dialogos[contador-1].SetActive(false);
                }
                audio.Play();
                Reset();
            }
        }
    }

    private void Reset()
    {
        if (contador == dialogos.Length)
        {
            contador = 0;
            dialogos[dialogos.Length-1].SetActive(false);
        }
        else
        {
            dialogos[contador].SetActive(true);
            contador++;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            poderHablar = false;
            contador = 0;
            for (int i = 0; i < dialogos.Length; i++)
            {
                dialogos[i].SetActive(false);
            }
        }
    }
}
