using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetSelection : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i < gameObject.transform.childCount; i++)
        {
            Destroy(gameObject.transform.GetChild(i).gameObject);
        }
        gameObject.GetComponent<StateManager>().pet = gameObject.transform.GetChild(0).gameObject.GetComponent<Pets>();
    }
}
