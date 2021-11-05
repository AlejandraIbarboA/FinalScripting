using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirCasillero : MonoBehaviour
{
    [SerializeField] GameObject[] objeto;
    Animator anim;
    private bool poderAbrir;
    private bool abierto = false;
    [SerializeField] Transform spawnPoint;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            poderAbrir = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            poderAbrir = false;
        }
    }

    public void Sacar ()
    {
        if (!abierto)
        {
            int alea = Random.Range(0, objeto.Length);
            Instantiate(objeto[alea], spawnPoint);
        }

    }


    void Update()
    {
        if(poderAbrir)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                Sacar();
                abierto = true;
                anim.SetBool("abrido", abierto);              
            }       
        }
    }
}
