using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedDecrement : MonoBehaviour
{
    [SerializeField] protected NeedsSO channel;

    void Start()
    {
        channel.needValue = 100;
    }

    void Update()
    {
        channel.needDecrement(channel.decrementValue * Time.deltaTime);
    }
    
}
