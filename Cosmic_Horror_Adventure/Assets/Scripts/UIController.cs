using System.Collections.Generic;
using Assets.WUG.Scripts;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;
using Unity.VisualScripting;


public class UIController : MonoBehaviour
{
    public GameObject Canvas;
    private GameObject DarkOverlay;
    private GameObject InventoryUI;
    private GameObject PauseUI;
    
    void Start()
    {
        DarkOverlay = Canvas.transform.GetChild(0).gameObject;
        InventoryUI = Canvas.transform.GetChild(1).gameObject;
        PauseUI = Canvas.transform.GetChild(2).gameObject;
        Debug.Log(DarkOverlay);
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
}