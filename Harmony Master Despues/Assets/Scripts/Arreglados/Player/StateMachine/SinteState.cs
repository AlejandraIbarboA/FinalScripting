using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinteState : State
{
    public SinteState(InstrumentSystem insSystem) : base(insSystem)
    {

    }

    public override IEnumerator Synthe()
    {
        InsSystem.Anim.SetBool("flauta", false);
        InsSystem.Anim.SetBool("sinte", true);

        InsSystem.SinteScript.enabled = true;
        InsSystem.ClariScript.enabled = false;
        return base.Synthe();
    }
}
