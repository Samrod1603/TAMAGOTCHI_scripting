using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextNoti : MonoBehaviour, iNotification
{
    [SerializeField] private TextMeshProUGUI txt;
    private string txtString = "Necesito cuidados";
    
    public void ShowMessage()
    {
        txt.text = txtString;
    }

    public void UnshowMessage()
    {
        txt.text = "";
    }
}
