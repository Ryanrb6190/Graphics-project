using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPSCounter : MonoBehaviour
{

    public TextMeshProUGUI FPSText;
    public TextMeshProUGUI memoryText;

    private float pollingTime = 1f;
    private float time;
    private int frameCount;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        long totalMemory = System.GC.GetTotalMemory(false);

        float totalMemoryMB = totalMemory / (1024f * 1024f);

        frameCount++;

        if(time >= pollingTime){
            int frameRate = Mathf.RoundToInt(frameCount/time);
            FPSText.text = frameRate.ToString() + " FPS";
            memoryText.text = "Total Memory Used: " + totalMemoryMB.ToString("F2") + " MB";
            time -= pollingTime;
            frameCount = 0;
        }
    }
}
