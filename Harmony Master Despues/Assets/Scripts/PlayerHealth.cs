using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public Image damageImage;
    public float flashSpeed = 5f;
    public float timer;
    public bool empezartiempo;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);

    public Rigidbody2D PlayerRigidbody;
    bool isDead;
    bool damaged;

    public Animator anim;
    public bool cmurio;
    
    public Transform resurreccion;

    public bool animpia;
    public bool animcla;
    public bool animboni;
    public bool animarpita;

    public AudioClip oof;
    AudioSource duele;

    void Awake()
    {

        //playerAudio = GetComponent<AudioSource>();
        //playerMovement = GetComponent<PlayerMovement>();
        //playerShooting = GetComponentInChildren <PlayerShooting> ();
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        duele = GetComponent<AudioSource>();
        
    }


    void Update()
    {
        healthSlider.value = currentHealth;
        if (damaged==true)
        {
            duele.clip = oof;
            duele.Play();
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;

        if (currentHealth <= 0)
        {
            PlayerRigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
            
            cmurio = true;
            animpia = false;
            animcla = false;
            animboni = false;
            animarpita = false;

            anim.SetBool("sinte", animpia);
            anim.SetBool("flauta", animcla);
            anim.SetBool("bongos", animboni);
            anim.SetBool("arpa", animarpita);
            anim.SetTrigger("muerto");
            empezartiempo = true;
            

        }
        else
        {
            cmurio = false;
        }

        if (empezartiempo)
        {
            timer += Time.deltaTime;
            if (timer >= 3.4)
            {
                revivir();
            }
        }

        
        
    }

    public void revivir()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

  
    public void TakeDamage(int attackDamage)
    {
        damaged = true;
        currentHealth = Mathf.Clamp(currentHealth - attackDamage, 0, startingHealth);
        currentHealth -= attackDamage;
       
   
    }

    
   


    public void RestartLevel()
    {
        SceneManager.LoadScene("Nivel 1");
    }
}

