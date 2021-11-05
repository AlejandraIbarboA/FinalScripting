using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClarinetState : State
{
    public ClarinetState(InstrumentSystem insSystem) : base(insSystem)
    {

    }

    public override IEnumerator Clari()
    {
        InsSystem.Anim.SetBool("flauta", true);
        InsSystem.Anim.SetBool("sinte", false);

        InsSystem.SinteScript.enabled = false;
        InsSystem.ClariScript.enabled = true;

        return base.Clari();
    }
}
