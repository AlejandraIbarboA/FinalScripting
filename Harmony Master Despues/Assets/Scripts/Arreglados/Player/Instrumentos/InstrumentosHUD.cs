using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstrumentosHUD : MonoBehaviour
{
    [SerializeField] Instrumento intrumento;
    [SerializeField] Image coolDownImage;
    [SerializeField] Text cargasText;
    private float rellenar;

    void Start()
    {        
        rellenar = 1f / (float)intrumento.MunicionActual;
    }

    void Update()
    {
        cargasText.text = intrumento.MunicionActual.ToString();
        if (!intrumento.PoderDisparar)
        {
            coolDownImage.fillAmount += 1 / intrumento.CoolDown * Time.deltaTime;
        }
        else
        {
            coolDownImage.fillAmount = rellenar * intrumento.MunicionActual;
        }
    }
}
