using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placa : MonoBehaviour
{
    Animator anim;

    private bool subiendo;

    [SerializeField] activarpared activarpared;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Enemy")||other.CompareTag("caja"))
        {
            anim.SetBool("apretada", true);
            anim.SetBool("desapretada", false);
            activarpared.SendMessage("subiri", this.subiendo = true);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        anim.SetBool("desapretada", true);
        anim.SetBool("apretada", false);
        activarpared.SendMessage("subiro", this.subiendo = false);
    }
}
