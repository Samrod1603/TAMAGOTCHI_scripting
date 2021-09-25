using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    //singleton
    /*private static StateManager instance = null;
    private StateManager() { }

    public static StateManager Instance
    {
        get
        {
            if (instance == null)
                instance = new StateManager();
            return instance;
        }
    }*/

    [SerializeField] private NeedsSO channel;
    float value;

    [SerializeField] Pets pet;

    private void Start()
    {
        value = channel.needValue;
    }

    //eventos

    void StateUpdate()
    {
        if (value == 0f)
        {
            print("murido"); //
            //pet.currentState = new DeadState();
        }
    }
}
