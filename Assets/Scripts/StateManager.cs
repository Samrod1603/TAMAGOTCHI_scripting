using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    [SerializeField] private NeedsSO channel;

    private AliveState aliveState = new AliveState();
    private DeadState deadState = new DeadState();
    
   
    public Pets pet;

   // [SerializeField] GameObject button;


    private void Start()
    {
        pet.Action();
        pet.currentState = aliveState;
        pet.currentState.SpriteChange(pet);
    }

    
    //eventos
    
    void StateUpdate(float value)
    {
        if (value == 0f)
        {
            
            print("murido"); //
            pet.currentState = deadState;
            pet.currentState.SpriteChange(pet);
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
