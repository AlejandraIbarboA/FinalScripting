using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorePlayer : MonoBehaviour
{
    public GameObject ignore1;
    public GameObject ignore2;
    
    private void Update()
    {
       
       Physics2D.IgnoreCollision(ignore1.GetComponent<Collider2D>(), ignore2.GetComponent<Collider2D>());

    }

 

}
