using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agua : MonoBehaviour, IInteractive
{
    public void Interact(PlayerHealth vida, Instrumento instrumento)
    {
        instrumento.Recargar(2);
        Destroy(gameObject);
    }
}
