using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bongos : MonoBehaviour
{
    private Player_Movement player;

    private bool doubleJump;
    private bool triplejump;
    public Image bongoscoolimage;
    public Text cargastext;

    public AudioClip sound;
    AudioSource Bongo;

    private bool puede;
    public float cargas;
    public float Municion;
    private bool bonCooldown;

    public float tiempo = 0.0f;
    public float tiempoRecarga = 6.0f;

    public float Maxspeedy;

    private void Awake()
    {
        cargastext.text = cargas.ToString();
    }

    void Start()
    {
        player = GetComponentInParent<Player_Movement>();
        Bongo = GetComponent<AudioSource>();
        bongoscoolimage.fillAmount = 1;

    }

    private void Update()
    {
       if (cargas >= 1)
        {
            puede = true;
        }
        if (cargas == 0)
        {
            puede = false;
            tiempo += Time.deltaTime;
            bonCooldown = true;
            bongocooldown();
        }

        if (tiempo >= tiempoRecarga)
        {
            cargas = Municion;
            tiempo = 0.0f;
            cargastext.text = "2";
        }

        if (puede == true)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (player.grounded)
                {
                    player.jump = true;
                    doubleJump = true;
                    triplejump = true;
                }
                else if (doubleJump)
                {

                    player.PlayerRigidbody.AddForce(Vector2.up * 4f, ForceMode2D.Impulse);
                    doubleJump = false;
                    triplejump = true;
                    Bongo.clip = sound;
                    Bongo.Play();
                    this.cargas--;
                    cargastext.text = cargas.ToString();
                }
                else if (triplejump)
                {

                    player.PlayerRigidbody.AddForce(Vector2.up * 4f, ForceMode2D.Impulse);
                    doubleJump = false;
                    triplejump = false;
                    Bongo.clip = sound;
                    Bongo.Play();
                    this.cargas--;
                    cargastext.text = cargas.ToString();
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.W))
            {

            }
        }
       
    }

    private void bongocooldown()
    {
        if (bonCooldown == true)
        {

            bongoscoolimage.fillAmount += 1 / tiempoRecarga * Time.deltaTime;

            if (bongoscoolimage.fillAmount >= 1)
            {
                bongoscoolimage.fillAmount = 0.0f;
                bonCooldown = false;
            }

        }
    }


}
