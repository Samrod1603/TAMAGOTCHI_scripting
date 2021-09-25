using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadState : IState
{
    public void SpriteChange(Pets pet)
    {
        pet.GetComponent<SpriteRenderer>().color = Color.red;
        GameObject.FindGameObjectWithTag("Button").SetActive(false);
    }
}
