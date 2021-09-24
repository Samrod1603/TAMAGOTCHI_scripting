using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{
    [SerializeField] private NeedsSO needso;
    private iNotification _inoti;

    void Start()
    {
        _inoti = GetComponent<iNotification>();
    }
    
    
    void OnEnable()
    {
        needso.OnNeedChanged += chckBar;
    }

    void OnDisable()
    {
        needso.OnNeedChanged -= chckBar;
    }

    void chckBar(float value)
    {
        if (value <= 50)
        {
            _inoti.ShowMessage();
        }
        else
        {
            _inoti.UnshowMessage();
        }
    }

}
