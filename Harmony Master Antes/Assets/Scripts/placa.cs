using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placa : MonoBehaviour
{
    private bool subir;
    private bool bajar;
    public Animator anim;

    public bool subiendo;

    public activarpared activarpared;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Enemy")||other.CompareTag("caja"))
        {
            subir = true;
            bajar = false;
            anim.SetBool("apretada", subir);
            anim.SetBool("desapretada", bajar);
            activarpared.SendMessage("subiri", this.subiendo = true);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        subir = false;
        bajar = true;
        anim.SetBool("desapretada", bajar);
        anim.SetBool("apretada", subir);
        activarpared.SendMessage("subiro", this.subiendo = false);
    }
}
