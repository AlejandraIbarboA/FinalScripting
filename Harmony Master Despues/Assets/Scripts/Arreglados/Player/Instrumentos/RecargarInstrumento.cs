using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecargarInstrumento : MonoBehaviour
{
    Instrumento instrumento;
    [SerializeField] private float timer = 0f;
    [SerializeField] bool recargando = false;

    void Start()
    {
        instrumento = GetComponent<Instrumento>();
    }

    private void Update()
    {
        if (recargando)
        {
            timer += Time.deltaTime;

        }

        if (instrumento.Recargado)
        {
            recargando = false;
            timer = 0f;
        }
    }

    public void Recargar(int municionInicial)
    {
        if (!instrumento.PoderDisparar)
        {
            recargando = true;
        }
        if (timer >= instrumento.CoolDown)
        {
            if (instrumento.enabled)
            {
                Debug.Log("recargado");
                instrumento.Recargar(municionInicial);
            }
        }
    }
}
