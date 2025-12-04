using System.Collections.Generic;
using Assets.WUG.Scripts;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;


public class UIController : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject UI;
    bool Active;

    public void ToggleInventory()
    {
        // if already on, turn it off
        if (Active) {
            Active = false;
            Canvas.SetActive(false);
            Time.timeScale = 1;
        }
        //if already off, turn it on
        else {
            Active = true;
            Canvas.SetActive(true);
            UI.GetComponent<InventoryUIController>().Awake();
            Time.timeScale = 0;
        }
    }
}