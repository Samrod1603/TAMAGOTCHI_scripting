using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pet : MonoBehaviour
{
    private IState currentState;

    public abstract void Name();

    public void Alive()
    {
        currentState = new AliveState();
        currentState.SpriteChange(this);
    }

    public void Dead()
    {
        currentState = new DeadState();
        currentState.SpriteChange(this);
    }
}
