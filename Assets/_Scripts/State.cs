using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected GameController Controller;

    public State(GameController controller)
    {
        Controller = controller;
    }
    public virtual IEnumerator Begin()
    {
        
        yield break;
    }

    public virtual IEnumerator UpdateSate()
    {

        yield break;
    }

    public virtual IEnumerator Exit()
    {

        yield break;
    }
}

