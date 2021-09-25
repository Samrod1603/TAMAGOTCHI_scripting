using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pets : MonoBehaviour
{
    public IState currentState;

    public abstract void PrintName();
}
