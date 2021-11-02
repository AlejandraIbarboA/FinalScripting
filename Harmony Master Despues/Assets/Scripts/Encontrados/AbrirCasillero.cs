using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirCasillero : MonoBehaviour
{
    public GameObject objeto;
    public Animator anim;
    public float tiempo = 0.0f;
    private bool abrir;

    private bool abrido;
    private bool empezartiempo;
    private bool stay;
    


    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            abrir = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            abrir = false;
        }
    }

    public void Sacar ()
    {
        objeto.SetActive(true);
    }


    void Update()
    {
        if(abrir)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                abrido = true;
                empezartiempo= true;
                anim.SetBool("abrido",abrido);
                
                
            }
        }
        if(empezartiempo)
        {
            tiempo += Time.deltaTime;
            if (tiempo >= 1)
            {
                stay = true;
            }

            if (stay == true)
            {
                anim.SetBool("stay", stay);
                empezartiempo = false;
            }

        }
    }
}
