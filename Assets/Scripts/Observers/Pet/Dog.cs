using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Pets
{
    public override void PrintName()
    {
        print("Perrete");
    }
    public override void Action()
    {
        print("Woof!");
    }
}
