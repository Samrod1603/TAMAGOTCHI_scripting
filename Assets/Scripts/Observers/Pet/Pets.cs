using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pets : MonoBehaviour
{
    public IState currentState;

    public abstract void PrintName();
    public abstract void Action();

    public virtual void Dead()
    {
        currentState = new DeadState();
        currentState.SpriteChange(this);
    }
}
