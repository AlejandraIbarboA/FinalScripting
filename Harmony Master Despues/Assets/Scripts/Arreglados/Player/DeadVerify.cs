using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadVerify : MonoBehaviour
{
    PlayerHealth player;
    public delegate void PlayerDead();
    public event PlayerDead death;

    private void Start()
    {
        player = GetComponent<PlayerHealth>();
    }

    void Update()
    {
        if (player.currentHealth <= 0)
        {
            death?.Invoke();
        }
    }
}