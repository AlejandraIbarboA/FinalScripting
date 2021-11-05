using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentSystem : MonoBehaviour
{
    //Animator
    private Animator anim;
    public Animator Anim => anim;

    //Scripts
    private Sintetizador sinteScript;
    private Clarinete clariScript;

    public Sintetizador SinteScript => sinteScript;
    public Clarinete ClariScript => clariScript;

    //Locales
    private State currentState;
    private int stateEnum = 0;

    public void SetState(State _state)
    {
        currentState = _state;
        StartCoroutine(currentState.Synthe());
    }

    void Awake()
    {
        anim = GetComponent<Animator>();
        sinteScript = GetComponent<Sintetizador>();
        clariScript = GetComponent<Clarinete>();
    }

    private void Start()
    {
        SetState(new SinteState(this));
    }

    void Update()
    {
        if (stateEnum == 0 && Input.GetButtonDown("Fire2"))
        {
            SetState(new ClarinetState(this));
            StartCoroutine(currentState.Clari());
            stateEnum = 1;
        }
        else if (stateEnum == 1 && Input.GetButtonDown("Fire2"))
        {
            SetState(new SinteState(this));
            StartCoroutine(currentState.Synthe());
            stateEnum = 0;
        }
    }
}
