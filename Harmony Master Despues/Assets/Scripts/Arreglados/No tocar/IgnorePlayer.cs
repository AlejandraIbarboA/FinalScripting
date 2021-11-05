using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorePlayer : MonoBehaviour
{
    [SerializeField] GameObject ignore1;
    [SerializeField] GameObject ignore2;
    
    private void Update()
    {
       
       Physics2D.IgnoreCollision(ignore1.GetComponent<Collider2D>(), ignore2.GetComponent<Collider2D>());

    }

 

}
