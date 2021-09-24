using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunny : Pet
{
    public override void Name()
    {
        print("Hops");
    }

    public void Jump()
    {
        print("Jumping!");
    }
}
