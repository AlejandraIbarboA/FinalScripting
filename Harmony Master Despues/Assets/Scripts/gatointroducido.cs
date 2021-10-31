using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatointroducido : MonoBehaviour
{
    public GameObject saludos;
    public GameObject tutorial;
    public GameObject despedida;
    public bool poderhablar;
    public bool primero;
    public bool segundo;
    public bool tercero;
    public bool cuarto;
    public AudioClip gato;
    AudioSource miau;


    private void Awake()
    {
        miau = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            poderhablar = true;       
        }
    }

    private void Update()
    {
        miau.clip = gato;
        if (poderhablar)
        {
            if (primero)
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    saludos.SetActive(true);
                    primero = false;
                    segundo = true;
                    miau.Play();
                }
            } else

            if (segundo)
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    tutorial.SetActive(true);
                    saludos.SetActive(false);
                    segundo = false;
                    tercero = true;
                    miau.Play();
                }
            }else

            if (tercero)
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    despedida.SetActive(true);
                    tutorial.SetActive(false);
                    tercero = false;
                    cuarto = true;
                    miau.Play();
                }
            }else

            if (cuarto)
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    despedida.SetActive(false);
                    cuarto = false;
                    primero = true;
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            poderhablar = false;
            primero = true;
            segundo = false;
            tercero = false;
            cuarto = false;
            saludos.SetActive(false);
            tutorial.SetActive(false);
            despedida.SetActive(false);
        }
    }
}
