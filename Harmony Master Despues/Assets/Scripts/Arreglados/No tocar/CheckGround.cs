using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    private Player_Movement player;
    [SerializeField] LayerMask WhatGround;
    [SerializeField] Transform checkpoint;

    void Start()
    {
        player = GetComponentInParent<Player_Movement>();
        player.grounded = false;
    }

    private void Update()
    {


        if (Physics2D.OverlapCircle(this.checkpoint.position, 0.02f, this.WhatGround))
        {
            player.grounded = true;
        }
        else
        {
            player.grounded = false;
        }
    }

}
