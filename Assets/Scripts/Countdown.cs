using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject Count;
    public AudioSource GetReady;
    public AudioSource Go;
    public AudioSource BackTrack;
    public GameObject LapTimer;
    public GameObject CarControls;
    public GameObject TryAgainButton;
    public GameObject MainMenuButton;

    // Start is called before the first frame update
    void Start()
    {
        TryAgainButton.SetActive(false);
        MainMenuButton.SetActive(false);
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        CarControls.GetComponent<Rigidbody>().mass = 9999999;
        yield return new WaitForSeconds(0.5f);
        Count.GetComponent<TMPro.TextMeshProUGUI>().text = "3";
        GetReady.Play();
        Count.SetActive(true);
        yield return new WaitForSeconds(1);
        Count.SetActive(false);
        Count.GetComponent<TMPro.TextMeshProUGUI>().text = "2";
        GetReady.Play();
        Count.SetActive(true);
        yield return new WaitForSeconds(1);
        Count.SetActive(false);
        Count.GetComponent<TMPro.TextMeshProUGUI>().text = "1";
        GetReady.Play();
        Count.SetActive(true);
        yield return new WaitForSeconds(1);
        Count.SetActive(false);
        Go.Play();
        LapTimer.SetActive(true);
        CarControls.GetComponent<Rigidbody>().mass = 950;
        BackTrack.Play();
    }
}
