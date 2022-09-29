using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VictoryUi : MonoBehaviour
{
    [SerializeField] EventHandleData eventData;

    [SerializeField] Button nextButton;

    [SerializeField] Text timeText;

    [SerializeField] VictoryEventHandle timeEventData;

    Canvas victoryCanva;
    Animator aim;

    private void Awake()
    {
        victoryCanva = GetComponent<Canvas>();
        aim = GetComponent<Animator>();
        
    }


    private void OnEnable()
    {
        eventData.AddListener(ShowVitctoryUI);
        timeEventData.AddListener(PrintTimeUI);
        nextButton.onClick.AddListener(SceneController.Reload);
    }

    private void OnDisable()
    {
        eventData.RemoveListener(ShowVitctoryUI);
        timeEventData.RemoveListener(PrintTimeUI);
        nextButton.onClick.RemoveListener(SceneController.Reload);
    }

    void ShowVitctoryUI()
    {
        victoryCanva.enabled = true;
        aim.enabled = true;
    }

    void PrintTimeUI(string value)
    {
        timeText.text = value;
    }



}
