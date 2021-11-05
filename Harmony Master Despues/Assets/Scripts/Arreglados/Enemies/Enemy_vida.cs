using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_vida : MonoBehaviour
{
    [SerializeField] float hp;
    [SerializeField] GameObject boom;
    [SerializeField] Transform explo;

    [SerializeField] AudioSource audio;
    [SerializeField] AudioClip deadSound;

    public void hurt(float Damage)
    {
        this.hp -= Damage;
        if (this.hp <= 0)
        {
            Instantiate(boom, explo.position, explo.rotation);
            audio.clip = deadSound;
            audio.Play();
            Destroy(gameObject);
        }
    }
}
