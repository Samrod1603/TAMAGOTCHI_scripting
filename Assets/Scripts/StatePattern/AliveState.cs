using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliveState : IState
{
    [SerializeField] Sprite alive;
    
    public void SpriteChange(Pet pet)
    {
        pet.GetComponent<SpriteRenderer>().sprite = alive;
    }
}
