using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sintetizador : MonoBehaviour
{
    public GameObject proyectil;
    public Transform point;
    public Image sintecooldownimage;
    public Text cargastext;

    private float TimeBTWShots;
    public float StartTimeBTWShots;

    public AudioClip sintesound;
    AudioSource Sinte;

    public float cargas;
    public float Municion;
    private bool puede;
    private bool sinCooldown;

    public float tiempo = 0.0f;
    public float tiempoRecarga = 4.0f;


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

    void disparito()
    {

        Instantiate(proyectil, point.position, transform.rotation);
        LineRenderer line = proyectil.GetComponent<LineRenderer>();
        TimeBTWShots = StartTimeBTWShots;
        Sinte.clip = sintesound;
        Sinte.Play();
        this.cargas--;
        cargastext.text = cargas.ToString(); 

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
