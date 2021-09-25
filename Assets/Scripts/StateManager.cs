using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    [SerializeField] private NeedsSO channel;

    public Pets pet;

    private void Start()
    {
        pet.Action();
    }

    //eventos

    void StateUpdate(float value)
    {
        if (value == 0f)
        {
            print("murido"); //
            //pet.currentState = new DeadState();
        }
    }
    private void OnEnable()
    {
        channel.OnNeedChanged += StateUpdate;

    }
    private void OnDisable()
    {
        channel.OnNeedChanged -= StateUpdate;
    }
}
