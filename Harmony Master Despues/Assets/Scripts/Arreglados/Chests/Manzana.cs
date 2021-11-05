using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manzana : MonoBehaviour, IInteractive
{
    public void Interact(PlayerHealth vida, Instrumento instrumento)
    {
        vida.Heal(20);
        Destroy(gameObject);
    }
}
