using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    [SerializeField] private NeedsSO channel;
   
    public Pets pet;

   // [SerializeField] GameObject button;


    private void Start()
    {
      
        pet.Action();
        pet.currentState = new AliveState();
        pet.currentState.SpriteChange(pet);
    }

    
    //eventos
    
    void StateUpdate(float value)
    {
        if (value == 0f)
        {
            
            print("murido"); //
            pet.Dead();
           // button.SetActive(false);
          
        }
        else if (value > 0f)
        {
          
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

    public void SpriteChange(Pets pet)
    {
        throw new System.NotImplementedException();
    }
}
