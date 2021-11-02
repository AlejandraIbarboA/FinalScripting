using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrumentos_Manager : MonoBehaviour
{
    public GameObject Sint;
    public GameObject Clar;

    public bool pia;
    public bool cla;

    public bool animpia;
    public bool animcla;

    [SerializeField] Animator anim;

    void Start()
    {
        sintetizador();
        //anim = GetComponent<Animator>();
    }

    void DesactivarBools()
    {
        animpia = false;
        animcla = false;
        anim.SetBool("sinte", animpia);
        anim.SetBool("flauta", animcla);
    }

    void Update()
    {
        if (pia == true)
        {
            if (Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.J))
            {
                Clarinete();
            }
        }
        else
         if (cla == true)
        {
            if (Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.J))
            {
                sintetizador();
            }
        }

    }

    void sintetizador()
    {
        DesactivarBools();
        Sint.SetActive(true);
        Clar.SetActive(false);
        pia = true;
        cla = false;
        animpia = true;
        anim.SetBool("sinte", animpia);
    }

    void Clarinete()
    {
        DesactivarBools();
        Sint.SetActive(false);
        Clar.SetActive(true);
        pia = false;
        cla = true;
        animcla = true;
        anim.SetBool("flauta", animcla);
    }

}
