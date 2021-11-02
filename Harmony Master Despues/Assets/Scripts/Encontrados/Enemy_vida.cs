using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_vida : MonoBehaviour
{
    public float hp;
    public GameObject boom;
    public Transform explo;

    public GameObject grito;


    public void hurt(float Damage)
    {
        this.hp -= Damage;
        if (this.hp <= 0)
        {
            Instantiate(boom,explo.position, explo.rotation);
            Instantiate(grito, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
