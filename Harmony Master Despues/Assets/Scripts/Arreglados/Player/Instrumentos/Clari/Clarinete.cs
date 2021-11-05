using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clarinete : Instrumento
{
    [SerializeField] int municionInicial;
    [SerializeField] float StartTimeBTWShots;

    [SerializeField] float cooldownLocal;

    [SerializeField] GameObject proyectil;
    [SerializeField] Transform point;

    [SerializeField] AudioClip sound;

    private void Awake()
    {
        MunicionActual = municionInicial;
    }

    private void Start()
    {      
        audioSource = GetComponentInParent<AudioSource>();
        CoolDown = cooldownLocal;
    }

    void Update()
    {
        if (TimeBTWShots <= 0)
        {
            if (MunicionActual >= 1)
            {
                PoderDisparar = true;
            }
            else if (MunicionActual == 0)
            {
                PoderDisparar = false;
            }

            if (PoderDisparar == true)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    Disparar();
                }
            }
            else
            {
                timer += Time.deltaTime;
                if (timer >= CoolDown)
                {
                    Recargar(municionInicial);
                    timer = 0.0f;
                }
            }
        }
        else
        {
            TimeBTWShots -= Time.deltaTime;
        }

    }

    override protected void Disparar()
    {
        Instantiate(proyectil, point.position, transform.rotation);
        audioSource.clip = sound;
        audioSource.Play();
        municionInicial--;
        TimeBTWShots = StartTimeBTWShots;
    }
}
