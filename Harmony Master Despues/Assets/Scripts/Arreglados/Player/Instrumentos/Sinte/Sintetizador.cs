using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sintetizador : MonoBehaviour
{
    [SerializeField] GameObject proyectil;
    [SerializeField] Transform point;
    [SerializeField] Image sintecooldownimage;
    [SerializeField] Text cargastext;

    private float TimeBTWShots;
    [SerializeField] float StartTimeBTWShots;

    [SerializeField] AudioClip sintesound;
    AudioSource Sinte;

    [SerializeField] float cargas;
    [SerializeField] float Municion;
    private bool puede;
    private bool sinCooldown;

    [SerializeField] float tiempo = 0.0f;
    [SerializeField] float tiempoRecarga = 4.0f;


    private void Awake()
    {
        cargastext.text = cargas.ToString();
    }

    private void Start()
    {
        Sinte = GetComponent<AudioSource>();
        sintecooldownimage.fillAmount=1;
    }

    void Update()
    {
        cargastext.text = cargas.ToString();
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
                SintCooldown();
                sinCooldown = true;

            }

            if (tiempo >= tiempoRecarga)
            {
                cargas = Municion;
                tiempo = 0.0f;
                cargastext.text = "5";
                
            }

            if (puede == true)
            {

                if (Input.GetKeyDown(KeyCode.H))
                {
                    disparito();

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

    public void Recargar(int municion)
    {
        cargas += municion;
    }

    void disparito()
    {

        Instantiate(proyectil, point.position, transform.rotation);
        LineRenderer line = proyectil.GetComponent<LineRenderer>();
        TimeBTWShots = StartTimeBTWShots;
        Sinte.clip = sintesound;
        Sinte.Play();
        this.cargas--;


    }

    void SintCooldown()
    {
        if (sinCooldown == true)
        {
            
            sintecooldownimage.fillAmount += 1 / tiempoRecarga * Time.deltaTime;
            
            if (sintecooldownimage.fillAmount >= 1)
            {
                sintecooldownimage.fillAmount = 0.0f;
                sinCooldown = false;
            }

        }
    }

 

    
}
