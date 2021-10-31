using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Vida : MonoBehaviour
{
    public float hpp;
    

    
    public void hurtplayer(float Damageplayer)
    {
        this.hpp -= Damageplayer;
        if (this.hpp <= 0)
        {

            Destroy(this.gameObject);
        }
    }
}
