using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliveState :  IState
{
   
    public void SpriteChange(Pets pet)
    {
        pet.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
