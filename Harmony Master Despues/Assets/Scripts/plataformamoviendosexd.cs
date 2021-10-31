using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformamoviendosexd : MonoBehaviour
{
    public Transform target;
    public float speed;

    private Vector3 start, end;

    void Start()
    {
        if (target != null)
        {
            target.parent = null;
            start = transform.position;
            end = target.transform.position;
        }
    }

    
    void Update()
    {
        
    }

    public void FixedUpdate()
    {
        if (target != null)
        {
            float fixedspeed = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, fixedspeed);

        }
        else
        {

        }

        if (transform.position == target.position)
        {
            target.position = (target.position == start) ? end : start;
        }
    }

 
}
