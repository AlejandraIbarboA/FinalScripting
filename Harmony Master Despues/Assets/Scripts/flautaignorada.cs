using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flautaignorada : MonoBehaviour
{
    
    private GameObject ignore2;

    private void Start()
    {
        ignore2 = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {

        Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), ignore2.GetComponent<Collider2D>());

    }
}
