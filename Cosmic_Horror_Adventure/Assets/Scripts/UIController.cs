using System.Collections;
using Assets.WUG.Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;
using Unity.VisualScripting;


public class UIController : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject StartingScenes;
    private GameObject DarkOverlay;
    private GameObject InventoryUI;
    private GameObject PauseUI;
    public GameObject ControlsUI;
    private GameObject ScreamingFrogLogo;
    private GameObject IntroText;    

    
    void Start()
    {
        // grab all elements from their parents
        DarkOverlay = Canvas.transform.GetChild(0).gameObject;
        InventoryUI = Canvas.transform.GetChild(1).gameObject;
        PauseUI = Canvas.transform.GetChild(2).gameObject;
        ControlsUI = Canvas.transform.GetChild(3).gameObject;
        ScreamingFrogLogo = StartingScenes.transform.GetChild(0).gameObject;
        IntroText = StartingScenes.transform.GetChild(1).gameObject;
        // play the starting scenes, this is a timed function
        PlayStartingScenes();
    }

    public void ToggleInventory()
    {
        // if already on, turn it off
        if (InventoryUI.activeSelf) {
            DarkOverlay.SetActive(false);
            InventoryUI.SetActive(false);
            Time.timeScale = 1;
        }
        //if already off, turn it on
        else {
            DarkOverlay.SetActive(true);
            InventoryUI.SetActive(true);
            InventoryUI.GetComponent<InventoryUIController>().Awake();
            Time.timeScale = 0;
        }
    }

    public void TogglePause()
    {
        // if already on, turn it off
        if (PauseUI.activeSelf) {
            DarkOverlay.SetActive(false);
            PauseUI.SetActive(false);
            Time.timeScale = 1;
        }
        //if already off, turn it on
        else {
            DarkOverlay.SetActive(true);
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void PlayStartingScenes()
    {
        // coroutine so we can make it wait for seconds
        StartCoroutine(TimedStartingScenes());
    }

    IEnumerator TimedStartingScenes()
    {
        // show studio logo then intro story
        ScreamingFrogLogo.SetActive(true);
        yield return new WaitForSeconds(3);
        ScreamingFrogLogo.SetActive(false);
        IntroText.SetActive(true);
        yield return new WaitForSeconds(15);
        IntroText.SetActive(false);
    }

    public void ResumeButtonCallback()
    {
        // callback for resume function
        Debug.Log("Resume Callback");
        TogglePause();
    }

    public void ControlsButtonCallback()
    {
        Debug.Log("Controls Callback");
        // if active deactivate
        if (ControlsUI.activeSelf)
        {
            ControlsUI.SetActive(false);
        // if inactive activate
        } else
        {
            ControlsUI.SetActive(true);
        }
    }

    public void RestartButtonCallback()
    {
        Debug.Log("Restart Callback");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}