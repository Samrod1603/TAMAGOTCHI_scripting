using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pet : MonoBehaviour
{
    [SerializeField] NeedsSO channel;
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

    private void SliderChange(float hunger)
    {

    }
    private void OnEnable()
    {
        channel.OnNeedChanged += SliderChange;

    }
    private void OnDisable()
    {
        channel.OnNeedChanged -= SliderChange;
    }
}
