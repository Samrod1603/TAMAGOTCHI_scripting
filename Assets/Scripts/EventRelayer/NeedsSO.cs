using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "needData", menuName = "ScriptableObjects/NeedsSO", order = 3)]
public class NeedsSO : ScriptableObject
{
    public float needValue;
    private float max = 100;
    [SerializeField]private float incrementValue;
    public float decrementValue;

    public event UnityAction<float> OnNeedChanged;

    public void needIncrement()
    {
        needValue += incrementValue;
        if (needValue >= max)
        {
            needValue = max;
        }
        
        OnNeedChanged?.Invoke(needValue);
    }

    public void needDecrement(float decrementValue)
    {
        needValue -= decrementValue;
        if (needValue <= 0)
        {
            needValue = 0;
        }
        
        OnNeedChanged?.Invoke(needValue);
    }
}
