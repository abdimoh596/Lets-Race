using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfWayTrigger : MonoBehaviour
{
    public GameObject LapCompleteTrigger;
    public GameObject HalfLapTrigger;

    void OnTriggerEnter()
    {
        LapCompleteTrigger.SetActive(true);
        HalfLapTrigger.SetActive(false);
    }
}
