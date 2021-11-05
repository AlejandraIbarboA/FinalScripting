using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected readonly InstrumentSystem InsSystem;

    public State(InstrumentSystem system)
    {
        InsSystem = system;
    }

    public virtual IEnumerator Synthe()
    {
        yield break;
    }

    public virtual IEnumerator Clari()
    {
        yield break;
    }
}
