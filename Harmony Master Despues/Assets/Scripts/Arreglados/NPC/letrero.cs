using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class letrero : MonoBehaviour
{
    [SerializeField] GameObject letro;
    [SerializeField] Transform point;
    GameObject letreroSpawned;

    private void Start()
    {
        letreroSpawned = Instantiate(letro, point);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            letreroSpawned.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            letreroSpawned.SetActive(false);
        }
    }
}
