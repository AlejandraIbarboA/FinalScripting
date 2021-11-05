using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrumento : MonoBehaviour
{
    private int municionActual;

    private bool poderDisparar;
    private float coolDown;
    protected float timer = 0f;

    protected AudioSource audioSource;

    protected float TimeBTWShots;


    public int MunicionActual { get => municionActual; set => municionActual = value; }
    public float CoolDown { get => coolDown; set => coolDown = value; }
    public bool PoderDisparar { get => poderDisparar; set => poderDisparar = value; }

    protected virtual void Disparar()
    {
        
    }

    public void Recargar(int recarga)
    {
        MunicionActual += recarga;
    }

}
