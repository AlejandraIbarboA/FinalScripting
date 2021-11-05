using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clarinete : MonoBehaviour
{
    public AudioClip sound;
    AudioSource clari;

    public Image clariimage;
    public Text cargastext;
    private bool claricool;

    private bool puede;
    public float cargas;
    public float Municion;

    public float tiempo = 0.0f;
    public float tiempoRecarga = 5.0f;

    private float TimeBTWShots;
    public float StartTimeBTWShots;

    public GameObject proyectil;
    public Transform point;

    private void Awake()
    {
        cargastext.text = cargas.ToString();
    }

    void Start()
    {
        clari = GetComponent<AudioSource>();
        clariimage.fillAmount = 1;
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
                claricooldown();
                claricool = true;
            }

            if (tiempo >= tiempoRecarga)
            {
                cargas = Municion;
                tiempo = 0.0f;
                cargastext.text = "4";
            }

            if (puede == true)
            {

                if (Input.GetKeyDown(KeyCode.H))
                {
                    Empujamiento();
                   
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

    void Empujamiento()
    {
        Instantiate(proyectil, point.position, transform.rotation);
        clari.clip = sound;
        clari.Play();
        cargas--;
        TimeBTWShots = StartTimeBTWShots;
        cargastext.text = cargas.ToString();
    }

    private void claricooldown()
    {
        if (claricool == true)
        {

            clariimage.fillAmount += 1 / tiempoRecarga * Time.deltaTime;

            if (clariimage.fillAmount >= 1)
            {
                clariimage.fillAmount = 0.0f;
                claricool = false;
            }

        }
    }
}
