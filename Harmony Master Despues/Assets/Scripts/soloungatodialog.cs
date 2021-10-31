using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soloungatodialog : MonoBehaviour
{
    public GameObject dialogo;
    public bool poderhablar;
    public bool primero;
    public bool empeza;
    public float tiempo;

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
                    dialogo.SetActive(true);
                    primero = false;
                    miau.Play();
                    empeza = true;
                }
            }
        }
        if (empeza)
        {
            tiempo += Time.deltaTime;
        }

        if (tiempo>=3)
        {
            
            {
                dialogo.SetActive(false);
                primero = true;
                empeza = false;
                tiempo = 0f;
            }
        }
     
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            poderhablar = false;
            primero = true;
            dialogo.SetActive(false);
            empeza = false;
            tiempo = 0f;
        }
    }

}
