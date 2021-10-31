using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lyra : MonoBehaviour
{
    public AudioClip sound;
    AudioSource lira;

    private bool puede;
    public float cargas;
    public float Municion;

    public float tiempo = 0.0f;
    public float tiempoRecarga = 7.0f;

    private float TimeBTWShots;
    public float StartTimeBTWShots;

    public Image liraimage;
    public Text cargastext;
    private bool liracool;

    private void Awake()
    {
        cargastext.text = cargas.ToString();
    }
    void Start()
    {
        lira = GetComponent<AudioSource>();
        liraimage.fillAmount = 1;
    }


    void Update()
    {
        if (TimeBTWShots <= 0)
        {
            if (cargas >= 1)
            {
                puede = true;
            }
            if (cargas == 0)
            {
                puede = false;
                tiempo += Time.deltaTime;
                liracooldown();
                liracool = true;
            }

            if (tiempo >= tiempoRecarga)
            {
                cargas = Municion;
                tiempo = 0.0f;
                cargastext.text = "2";
            }

            if (puede == true)
            {


                if (Input.GetKeyDown(KeyCode.H))
                {
                    disparoLyra();  
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.H))
                {
                    
                }
            }

        }
        else
        {
            TimeBTWShots -= Time.deltaTime;
        }

    }

    void disparoLyra()
    {
        
        lira.clip = sound;
        lira.Play();
        cargas--;
        TimeBTWShots = StartTimeBTWShots;
        cargastext.text = cargas.ToString();
    }

    private void liracooldown()
    {
        if (liracool == true)
        {

            liraimage.fillAmount += 1 / tiempoRecarga * Time.deltaTime;

            if (liraimage.fillAmount >= 1)
            {
                liraimage.fillAmount = 0.0f;
                liracool = false;
            }

        }
    }
}
