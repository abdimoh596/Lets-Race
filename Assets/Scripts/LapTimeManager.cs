using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{

    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;
    public static float RawTime;


    void Update()
    {
        MilliCount += Time.deltaTime * 10;
        RawTime += Time.deltaTime;
        MilliDisplay = MilliCount.ToString("F0");
        MilliBox.GetComponent <TMPro.TextMeshProUGUI> ().text = "" + MilliDisplay;

        if (MilliCount >= 10)
        {
            MilliCount = 0;
            SecondCount += 1;
        }

        if (SecondCount <= 9)
        {
            SecondBox.GetComponent<TMPro.TextMeshProUGUI>().text = "0" + SecondCount + ".";
        }
        else
        {
            SecondBox.GetComponent<TMPro.TextMeshProUGUI>().text = "" + SecondCount + ".";
        }

        if (SecondCount >= 60)
        {
            SecondCount = 0;
            MinuteCount += 1;
        }

        if (MinuteCount <= 9)
        {
            MinuteBox.GetComponent<TMPro.TextMeshProUGUI>().text = "0" + MinuteCount + ":";
        }
        else
        {
            MinuteBox.GetComponent <TMPro.TextMeshProUGUI> ().text = "" + MinuteCount + ":";
        }

    }
}
