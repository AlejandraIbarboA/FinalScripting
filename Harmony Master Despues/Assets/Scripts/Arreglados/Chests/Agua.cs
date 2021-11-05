using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agua : MonoBehaviour, IInteractive
{
    public void Interact(PlayerHealth vida, Sintetizador sinte)
    {
        sinte.Recargar(2);
        Destroy(gameObject);
    }
}
