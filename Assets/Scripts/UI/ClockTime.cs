using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockTime : MonoBehaviour
{
    [SerializeField] Text timeText;
    Canvas timeCanvas;


    [SerializeField] EventHandleData startEventData;
    [SerializeField] EventHandleData gameoverEventData;
    [SerializeField] EventHandleData victoryData;

    [SerializeField] VictoryEventHandle timeData;


    bool stop = true;

    float time;


    private void Awake()
    {
        timeCanvas = GetComponent<Canvas>();
    }

    private void OnEnable()
    {
        startEventData.AddListener(StartTime);
        gameoverEventData.AddListener(HideTime);
        victoryData.AddListener(Victory);
    }

    private void OnDisable()
    {
        startEventData.RemoveListener(StartTime);
        gameoverEventData.RemoveListener(HideTime);
        victoryData.RemoveListener(Victory);
    }

    private void FixedUpdate()
    {
        if (stop) return;

        time += Time.fixedDeltaTime;

        timeText.text = System.TimeSpan.FromSeconds(time).ToString("mm\\:ss\\:ff");

        //timeText.text = System.TimeSpan.FromSeconds(time).ToString(@"mm\:ss\:ff");
    }
    void StartTime()
    {
        stop = false;
    }

    void HideTime()
    {
        timeCanvas.enabled = false;
        stop = true;
    }

    void Victory()
    {
        HideTime();
        timeData.DoSomething(timeText.text);
    }



}
