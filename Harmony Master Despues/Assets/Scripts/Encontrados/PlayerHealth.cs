using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    [Header("Vida")]
    [SerializeField] int startingHealth = 100;
    public int currentHealth;

    [Header("UI")]
    [SerializeField] Slider healthSlider;
    [SerializeField] Image damageImage;
    [SerializeField] float flashSpeed = 5f;
    [SerializeField] Color flashColour = new Color(1f, 0f, 0f, 0.1f);

    float timer;
    private bool empezartiempo;


    private Rigidbody2D PlayerRigidbody;
    private bool damaged;

    private Animator anim;

    [SerializeField] AudioClip damageSound;
    AudioSource audio;
    DeadVerify deadVerify;

    void Awake()
    {
        PlayerRigidbody = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        deadVerify = GetComponent<DeadVerify>();
    }

    private void Start()
    {
        deadVerify.death += Morir;
    }

    private void OnDestroy()
    {
        deadVerify.death -= Morir;
    }

    void Update()
    {
        healthSlider.value = currentHealth;

        if (damaged)
        {
            audio.clip = damageSound;
            audio.Play();
            damageImage.color = flashColour;
        }

        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;

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

    private void Morir()
    {
        PlayerRigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
        anim.SetBool("sinte", false);
        anim.SetBool("flauta", false);
        anim.SetTrigger("muerto");
        empezartiempo = true;
    }
}


