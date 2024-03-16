using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceFinish : MonoBehaviour
{
    public GameObject Car;
    public GameObject Music;
    public GameObject CompleteTrigger;
    public GameObject TryAgainButton;
    public GameObject MainMenuButton;

    void OnTriggerEnter()
    {
        Car.SetActive(false);
        CompleteTrigger.SetActive(false);
        Car.GetComponent<Rigidbody>().mass = 9999999999;
        Car.SetActive(true);
        Music.SetActive(false);
        TryAgainButton.SetActive(true);
        MainMenuButton.SetActive(true);
        
    }
}
