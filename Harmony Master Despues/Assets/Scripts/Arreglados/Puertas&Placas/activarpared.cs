using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activarpared : MonoBehaviour
{
    [SerializeField] Transform targetfinal;
    [SerializeField] Transform targerinicial;
    [SerializeField] float speed;

    private Vector3 start, end;

    public bool subiendo;

    private void Start()
    {
        
        if (targetfinal != null)
        {
            targetfinal.parent = null;
            targerinicial.parent = null;
            start = targerinicial.position;
            end = targetfinal.position;
        }
    }

    public void subiri()
    {
        subiendo = true;
    }

    public void subiro()
    {
        subiendo = false;
    }
  

    public void FixedUpdate()
    {
        if (subiendo==true)
        {

            if (targetfinal != null)
            {
                float fixedspeed = speed * Time.deltaTime;


                transform.position = Vector3.MoveTowards(transform.position, targetfinal.position, fixedspeed);

            }
            
        }
       
        if(subiendo==false)
        {
            if(transform.position!=targerinicial.position)
            {
                float fixedspeed = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, targerinicial.position, fixedspeed);
            }
        }


    }

   
}
