using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerificarInteraccion : MonoBehaviour
{
    private PlayerHealth playerHealth;
    private Sintetizador sinte;

    private void Awake()
    {
        playerHealth = GetComponent<PlayerHealth>();
        sinte = GetComponent<Sintetizador>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "interact")
        {
            IInteractive interaction = other.GetComponent<IInteractive>();
            interaction.Interact(playerHealth, sinte);
        }
    }
}
