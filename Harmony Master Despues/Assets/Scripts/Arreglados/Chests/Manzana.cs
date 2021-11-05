using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manzana : MonoBehaviour, IInteractive
{
    public void Interact(PlayerHealth vida, Sintetizador sinte)
    {
        vida.Heal(20);
        Destroy(gameObject);
    }
}
