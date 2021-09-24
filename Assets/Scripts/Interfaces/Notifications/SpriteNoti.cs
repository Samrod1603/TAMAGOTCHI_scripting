using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteNoti : MonoBehaviour, iNotification
{
    [SerializeField] private GameObject msgs;
    
    public void ShowMessage()
    {
        msgs.SetActive(true);
    }

    public void UnshowMessage()
    {
        msgs.SetActive(false);
    }
}
