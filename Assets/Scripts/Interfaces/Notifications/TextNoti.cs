using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextNoti : MonoBehaviour, iNotification, ISound
{
    [SerializeField] private GameObject noti;
    private TextMeshProUGUI txt;
    private AudioSource sound;
    private string txtString = "Necesito cuidados";
    
    void Awake()
    {
        txt = noti.GetComponent<TextMeshProUGUI>();
        sound = noti.GetComponent<AudioSource>();
    }
    
    public void ShowMessage()
    {
        txt.text = txtString;
    }

    public void UnshowMessage()
    {
        txt.text = "";
    }

    public void PlaySound()
    {
        sound.Play();
    }
}
