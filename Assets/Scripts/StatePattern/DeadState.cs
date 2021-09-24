using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadState : IState
{
    [SerializeField] Sprite dead;

    public void SpriteChange(Pet pet)
    {
        pet.GetComponent<SpriteRenderer>().sprite = dead;
    }
}
