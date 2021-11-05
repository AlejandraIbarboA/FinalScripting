using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrumento : MonoBehaviour
{
    private int municionActual;

    private bool poderDisparar;
    private float coolDown;
    private bool recargado = false;

    protected AudioSource audioSource;

    protected float TimeBTWShots;

    protected RecargarInstrumento recarga;


    public int MunicionActual { get => municionActual; set => municionActual = value; }
    public float CoolDown { get => coolDown; set => coolDown = value; }
    public bool PoderDisparar { get => poderDisparar; set => poderDisparar = value; }
    public bool Recargado { get => recargado; set => recargado = value; }

    protected virtual void Disparar()
    {
        
    }

    public void Recargar(int recarga)
    {
        MunicionActual += recarga;
    }

}
