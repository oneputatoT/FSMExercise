using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] EventHandleData gameOverData;

    [SerializeField] Button reload;

    [SerializeField] Button quit;

    [SerializeField] AudioClip[] defeatClips;


    private void OnEnable()
    {
        gameOverData.AddListener(ShowGameOverUI);
        reload.onClick.AddListener(SceneController.Reload);
        quit.onClick.AddListener(SceneController.Quit);
    }

    private void OnDisable()
    {
        gameOverData.RemoveListener(ShowGameOverUI);
        reload.onClick.RemoveListener(SceneController.Reload);
        quit.onClick.RemoveListener(SceneController.Quit);
    }

    void ShowGameOverUI()
    {
        Cursor.lockState = CursorLockMode.None;

        AudioManager.audioSource.PlayOneShot(defeatClips[Random.Range(0, defeatClips.Length)]);

        GetComponent<Canvas>().enabled = true;
        GetComponent<Animator>().enabled = true;
    }


}
