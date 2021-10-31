using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerJuego : MonoBehaviour


{
   public Text textovidas;

   public int vidasactuales = 3;

    private void Awake()
    {
        textovidas.text = vidasactuales.ToString();
    }

    public void Actualizarvidas()
    {
        vidasactuales += 1;
        textovidas.text = vidasactuales.ToString();

   }

    public void RebajarVidas ()
    {
        vidasactuales -= 1;
        textovidas.text = vidasactuales.ToString();
    }
    
    
}

