using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class letrero : MonoBehaviour
{
    public GameObject letro;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            letro.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            letro.SetActive(false);
        }
    }
}
