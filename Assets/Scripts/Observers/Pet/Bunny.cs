using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunny : Pets
{
    public override void PrintName()
    {
        print("Hopps");
    }
    public void Jump()
    {
        print("Jumping!");
    }
}
