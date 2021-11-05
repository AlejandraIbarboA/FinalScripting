using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class controljuego : MonoBehaviour
{
    public static int NivelesDesbloqueados;
    public int NivelActual;
    public int datos;

    public GameObject puerta2;
    public GameObject puerta3;
    public GameObject candado2;
    public GameObject candado3;
    public GameObject candado4;

    private void Start()
    {
        datos = NivelesDesbloqueados;
    }

    public void DesbloquearNivel()
    {
        if (NivelesDesbloqueados < NivelActual)
        {
            NivelesDesbloqueados = NivelActual;
            
        }
    }

    public void Update()
    {
        if (puerta2 != null && puerta3 != null && candado2 != null && candado3 != null && candado4 != null)
        {
            if (datos == 1)
            {
                puerta2.SetActive(true);
                candado2.SetActive(false);
            }

            if (datos == 2)
            {
                puerta2.SetActive(true);
                candado2.SetActive(false);
                puerta3.SetActive(true);
                candado3.SetActive(false);
            }

            if (datos == 3)
            {
                puerta2.SetActive(true);
                candado2.SetActive(false);
                puerta3.SetActive(true);
                candado3.SetActive(false);
                candado4.SetActive(false);
            }
        }


    }
    

}
