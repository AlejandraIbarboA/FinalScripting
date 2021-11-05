using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrumentos_Manager : MonoBehaviour
{
    public GameObject Sint;
    public GameObject Clar;
    public GameObject Bong;
    public GameObject Arp;

    public bool pia;
    public bool cla;
    public bool boni;
    public bool arpita;

    public bool animpia;
    public bool animcla;
    public bool animboni;
    public bool animarpita;

    [SerializeField]Animator anim;

    void Start()
    {
        sintetizador();
        //anim = GetComponent<Animator>();
    }

    void DesactivarBools()
    {
        animpia = false;
        animcla = false;
        animboni = false;
        animarpita = false;

        anim.SetBool("sinte", animpia);
        anim.SetBool("flauta", animcla);
        anim.SetBool("bongos", animboni);
        anim.SetBool("arpa", animarpita);
    }
   
    void Update()
    {
       if (pia==true)
        {
            if(Input.GetKeyDown(KeyCode.K))
            {
                Clarinete();
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                Arpar();
            }
        }
        else 
        if (cla == true)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                Bongos();
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                sintetizador();
            }
        }
        else
        if (boni == true)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                Arpar();
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                Clarinete();
            }
        }
        else
        if (arpita == true)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
               sintetizador();
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                Bongos();
            }
        }
        
    }

    void sintetizador()
    {
        DesactivarBools();
        Sint.SetActive(true);
        Clar.SetActive(false);
        Bong.SetActive(false);
        Arp.SetActive(false);
        pia = true;
        cla = false;
        boni = false;
        arpita = false;
        animpia = true;
        anim.SetBool("sinte",animpia);
    }

    void Clarinete()
    {
        DesactivarBools();
        Sint.SetActive(false);
        Clar.SetActive(true);
        Bong.SetActive(false);
        Arp.SetActive(false);
        pia = false;
        cla = true;
        boni = false;
        arpita = false;
        animcla = true;
        anim.SetBool("flauta", animcla);
    }

    void Bongos()
    {
        DesactivarBools();
        Sint.SetActive(false);
        Clar.SetActive(false);
        Bong.SetActive(true);
        Arp.SetActive(false);
        pia = false;
        cla = false;
        boni = true;
        arpita = false;
        animboni = true;
        anim.SetBool("bongos", animboni);
    }

    void Arpar()
    {
        DesactivarBools();
        Sint.SetActive(false);
        Clar.SetActive(false);
        Bong.SetActive(false);
        Arp.SetActive(true);
        pia = false;
        cla = false;
        boni = false;
        arpita = true;
        animarpita = true;
        anim.SetBool("arpa", animarpita);
    }

}
